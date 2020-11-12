using System.Collections.Generic;
using System.Linq;
using Nexus.Entity.Entities;

namespace Nexus.Memory
{
    public partial class MemoryInfo : Memory
    {
        public static Customer GetCustomersByPhone(string phone)
        {
            var result  = DicCustomer.Values.First(x => x.Phone.Equals(phone) || x.Phone == phone) as  Customer;
            if (result != null && result.IsDeleted == 1)
                return null;
            return result;
        }
    }
}


