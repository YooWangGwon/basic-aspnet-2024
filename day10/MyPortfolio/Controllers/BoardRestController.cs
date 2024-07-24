using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;

namespace MyPortfolio.Controllers
{
    [Route("api/[controller]")] // BoardRestController에서 Controller 글자를 제외하고 api/BoardRest만 출력 될 수 있게 함
    [ApiController] // 일반 컨트롤러가 아닌 API 컨트롤러임을 명시
    public class BoardRestController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BoardRestController(AppDbContext context)
        {
            _context = context;
        }

        // 일반적인 Form의 메서드는 GET, POST 뿐
        // 추가적으로 사용하는 메서드

        //[HttpGet]   // 화면 요청할 때 사용
        //[HttpPost]  // 값을 저장할 때 사용되는 메서드
        //[HttpPut]   // 값을 수정할 때 사용되는 메서드
        //[HttpPatch] // 값 중에서 한 가지만 수정할 때

        [HttpDelete("{id}")]// 값을 삭제할 때
        public async Task<IActionResult> DeleteBoard(int id)
        {
            var board = await _context.Board.FindAsync(id);   // select * .. where id = id
            if (board == null)
            {
                return NotFound();  // 404 Error!
            }

            _context.Board.Remove(board);   // ASP.NET 상 메모리에 들어있는 DB 객체 데이터 삭제
            await _context.SaveChangesAsync();  // DB가 삭제되고 Commit!

            return NoContent(); // 삭제하고 나서 리턴받는 데이터가 없음
        }
    }
}
