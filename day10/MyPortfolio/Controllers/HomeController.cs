using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyPortfolio.Data;
using MyPortfolio.Helper;
using MyPortfolio.Models;
using System.Diagnostics;
using System.Security.Cryptography;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        private readonly AppDbContext _context;

        

        //public HomeController(ILogger<HomeController> logger, AppDbContext context)
        //{
        //    _logger = logger;
        //    _context = context; //  DB를 연결해서 사용하겠다는 초기화
        //}

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // 회원 로그인으로 새로 추가
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Login(User user)
        {
            // userEmail, password md로 암호화
            // DB에 있는 값과 비교
            var mdHash = MD5.Create();
            user.Password = Common.GetMd5Hash(mdHash, user.Password);   // 로그인 창에 입력한 암호를 암호화

            var result = _context.User.FirstOrDefault(u => u.UserEmail == user.UserEmail && u.Password == user.Password);
            if(result == null) // 로그인할 사람이 없다
            {
                return View(user);
            }
            else
            {
                // 로그인 세션 처리
                HttpContext.Session.SetInt32("USER_LOGIN_KEY", result.Idx);
                HttpContext.Session.SetString("USER_NAME", result.UserName);
                HttpContext.Session.SetString("USER_EMAIL", result.UserEmail);

                return RedirectToAction("Index", "Home"); // 로그인 완료
            }
        }

        [HttpGet]
        public IActionResult Logout()
        {
            // 로그인 세션 처리
            HttpContext.Session.Remove("USER_LOGIN_KEY");
            HttpContext.Session.Remove("USER_NAME");
            HttpContext.Session.Remove("USER_EMAIL");

            return RedirectToAction("Index", "Home"); // 로그인 완료
        }

        // 회원 등록 페이지를 열어줘
        [HttpGet]
        public IActionResult Register()
        {
            return View(); 
        }

        // 회원등록 페이지 내용을 DB에 저장해줘
        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            // 패스워드와 패스워드 확인의 값들이 서로 일치하지 않을 때 일부러 검증 에러를 발생!
            if (user.Password != user.PasswordCheck)
            {
                ModelState.AddModelError("PasswordCheck", "패스워드가 일치하지 않습니다.");
            }

            if (ModelState.IsValid)
            {
                // 모든 값이 정확하게 입력된 경우
                user.RegDate = DateTime.Now;    //  회원 등록 날짜를 오늘로 지정

                // 비밀번호 암호화 부분
                var mdHash = MD5.Create();
                user.Password = Common.GetMd5Hash(mdHash, user.Password);
                user.PasswordCheck = null;

                _context.Add(user); //  INSERT
                await _context.SaveChangesAsync();  // COMMIT
                return RedirectToAction("Login");   // 회원 가입 완료 후 로그인으로
            }

            return View(user);
        }
  

    }
}
