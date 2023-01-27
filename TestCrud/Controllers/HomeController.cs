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

        [HttpGet]
        public IActionResult test()
        {
            RoleRepository roleRepository = new RoleRepository();
            var roles = roleRepository.obtener();
            return Ok(roles);
            
        }


     
        [BindProperty]
        public UserModelLogin userModelLogin { get; set; }

        [HttpPost]
        public IActionResult Login()
        {
           var user =  userModelLogin.login();

            if (user.rol_id == 1)
                return Redirect("Privacy");
            else 
                return Ok("Hola");


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