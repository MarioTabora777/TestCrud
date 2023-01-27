using DataAccess;
using DataAccess.repositories;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Policy;
using TestCrud.Models;

namespace TestCrud.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
           // RoleRepository roleRepository =   new RoleRepository();
           //var roles =  roleRepository.obtener();
           // return Ok(roles);
            return View();
        }

        public IActionResult Register()
        {
            // RoleRepository roleRepository =   new RoleRepository();
            //var roles =  roleRepository.obtener();
            // return Ok(roles);
            return View();
        }



        [BindProperty]
        public UserModelLogin userModelLogin { get; set; }

        [HttpPost]
        public IActionResult Login()
        {
           var user =  userModelLogin.login();

            if (user.rol_id == 1)
                return Redirect("Register");
            else
                return Redirect("Privacy");


        }


        [BindProperty]
        public UserModelBuild userRegistration { get; set; }

        [HttpPost]
        public IActionResult GuardarUsuario()
        {
            UserModelBuild newUser = new UserModelBuild(userRegistration);
            newUser.guardar();
            var user = userRegistration.guardar();


            return Ok(user);

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
    }
}