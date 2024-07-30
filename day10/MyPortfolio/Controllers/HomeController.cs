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
        //    _context = context; //  DB�� �����ؼ� ����ϰڴٴ� �ʱ�ȭ
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

        // ȸ�� �α������� ���� �߰�
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Login(User user)
        {
            // userEmail, password md�� ��ȣȭ
            // DB�� �ִ� ���� ��
            var mdHash = MD5.Create();
            user.Password = Common.GetMd5Hash(mdHash, user.Password);   // �α��� â�� �Է��� ��ȣ�� ��ȣȭ

            var result = _context.User.FirstOrDefault(u => u.UserEmail == user.UserEmail && u.Password == user.Password);
            if(result == null) // �α����� ����� ����
            {
                return View(user);
            }
            else
            {
                // �α��� ���� ó��
                HttpContext.Session.SetInt32("USER_LOGIN_KEY", result.Idx);
                HttpContext.Session.SetString("USER_NAME", result.UserName);
                HttpContext.Session.SetString("USER_EMAIL", result.UserEmail);

                return RedirectToAction("Index", "Home"); // �α��� �Ϸ�
            }
        }

        [HttpGet]
        public IActionResult Logout()
        {
            // �α��� ���� ó��
            HttpContext.Session.Remove("USER_LOGIN_KEY");
            HttpContext.Session.Remove("USER_NAME");
            HttpContext.Session.Remove("USER_EMAIL");

            return RedirectToAction("Index", "Home"); // �α��� �Ϸ�
        }

        // ȸ�� ��� �������� ������
        [HttpGet]
        public IActionResult Register()
        {
            return View(); 
        }

        // ȸ����� ������ ������ DB�� ��������
        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            // �н������ �н����� Ȯ���� ������ ���� ��ġ���� ���� �� �Ϻη� ���� ������ �߻�!
            if (user.Password != user.PasswordCheck)
            {
                ModelState.AddModelError("PasswordCheck", "�н����尡 ��ġ���� �ʽ��ϴ�.");
            }

            if (ModelState.IsValid)
            {
                // ��� ���� ��Ȯ�ϰ� �Էµ� ���
                user.RegDate = DateTime.Now;    //  ȸ�� ��� ��¥�� ���÷� ����

                // ��й�ȣ ��ȣȭ �κ�
                var mdHash = MD5.Create();
                user.Password = Common.GetMd5Hash(mdHash, user.Password);
                user.PasswordCheck = null;

                _context.Add(user); //  INSERT
                await _context.SaveChangesAsync();  // COMMIT
                return RedirectToAction("Login");   // ȸ�� ���� �Ϸ� �� �α�������
            }

            return View(user);
        }

        [HttpGet]
        public IActionResult Project()
        {
            // DB Project ���̺� ������ ����Ʈ�� �޾Ƽ� View�� ����
            var list = _context.Project.ToList();

            foreach(var item in list)
            {
                item.FilePath = item.FilePath.Replace("\\", "/");
                var index = item.FilePath.IndexOf("uploads");
                var finalPath = item.FilePath.Substring(index-1);
                item.FilePath = finalPath;
            }
            return View(list); 
        }
    }
}
