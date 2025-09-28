using Microsoft.AspNetCore.Mvc;

namespace FastEquipmentTool.Controllers
{
    public class RequestController : Controller
    {
        // /RequestForm
        [HttpGet("/RequestForm")]
        public IActionResult Index()
        {
            // Form UI & validation in Milestone 3
            return View();
        }
    }
}