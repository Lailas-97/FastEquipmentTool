using Microsoft.AspNetCore.Mvc;

namespace FastEquipmentTool.Controllers
{
    public class EquipmentController : Controller
    {
        // /AllEquipment
        [HttpGet("/AllEquipment")]
        public IActionResult AllEquipment()
        {
            // View (Bootstrap table) will come in Milestone 4
            return View();
        }

        // /AvailableEquipment
        [HttpGet("/AvailableEquipment")]
        public IActionResult AvailableEquipment()
        {
            // View (filtered table) will come in Milestone 4
            return View();
        }
    }
}