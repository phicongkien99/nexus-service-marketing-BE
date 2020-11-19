using System;
using System.Collections.Generic;
using Nexus.Entity.Entities;

namespace Nexus.Models.Request
{
    public class ImportReceiptReq
    {
        public List<DetailImportReceipt> ListDataTemp { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public int Id { get; set; } //Key 
        public int? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public int IdProvider { get; set; }
        public DateTime ImportDate { get; set; }
        public decimal? TotalPrice { get; set; }

        public ImportReceipt GetEntity()
        {
            return new ImportReceipt
            {
                CreatedAt = CreatedAt,
                CreatedBy = CreatedBy,
                Id = Id,
                ImportDate = ImportDate,
                IsDeleted = IsDeleted,
                IdProvider = IdProvider,
                UpdatedAt = UpdatedAt,
                UpdatedBy = UpdatedBy,
                TotalPrice = TotalPrice
            };
        }
	}
}