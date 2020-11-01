using Nexus.Entity.Entities;

namespace Nexus.Models.Response
{
    public class ImportReceiptResponse : ImportReceipt
    {
        public string ProviderName { get; set; }
        public  string EmployeeName { get; set; }

    }
}