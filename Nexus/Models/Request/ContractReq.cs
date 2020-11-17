using System;
using Nexus.Entity.Entities;

namespace Nexus.Models.Request
{
    public class ContractReq 
    {
		public string ServiceFormId { get; set; }
		public string Address { get; set; }
        public string ContractId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int Id { get; set; } //Key 
        public int IdArea { get; set; }
        public int IdCustomer { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? NextPayment { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public Contract GetEntity()
        {
            return new Contract
            {
                CreatedAt = CreatedAt,
                CreatedBy = CreatedBy,
                Id = Id,
                Address = Address,
                ContractId = ContractId,
                IdArea = IdArea,
                IdCustomer = IdCustomer,
                IsDeleted = IsDeleted,
                NextPayment = NextPayment,
                UpdatedAt = UpdatedAt,
                UpdatedBy = UpdatedBy
            };
        }
    }
}