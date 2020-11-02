namespace Nexus.Entity.Keys
{
    public class ServicePackFeeKeys
    {
        public int IdFee { get; set; } //Key 
        public int IdServicePack { get; set; } //Key 

        public override int GetHashCode()
        {
            unchecked
            {
                int result = IdFee.GetHashCode();
                result = (IdServicePack * 397) ^ IdServicePack.GetHashCode();
                return result;
            }
        }

        public override bool Equals(object obj)
        {

            if (obj is ServicePackFeeKeys)
            {
                var item = obj as ServicePackFeeKeys;
                return IdFee == item.IdFee && IdServicePack == item.IdServicePack;
            }
            return false;
        }
    }
}
