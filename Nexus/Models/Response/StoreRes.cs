using System;
using System.Collections.Generic;
using Nexus.Entity.Entities;

namespace Nexus.Models.Response
{
    public class StoreRes
    {
        public StoreRes(Store entity, List<Employee> lstEmployees)
        {
            ListEmployees = lstEmployees;
            Address = entity.Address;
            CreatedAt = entity.CreatedAt;
            CreatedBy = entity.CreatedBy;
            Id = entity.Id;
            IdArea = entity.IdArea;
            IsClosed = entity.IsClosed;
            IsDeleted = entity.IsDeleted;
            Name = entity.Name;
            UpdatedAt = entity.UpdatedAt;
            UpdatedBy = entity.UpdatedBy;
        }
        public List<Employee> ListEmployees { get; set; }
        public string Address { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int Id { get; set; } //Key 
        public int IdArea { get; set; }
        public int? IsClosed { get; set; }
        public int? IsDeleted { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}