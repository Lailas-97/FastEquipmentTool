using System.Collections.Generic;
using System.Linq;
using FastEquipmentTool.Models;

namespace FastEquipmentTool.Data
{
    public static class EquipmentRepository
    {
        private static readonly List<EquipmentItem> _items = new()
        {
            new EquipmentItem { Id=1, Type=EquipmentType.Laptop,  Description="13\" Ultrabook",     IsAvailable=true },
            new EquipmentItem { Id=2, Type=EquipmentType.Phone,   Description="Loaner iPhone SE",   IsAvailable=false },
            new EquipmentItem { Id=3, Type=EquipmentType.Tablet,  Description="iPad 10th gen",      IsAvailable=true },
            new EquipmentItem { Id=4, Type=EquipmentType.Another, Description="USB-C Dock",         IsAvailable=true },
        };

        public static IEnumerable<EquipmentItem> All() => _items;
        public static IEnumerable<EquipmentItem> Available() => _items.Where(i => i.IsAvailable);
    }
}