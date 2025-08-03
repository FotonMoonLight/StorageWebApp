using DBApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace DBApi.Controllers
{
    [ApiController]
    public class ApiStorageController : Controller
    {
        ApplicationContext db = new ApplicationContext();
        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            db.Database.EnsureCreated();
            List<Resurce> jo = db.Resurces.ToList();
            
             return Content(jo[0].Name); 
        }
    }
}
