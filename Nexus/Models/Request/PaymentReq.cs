using System;
using System.Collections.Generic;
using Nexus.Entity.Entities;

namespace Nexus.Models.Request
{
    public class PaymentReq
    {
        public List<PaymentFee> ListDataTemp { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int Id { get; set; } //Key 
        public int IdContract { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? PayDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public Payment GetEntity()
        {
            return new Payment
            {
                CreatedAt = CreatedAt,
                CreatedBy = CreatedBy,
                Id = Id,
                IdContract = IdContract,
                IsDeleted = IsDeleted,
                PayDate = PayDate,
                TotalPrice = TotalPrice,
                UpdatedAt = UpdatedAt,
                UpdatedBy = UpdatedBy
            };
        }
	}
}