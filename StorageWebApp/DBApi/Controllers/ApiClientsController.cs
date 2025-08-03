using DBApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBApi.Controllers
{
    [ApiController]
    public class ApiClientsController : Controller
    {
        ApplicationContext db = new ApplicationContext();
        [Route("/ClientsApi/GetNoArch")]
        [HttpGet]
        public JsonResult NoArhClientGet()
        {
            List<Client> clien = db.Clients.Where(x => x.State == 0).ToList();
            return Json(clien);
        }
        [Route("/ClientsApi/GetArch")]
        [HttpGet]
        public JsonResult ArchClientGet()
        {
            List<Client> clien = db.Clients.Where(x => x.State == 1).ToList();
            return Json(clien);
        }
        [Route("/ClientsApi/AddClient")]
        [HttpPost]
        public void ClientPost(string name, string adress) 
        {
            Client client = new Client()
            {
                Name = name,
                Adress = adress,
                State = 0
            };
            db.Clients.Add(client);
            db.SaveChanges();
        }
    }
}
