namespace Nexus.Entity.Keys
{
    public class DetailImportReceiptKeys
    {
        public int IdDevice { get; set; } //Key 
        public int IdImportReceipt { get; set; } //Key 

        public override int GetHashCode()
        {
            unchecked
            {
                int result = IdDevice.GetHashCode();
                result = (IdImportReceipt * 397) ^ IdImportReceipt.GetHashCode();
                return result;
            }
        }

        public override bool Equals(object obj)
        {

            if (obj is DetailImportReceiptKeys)
            {
                var item = obj as DetailImportReceiptKeys;
                return IdDevice == item.IdDevice && IdImportReceipt == item.IdImportReceipt;
            }
            return false;
        }
    }
}
