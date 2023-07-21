using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class StaffController : Controller
    {
        private readonly IOurTeamService _ourTeamService;

        public StaffController(IOurTeamService ourTeamService)
        {
            _ourTeamService = ourTeamService;
        }

        public IActionResult Index()
        {
            var values = _ourTeamService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddStaff()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStaff(OurTeam ourTeam)
        {
            _ourTeamService.TInsert(ourTeam);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteStaff(int id)
        {
            var value = _ourTeamService.TGetByID(id);
            _ourTeamService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateStaff(int id)
        {
            var value = _ourTeamService.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateStaff(OurTeam ourTeam)
        {
            _ourTeamService.TUpdate(ourTeam);
            return RedirectToAction("Index");
        }

    }
}
