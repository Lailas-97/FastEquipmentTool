namespace FastEquipmentTool.Models
{
    public class EquipmentItem
    {
        public int Id { get; set; }
        public EquipmentType Type { get; set; }
        public string Description { get; set; } = "";
        public bool IsAvailable { get; set; }   
    }
}