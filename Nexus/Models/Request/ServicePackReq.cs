using System;
using System.Collections.Generic;
using Nexus.Entity.Entities;

namespace Nexus.Models.Request
{
    public class ServicePackReq
    {
        public List<ServicePackFee> ListDataTemp { get; set; }
		public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public string Description { get; set; }
        public int Id { get; set; } //Key 
        public int IdConnectionType { get; set; }
        public int? IsDeleted { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public ServicePack GetEntity()
        {
            return new ServicePack
            {
                CreatedAt = CreatedAt,
                CreatedBy = CreatedBy,
                Id = Id,
                Description = Description,
                IsDeleted = IsDeleted,
                IdConnectionType = IdConnectionType,
                Name = Name,
                UpdatedAt = UpdatedAt,
                UpdatedBy = UpdatedBy
            };
        }
    }
}