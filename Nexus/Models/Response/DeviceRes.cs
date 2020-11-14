using System;
using Nexus.Entity.Entities;

namespace Nexus.Models.Response
{
    public class DeviceRes
    {
        public DeviceRes(Device entity, Manufacturer manufacturer)
        {
            Manufacturer = manufacturer;
            CreatedAt = entity.CreatedAt;
            CreatedBy = entity.CreatedBy;
            Id = entity.Id;
            IdDeviceType = entity.IdDeviceType;
            IdManufacturer = entity.IdManufacturer;
            Stock = entity.Stock;
            UpdatedAt = entity.UpdatedAt;
            UpdatedBy = entity.UpdatedBy;
            IsDeleted = entity.IsDeleted;
            Name = entity.Name;
        }
        public Manufacturer Manufacturer { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int Id { get; set; } //Key 
        public int IdDeviceType { get; set; }
        public int IdManufacturer { get; set; }
        public int? IsDeleted { get; set; }
        public string Name { get; set; }
        public int? Stock { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public int? Using { get; set; }
    }
}