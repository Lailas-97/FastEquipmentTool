using FastEquipmentTool.Data;
using FastEquipmentTool.Models;
using Microsoft.AspNetCore.Mvc;

namespace FastEquipmentTool.Controllers
{
    public class RequestController : Controller
    {
        [HttpGet("/RequestForm")]
        public IActionResult Index() => View(new EquipmentRequest());

        [HttpPost("/RequestForm")]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(EquipmentRequest model)
        {
            if (!ModelState.IsValid) return View("Index", model);
            var saved = RequestRepository.Add(model);
            return RedirectToAction(nameof(Confirmation), new { id = saved.Id });
        }

        [HttpGet("/RequestForm/Confirmation/{id:int}")]
        public IActionResult Confirmation(int id)
        {
            ViewData["RequestId"] = id;
            return View();
        }
        public IActionResult Requests()
{
    var requests = RequestRepository.GetAll(); // <-- not .Requests
    return View(requests);
}
    }
    
}