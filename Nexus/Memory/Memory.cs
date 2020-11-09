using System;
using System.Collections.Generic;
using Nexus.Entity.Entities;
using Nexus.Entity.Keys;

namespace Nexus.Memory
{
    public class Memory
    {
        #region Dang ki memory

        public static List<string> GetListEntityNameInit()
        {
            return new List<string>
            {
                Area.EntityName(),
                Connection.EntityName(),
                ConnectionStatus.EntityName(),
                ConnectionType.EntityName(),
                Contract.EntityName(),
                Customer.EntityName(),
                CustomerFeedback.EntityName(),
                DetailImportReceipt.EntityName(),
                Device.EntityName(),
                DeviceType.EntityName(),
                Employee.EntityName(),
                Fee.EntityName(),
                Image.EntityName(),
                ImportReceipt.EntityName(),
                Manufacturer.EntityName(),
                Payment.EntityName(),
                PaymentFee.EntityName(),
                Provider.EntityName(),
                ServiceForm.EntityName(),
                ServiceFormStatus.EntityName(),
                ServicePack.EntityName(),
                ServicePackFee.EntityName(),
                Store.EntityName(),
            };
        }

        #endregion


        public static Dictionary<string, int> DicMaxKeyEntity = new Dictionary<string, int>();
        public static Dictionary<int, Area> DicArea = new Dictionary<int, Area>();

        public static Dictionary<int, Connection> DicConnection = new Dictionary<int, Connection>();

        public static Dictionary<int, ConnectionStatus> DicConnectionStatus = new Dictionary<int, ConnectionStatus>();

        public static Dictionary<int, ConnectionType> DicConnectionType = new Dictionary<int, ConnectionType>();

        public static Dictionary<int, Contract> DicContract = new Dictionary<int, Contract>();

        public static Dictionary<int, ContractStatus> DicContractStatus = new Dictionary<int, ContractStatus>();

        public static Dictionary<int, Customer> DicCustomer = new Dictionary<int, Customer>();

        public static Dictionary<int, CustomerFeedback> DicCustomerFeedback = new Dictionary<int, CustomerFeedback>();

        public static Dictionary<DetailImportReceiptKeys, DetailImportReceipt> DicDetailImportReceipt = new Dictionary<DetailImportReceiptKeys, DetailImportReceipt>();

        public static Dictionary<int, Device> DicDevice = new Dictionary<int, Device>();

        public static Dictionary<int, DeviceType> DicDeviceType = new Dictionary<int, DeviceType>();

        public static Dictionary<int, Employee> DicEmployee = new Dictionary<int, Employee>();

        public static Dictionary<int, Fee> DicFee = new Dictionary<int, Fee>();

        public static Dictionary<int, Image> DicImage = new Dictionary<int, Image>();

        public static Dictionary<int, ImportReceipt> DicImportReceipt = new Dictionary<int, ImportReceipt>();

        public static Dictionary<int, Manufacturer> DicManufacturer = new Dictionary<int, Manufacturer>();

        public static Dictionary<int, Payment> DicPayment = new Dictionary<int, Payment>();

        public static Dictionary<PaymentFeeKeys, PaymentFee> DicPaymentFee = new Dictionary<PaymentFeeKeys, PaymentFee>();

        public static Dictionary<int, Provider> DicProvider = new Dictionary<int, Provider>();

        public static Dictionary<int, ServiceForm> DicServiceForm = new Dictionary<int, ServiceForm>();

        public static Dictionary<int, ServiceFormStatus> DicServiceFormStatus = new Dictionary<int, ServiceFormStatus>();

        public static Dictionary<int, ServicePack> DicServicePack = new Dictionary<int, ServicePack>();

        public static Dictionary<ServicePackFeeKeys, ServicePackFee> DicServicePackFee = new Dictionary<ServicePackFeeKeys, ServicePackFee>();

        public static Dictionary<int, Store> DicStore = new Dictionary<int, Store>();


        public static int GetMaxKey(string entityName)
        {
            try
            {
                if (!DicMaxKeyEntity.ContainsKey(entityName))
                    return 0;
                return DicMaxKeyEntity[entityName];
            }
            catch (Exception ex)
            {
                Logger.Write(ex.ToString());
                throw;
            }
        }
    }
}