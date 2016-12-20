using MVCAjaxFormDemo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCAjaxFormDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Demo()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult GetClientMessages(ClientMessage vm)
        {
            var db = new List<ClientMessage> {
                new ClientMessage {Id = 1, Name = "Abhimanyu", Email = "abhimanyu@itorian.com" },
                new ClientMessage {Id = 2, Name = "Ritesh", Email = "ritesh@itorian.com" },
                new ClientMessage {Id = 3, Name = "Niraj", Email = "niraj@itorian.com" },
                new ClientMessage {Id = 4, Name = "Rohit", Email = "rohit@itorian.com" },
                new ClientMessage {Id = 5, Name = "Rahul", Email = "rahul@itorian.com" },
            };

            var model = db.Where(i => i.Name.Contains(vm.Name) || i.Email.Contains(vm.Name));

            return PartialView("_PartialView", model);
        }
    }
}