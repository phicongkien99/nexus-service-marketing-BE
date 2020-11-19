using System;
using System.Collections.Generic;
using Nexus.Entity.Entities;

namespace Nexus.Models.Response
{
    public class ImportReceiptRes: ImportReceipt
    {
        public ImportReceiptRes(ImportReceipt entity, List<DetailImportReceipt> listDetailImportReceipt)
        {
            ListDetailImportReceipt = listDetailImportReceipt;
            IdProvider = entity.IdProvider;
            ImportDate = entity.ImportDate;
            TotalPrice = entity.TotalPrice;
            CreatedAt = entity.CreatedAt;
            CreatedBy = entity.CreatedBy;
            Id = entity.Id;
            IsDeleted = entity.IsDeleted;
            UpdatedAt = entity.UpdatedAt;
            UpdatedBy = entity.UpdatedBy;
        }
        public List<DetailImportReceipt> ListDetailImportReceipt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int Id { get; set; } //Key 
        public int? IsDeleted { get; set; }
        public int IdProvider { get; set; }
        public DateTime ImportDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

    }
}