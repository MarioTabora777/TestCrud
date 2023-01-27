using DataAccess;
using DataAccess.repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
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
        //public IActionResult test()
        //{
        //    RoleRepository roleRepository = new RoleRepository();
        //    var roles = roleRepository.obtener();
        //    return Ok(roles);
            
        //}
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