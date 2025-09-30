using System.Collections.Generic;
using System.Linq;
using FastEquipmentTool.Models;

namespace FastEquipmentTool.Data
{
    public static class RequestRepository
    {
        private static readonly List<EquipmentRequest> _requests = new();
        private static int _nextId = 1;

        public static IEnumerable<EquipmentRequest> GetAll() => _requests;

        public static EquipmentRequest Add(EquipmentRequest req)
        {
            req.Id = _nextId++;
            _requests.Add(req);
            return req;
        }

        public static EquipmentRequest? GetById(int id)
            => _requests.FirstOrDefault(r => r.Id == id);
    }
}