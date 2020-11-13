using System;
using System.Collections.Generic;
using Nexus.Entity.Entities;

namespace Nexus.Models.Response
{
    public class PaymentRes
    {
        public PaymentRes(Payment entity, List<PaymentFee> listPaymentFee)
        {
            ListPaymentFee = listPaymentFee;
            IdContract = entity.IdContract;
            PayDate = entity.PayDate;
            TotalPrice = entity.TotalPrice;
            CreatedAt = entity.CreatedAt;
            CreatedBy = entity.CreatedBy;
            Id = entity.Id;
            IsDeleted = entity.IsDeleted;
            UpdatedAt = entity.UpdatedAt;
            UpdatedBy = entity.UpdatedBy;
        }
        public List<PaymentFee> ListPaymentFee { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int Id { get; set; } //Key 
        public int IdContract { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? PayDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}