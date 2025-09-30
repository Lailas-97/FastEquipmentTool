using Microsoft.AspNetCore.Mvc;
using FastEquipmentTool.Models;
using System.Collections.Generic;

namespace FastEquipmentTool.Controllers
{
    public class EquipmentController : Controller
    {
        private static List<EquipmentItem> _equipment = new List<EquipmentItem>
        {
            new EquipmentItem { Id = 1, Type = EquipmentType.Laptop, Description = "Dell XPS 13", IsAvailable = true },
            new EquipmentItem { Id = 2, Type = EquipmentType.Phone, Description = "iPhone 13", IsAvailable = false },
            new EquipmentItem { Id = 3, Type = EquipmentType.Tablet, Description = "iPad Pro", IsAvailable = true }
        };

        public IActionResult AllEquipment()
        {
            return View(_equipment);
        }

        public IActionResult AvailableEquipment()
        {
            var available = _equipment.FindAll(e => e.IsAvailable);
            return View(available);
        }
    }
}