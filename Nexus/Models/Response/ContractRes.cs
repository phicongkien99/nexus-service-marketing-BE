using System;
using System.Collections.Generic;
using Nexus.Entity.Entities;

namespace Nexus.Models.Response
{
    public class ContractRes
    {
        public ContractRes(Contract entity, Customer customer, List<Payment> lstPayments = null)
        {
            Customer = customer;
            ListpaPayments = lstPayments;
            Address = entity.Address;
            ContractId = entity.ContractId;
            CreatedAt = entity.CreatedAt;
            CreatedBy = entity.CreatedBy;
            Id = entity.Id;
            IdArea = entity.IdArea;
            IdCustomer = entity.IdCustomer;
            NextPayment = entity.NextPayment;
            UpdatedAt = entity.UpdatedAt;
            UpdatedBy = entity.UpdatedBy;
        }
        public Customer Customer { get; set; }
        public List<Payment> ListpaPayments { get; set; }
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
    }
}