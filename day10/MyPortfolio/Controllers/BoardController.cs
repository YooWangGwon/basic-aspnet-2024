using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.Data;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
    public class BoardController : Controller
    {
        private readonly AppDbContext _context;

        public BoardController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Board
        // AddDbContext(DB 핸들링 객체) 안의 Board DBSet객체에다가
        // 들어있는 데이터를 리스트로 가져와서
        // 화면으로 보낸 다음에 출력하라
        // Views/Board/Index.cshtml을 화면에 뿌려라
        // return View(await _context.Board.ToListAsync());
        public IActionResult Index(int page = 1, string search="")
        {
            // FromSql()로 작업할 경우, 비동기(async, await, Task<>) 를 걷어내야 함
            var totalCount = _context.Board.FromSqlRaw<Board>($"SELECT * FROM Board WHERE Title LIKE '%{search}%'").Count(); // 총 글갯수
            var countList = 10; // 페이지별 게시글 수
            var totalPage = totalCount / countList; // 총 페이지 수

            if (totalCount % countList > 0) totalPage++;    // 12 % 10 == 2 > 0 --> 한 페이지가 더 필요함
            if(totalPage < page) page = totalPage; // 현재 페이지 번호가 전체 페이지 수보다 크면 축소시켜줌

            var countPage = 10; // 밑에 페이지 번호 수
            var startPage = ((page - 1) / countPage) * countPage + 1;   // 1~10페이지, 11~20페이지 식으로
            var endPage = startPage + countPage -1; // 1페이지부터 시작하면 10페이지가 마지막
            if(totalPage < endPage) endPage = totalPage;    // 2페이지까지 밖에 없으면 endPage 10 -> 2로 변경

            // 쿼리로 넘겨줄 값
            var startCount = ((page - 1) * countPage) + 1;   // 1, 11, 21... 순으로
            var endCount = startCount + (countPage - 1); // 10, 20, 30... 순으로

            // ViewData(Dict), ViewBag(Prop) 변수...(뷰cshtml에서 사용할 변수)
            ViewBag.Start = startPage;
            ViewBag.End = endPage;
            ViewBag.Page = page;
            ViewBag.TotalPage = totalPage;
            ViewBag.TotalCount = totalCount;    // 전체 글 갯수
            ViewBag.Search = search; // 검색결과

            //var StartCount = new SqlParameter("StartCount", startCount);
            //var EndCount = new SqlParameter("EndCount", endCount);
            var list = _context.Board.FromSqlRaw<Board>(@$"SELECT *
                                                          FROM (
                                                          SELECT ROW_NUMBER() OVER(ORDER BY ID DESC) AS rowNum 
	                                                          ,Id
                                                              ,Name
                                                              ,UserId
                                                              ,Title
                                                              ,Contents
                                                              ,Hit
                                                              ,RegDate
                                                              ,ModDate
                                                          FROM Board
                                                         WHERE Title LIKE '%{search}%'
                                                          ) AS base
                                                         WHERE base.rowNum BETWEEN {startCount} AND {endCount}").ToList();


            return View(list);
        }

        // GET: Board/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var board = await _context.Board
                .FirstOrDefaultAsync(m => m.Id == id);  // SELECT * FROM board WHERE ~
            if (board == null)
            {
                return NotFound();
            }
            // 게시글 조회수를 1 증가

            board.Hit += 1;
            _context.Update(board); // 객체에 내용 반영
            await _context.SaveChangesAsync();  // 실제 DB를 반영

            return View(board); // 게시글을 하나의 뷰로 던져줘!
        }

        // GET: Board/Create
        // 링크를 클릭해서 화면이 전환됨
        public IActionResult Create()
        {
            // Views/Board/Create.cshtml 화면을 출력하라
            return View();
        }

        // POST: Board/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        // 기본값은 [HttpGet]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,UserId,Title,Contents,Hit,RegDate,ModDate")] Board board)
        {
            // 아무 값도 입력하지 않으면 ModelState.IsValid는 false이다.
            if (ModelState.IsValid)
            {
                board.RegDate = DateTime.Now;
                board.ModDate = null;
                _context.Add(board);    // 여기까지는 ASP.NET의 DB 객체에까지만 저장
                await _context.SaveChangesAsync();  // MSSQL의 DB에 Insert 후 Commit 실행
                return RedirectToAction(nameof(Index)); // 저장 후 게시판 목록 화면으로 돌아감
            }
            return View(board);
        }

        // GET: Board/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var board = await _context.Board.FindAsync(id); // SELECT * FROM WHERE Id = @id
            if (board == null)
            {
                return NotFound();
            }
            return View(board); // Edit.cshtml을 출력
        }

        // POST: Board/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,UserId,Title,Contents,Hit,RegDate,ModDate")] Board board)
        {
            if (id != board.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // 수정 날짜를 추가
                    board.ModDate = DateTime.Now;   // 현재 수정하는 날짜와 시간을 입력
                    _context.Update(board); // 수정
                    // DB Upadte and Commit
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoardExists(board.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(board);
        }

        // GET: Board/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var board = await _context.Board
                .FirstOrDefaultAsync(m => m.Id == id);
            if (board == null)
            {
                return NotFound();
            }

            return View(board);
        }

        // POST: Board/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var board = await _context.Board.FindAsync(id);
            if (board != null)
            {
                _context.Board.Remove(board);
            }

            // DB Delete 후에 Commit
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoardExists(int id)
        {
            return _context.Board.Any(e => e.Id == id);
        }
    }
}
