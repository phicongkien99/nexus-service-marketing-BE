using System;
using Nexus.Entity.Entities;

namespace Nexus.Models.Response
{
    public class ServicesPackRes
    {
        public ServicesPackRes(ServicePack entity, string connectionTypeName)
        {
            ConnectionTypeName = connectionTypeName;
            CreatedAt = entity.CreatedAt;
            CreatedBy = entity.CreatedBy;
            Description = entity.Description;
            Id = entity.Id;
            IdConnectionType = entity.IdConnectionType;
            IsDeleted = entity.IsDeleted;
            Name = entity.Name;
            UpdatedAt = entity.UpdatedAt;
            UpdatedBy = entity.UpdatedBy;
        }
        public string ConnectionTypeName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public string Description { get; set; }
        public int Id { get; set; } //Key 
        public int IdConnectionType { get; set; }
        public int? IsDeleted { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}