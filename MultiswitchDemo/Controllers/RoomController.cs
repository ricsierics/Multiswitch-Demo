using MultiswitchDemo.Models;
using System.Web.Mvc;

namespace MultiswitchDemo.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        public ActionResult Create()
        {
            return View(new Room());
        }

        [HttpPost]
        public ActionResult Create(Room model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //do stuff

            return View(model);
        }
    }
}