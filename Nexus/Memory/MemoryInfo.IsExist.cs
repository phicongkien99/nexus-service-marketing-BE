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
        public static bool IsExistArea(int id)
        {
            if (DicArea.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistConnection(int id)
        {
            if (DicConnection.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistConnectionStatus(int id)
        {
            if (DicConnectionStatus.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistConnectionType(int id)
        {
            if (DicConnectionType.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistContract(int id)
        {
            if (DicContract.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistCustomer(int id)
        {
            if (DicCustomer.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistCustomerFeedback(int id)
        {
            if (DicCustomerFeedback.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistDetailImportReceipt(DetailImportReceiptKeys detailImportReceiptKeys)
        {
            if (DicDetailImportReceipt.ContainsKey(detailImportReceiptKeys))
                return true;
            return false;
        }

        public static bool IsExistDevice(int id)
        {
            if (DicDevice.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistDeviceType(int id)
        {
            if (DicDeviceType.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistEmployee(int id)
        {
            if (DicEmployee.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistFee(int id)
        {
            if (DicFee.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistImage(int id)
        {
            if (DicImage.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistImportReceipt(int id)
        {
            if (DicImportReceipt.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistManufacturer(int id)
        {
            if (DicManufacturer.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistPayment(int id)
        {
            if (DicPayment.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistPaymentFee(PaymentFeeKeys paymentFeeKeys)
        {
            if (DicPaymentFee.ContainsKey(paymentFeeKeys))
                return true;
            return false;
        }

        public static bool IsExistProvider(int id)
        {
            if (DicProvider.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistServiceForm(int id)
        {
            if (DicServiceForm.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistServiceFormStatus(int id)
        {
            if (DicServiceFormStatus.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistServicePack(int id)
        {
            if (DicServicePack.ContainsKey(id))
                return true;
            return false;
        }

        public static bool IsExistServicePackFee(ServicePackFeeKeys servicePackFeeKeys)
        {
            if (DicServicePackFee.ContainsKey(servicePackFeeKeys))
                return true;
            return false;
        }

        public static bool IsExistStore(int id)
        {
            if (DicStore.ContainsKey(id))
                return true;
            return false;
        }
    }
}