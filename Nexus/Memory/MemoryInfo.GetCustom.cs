using System.Collections.Generic;
using System.Linq;
using Nexus.Entity.Entities;

namespace Nexus.Memory
{
    public partial class MemoryInfo : Memory
    {
        public static Customer GetCustomersByPhone(string phone)
        {
            var result  = DicCustomer.Values.FirstOrDefault(x => x.Phone.Equals(phone) || x.Phone == phone) as  Customer;
            if ((result != null && result.IsDeleted == 1) || result == null)
                return null;
            return result;
        }
        public static List<ServiceForm> GetListServicesFormByStartId(string startId)
        {
            return DicServiceForm.Values.ToList().FindAll(x => x.ServiceFormId != null && x.ServiceFormId.StartsWith(startId));
        }
        public static List<Contract> GetListContractByStartId(string startId)
        {
            return DicContract.Values.ToList().FindAll(x => x.ContractId != null && x.ContractId.StartsWith(startId));
        }

        public static Connection GetConnectionByContractId(string idContract)
        {
            var result = DicConnection.Values.FirstOrDefault(x => x.IdContract.Equals(idContract) || x.IdContract.ToString() == idContract) as Connection;
            if ((result != null && result.IsDeleted == 1) || result == null)
                return null;
            return result;
        }
    }
}


