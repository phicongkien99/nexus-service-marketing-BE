using System;
using Nexus.Entity.Entities;

namespace Nexus.Models.Response
{
    public class CustomerFeedbackRes
    {
        public CustomerFeedbackRes(CustomerFeedback entity, Customer customer)
        {
            Customer = customer;
            Content = entity.Content;
            CreatedAt = entity.CreatedAt;
            CreatedBy = entity.CreatedBy;
            Id = entity.Id;
            IdCustomer = entity.IdCustomer;
            Rating = entity.Rating;
            UpdatedAt = entity.UpdatedAt;
            UpdatedBy = entity.UpdatedBy;
        }
        public Customer Customer { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int Id { get; set; } //Key 
        public int IdCustomer { get; set; }
        public int? IsDeleted { get; set; }
        public int? Rating { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}