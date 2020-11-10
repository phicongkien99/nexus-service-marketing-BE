using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Anotar.NLog;
using Nexus.Entity.Keys;
using Nexus.Common.Enum;
using Nexus.Entity.Entities;

namespace Nexus.Memory
{
    public partial class MemoryInfo : Memory
    {
        public static Area GetArea(int id)
        {
            if (DicArea.ContainsKey(id))
                return DicArea[id].Clone() as Area;
            LogTo.Error("Not get Area by id = " + id);
            return null;
        }

        public static Connection GetConnection(int id)
        {
            if (DicConnection.ContainsKey(id))
                return DicConnection[id].Clone() as Connection;
            LogTo.Error("Not get Connection by id = " + id);
            return null;
        }

        public static ConnectionStatus GetConnectionStatus(int id)
        {
            if (DicConnectionStatus.ContainsKey(id))
                return DicConnectionStatus[id].Clone() as ConnectionStatus;
            LogTo.Error("Not get ConnectionStatus by id = " + id);
            return null;
        }

        public static ConnectionType GetConnectionType(int id)
        {
            if (DicConnectionType.ContainsKey(id))
                return DicConnectionType[id].Clone() as ConnectionType;
            LogTo.Error("Not get ConnectionType by id = " + id);
            return null;
        }

        public static Contract GetContract(int id)
        {
            if (DicContract.ContainsKey(id))
                return DicContract[id].Clone() as Contract;
            LogTo.Error("Not get Contract by id = " + id);
            return null;
        }

        public static ContractStatus GetContractStatus(int id)
        {
            if (DicContractStatus.ContainsKey(id))
                return DicContractStatus[id].Clone() as ContractStatus;
            LogTo.Error("Not get ContractStatus by id = " + id);
            return null;
        }

        public static Customer GetCustomer(int id)
        {
            if (DicCustomer.ContainsKey(id))
                return DicCustomer[id].Clone() as Customer;
            LogTo.Error("Not get Customer by id = " + id);
            return null;
        }

        public static CustomerFeedback GetCustomerFeedback(int id)
        {
            if (DicCustomerFeedback.ContainsKey(id))
                return DicCustomerFeedback[id].Clone() as CustomerFeedback;
            LogTo.Error("Not get CustomerFeedback by id = " + id);
            return null;
        }

        public static DetailImportReceipt GetDetailImportReceipt(DetailImportReceiptKeys detailImportReceiptKeys)
        {
            if (DicDetailImportReceipt.ContainsKey(detailImportReceiptKeys))
                return DicDetailImportReceipt[detailImportReceiptKeys].Clone() as DetailImportReceipt;
            LogTo.Error("Not get DetailImportReceipt by detailImportReceiptKeys = " + detailImportReceiptKeys);
            return null;
        }

        public static Device GetDevice(int id)
        {
            if (DicDevice.ContainsKey(id))
                return DicDevice[id].Clone() as Device;
            LogTo.Error("Not get Device by id = " + id);
            return null;
        }

        public static DeviceType GetDeviceType(int id)
        {
            if (DicDeviceType.ContainsKey(id))
                return DicDeviceType[id].Clone() as DeviceType;
            LogTo.Error("Not get DeviceType by id = " + id);
            return null;
        }

        public static Employee GetEmployee(int id)
        {
            if (DicEmployee.ContainsKey(id))
                return DicEmployee[id].Clone() as Employee;
            LogTo.Error("Not get Employee by id = " + id);
            return null;
        }

        public static Fee GetFee(int id)
        {
            if (DicFee.ContainsKey(id))
                return DicFee[id].Clone() as Fee;
            LogTo.Error("Not get Fee by id = " + id);
            return null;
        }

        public static Image GetImage(int id)
        {
            if (DicImage.ContainsKey(id))
                return DicImage[id].Clone() as Image;
            LogTo.Error("Not get Image by id = " + id);
            return null;
        }

        public static ImportReceipt GetImportReceipt(int id)
        {
            if (DicImportReceipt.ContainsKey(id))
                return DicImportReceipt[id].Clone() as ImportReceipt;
            LogTo.Error("Not get ImportReceipt by id = " + id);
            return null;
        }

        public static Manufacturer GetManufacturer(int id)
        {
            if (DicManufacturer.ContainsKey(id))
                return DicManufacturer[id].Clone() as Manufacturer;
            LogTo.Error("Not get Manufacturer by id = " + id);
            return null;
        }

        public static Payment GetPayment(int id)
        {
            if (DicPayment.ContainsKey(id))
                return DicPayment[id].Clone() as Payment;
            LogTo.Error("Not get Payment by id = " + id);
            return null;
        }

        public static PaymentFee GetPaymentFee(PaymentFeeKeys paymentFeeKeys)
        {
            if (DicPaymentFee.ContainsKey(paymentFeeKeys))
                return DicPaymentFee[paymentFeeKeys].Clone() as PaymentFee;
            LogTo.Error("Not get PaymentFee by paymentFeeKeys = " + paymentFeeKeys);
            return null;
        }

        public static Provider GetProvider(int id)
        {
            if (DicProvider.ContainsKey(id))
                return DicProvider[id].Clone() as Provider;
            LogTo.Error("Not get Provider by id = " + id);
            return null;
        }

        public static ServiceForm GetServiceForm(int id)
        {
            if (DicServiceForm.ContainsKey(id))
                return DicServiceForm[id].Clone() as ServiceForm;
            LogTo.Error("Not get ServiceForm by id = " + id);
            return null;
        }

        public static ServiceFormStatus GetServiceFormStatus(int id)
        {
            if (DicServiceFormStatus.ContainsKey(id))
                return DicServiceFormStatus[id].Clone() as ServiceFormStatus;
            LogTo.Error("Not get ServiceFormStatus by id = " + id);
            return null;
        }

        public static ServicePack GetServicePack(int id)
        {
            if (DicServicePack.ContainsKey(id))
                return DicServicePack[id].Clone() as ServicePack;
            LogTo.Error("Not get ServicePack by id = " + id);
            return null;
        }

        public static ServicePackFee GetServicePackFee(ServicePackFeeKeys servicePackFeeKeys)
        {
            if (DicServicePackFee.ContainsKey(servicePackFeeKeys))
                return DicServicePackFee[servicePackFeeKeys].Clone() as ServicePackFee;
            LogTo.Error("Not get ServicePackFee by servicePackFeeKeys = " + servicePackFeeKeys);
            return null;
        }

        public static Store GetStore(int id)
        {
            if (DicStore.ContainsKey(id))
                return DicStore[id].Clone() as Store;
            LogTo.Error("Not get Store by id = " + id);
            return null;
        }
    }
}