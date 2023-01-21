using C2CPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace C2CPortal.Controllers
{
    public class CollegeController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentRegistration()
        {
            return View();
        }        
        public void PostStudentData() 
        {
            //var context = new AppDBContext(serviceProvider.GetRequiredService<DbContextOptions<AppDBContext>>());                       
        }
    }
}
