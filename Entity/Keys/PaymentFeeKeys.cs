namespace Nexus.Entity.Keys
{
    public class PaymentFeeKeys
    {
        public int IdFee { get; set; } //Key 
        public int IdPayment { get; set; } //Key 

        public override int GetHashCode()
        {
            unchecked
            {
                int result = IdFee.GetHashCode();
                result = (IdPayment * 397) ^ IdPayment.GetHashCode();
                return result;
            }
        }

        public override bool Equals(object obj)
        {

            if (obj is PaymentFeeKeys)
            {
                var item = obj as PaymentFeeKeys;
                return IdFee == item.IdFee && IdPayment == item.IdPayment;
            }
            return false;
        }
    }
}
