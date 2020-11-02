using System;
using System.Collections.Generic;
using System.Globalization;
using Nexus.Entity.Keys;
using System.Linq;
using Nexus.Common.Enum;
using Nexus.Entity;
using Anotar.NLog;
using Nexus.Entity.Entities;

namespace Nexus.Memory
{
    public partial class MemorySet : Memory
    {
        public static void SortAllDic()
        {
            try
            {
                DicArea = DicArea.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicConnection = DicConnection.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicConnectionStatus = DicConnectionStatus.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicConnectionType = DicConnectionType.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicContract = DicContract.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicCustomer = DicCustomer.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicCustomerFeedback = DicCustomerFeedback.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicDevice = DicDevice.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicDeviceType = DicDeviceType.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicEmployee = DicEmployee.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicFee = DicFee.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicImage = DicImage.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicImportReceipt = DicImportReceipt.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicManufacturer = DicManufacturer.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicPayment = DicPayment.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicProvider = DicProvider.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicServiceForm = DicServiceForm.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicServiceFormStatus = DicServiceFormStatus.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicServicePack = DicServicePack.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                DicStore = DicStore.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            }
            catch (Exception ex)
            {
                LogTo.Error(ex.ToString());
            }
        }

        public static void ClearAllDic()
        {
            try
            {
                DicArea.Clear();
                DicConnection.Clear();
                DicConnectionStatus.Clear();
                DicConnectionType.Clear();
                DicContract.Clear();
                DicCustomer.Clear();
                DicCustomerFeedback.Clear();
                DicDetailImportReceipt.Clear();
                DicDevice.Clear();
                DicDeviceType.Clear();
                DicEmployee.Clear();
                DicFee.Clear();
                DicImage.Clear();
                DicImportReceipt.Clear();
                DicManufacturer.Clear();
                DicPayment.Clear();
                DicPaymentFee.Clear();
                DicProvider.Clear();
                DicServiceForm.Clear();
                DicServiceFormStatus.Clear();
                DicServicePack.Clear();
                DicServicePackFee.Clear();
                DicStore.Clear();
            }
            catch (Exception ex)
            {
                LogTo.Error(ex.ToString());
            }
        }

        public static void UpdateAndInsertEntity(BaseEntity entity)
        {
            #region Bảng sinh key bằng tay

            if (entity is Area)
                SetMemory(entity as Area);
            else if (entity is Connection)
                SetMemory(entity as Connection);
            else if (entity is ConnectionStatus)
                SetMemory(entity as ConnectionStatus);
            else if (entity is ConnectionType)
                SetMemory(entity as ConnectionType);
            else if (entity is Contract)
                SetMemory(entity as Contract);
            else if (entity is Customer)
                SetMemory(entity as Customer);
            else if (entity is CustomerFeedback)
                SetMemory(entity as CustomerFeedback);
            else if (entity is DetailImportReceipt)
                SetMemory(entity as DetailImportReceipt);
            else if (entity is Device)
                SetMemory(entity as Device);
            else if (entity is DeviceType)
                SetMemory(entity as DeviceType);
            else if (entity is Employee)
                SetMemory(entity as Employee);
            else if (entity is Fee)
                SetMemory(entity as Fee);
            else if (entity is Image)
                SetMemory(entity as Image);
            else if (entity is ImportReceipt)
                SetMemory(entity as ImportReceipt);
            else if (entity is Manufacturer)
                SetMemory(entity as Manufacturer);
            else if (entity is Payment)
                SetMemory(entity as Payment);
            else if (entity is PaymentFee)
                SetMemory(entity as PaymentFee);
            else if (entity is Provider)
                SetMemory(entity as Provider);
            else if (entity is ServiceForm)
                SetMemory(entity as ServiceForm);
            else if (entity is ServiceFormStatus)
                SetMemory(entity as ServiceFormStatus);
            else if (entity is ServicePack)
                SetMemory(entity as ServicePack);
            else if (entity is ServicePackFee)
                SetMemory(entity as ServicePackFee);
            else if (entity is Store)
                SetMemory(entity as Store);

            #endregion

            #region Bảng tự sinh Key

            #endregion
        }

        public static void RemoveEntity(BaseEntity entity)
        {
            #region Bảng sinh key bằng tay

            if (entity is Area)
                RemoveMemory(entity as Area);
            else if (entity is Connection)
                RemoveMemory(entity as Connection);
            else if (entity is ConnectionStatus)
                RemoveMemory(entity as ConnectionStatus);
            else if (entity is ConnectionType)
                RemoveMemory(entity as ConnectionType);
            else if (entity is Contract)
                RemoveMemory(entity as Contract);
            else if (entity is Customer)
                RemoveMemory(entity as Customer);
            else if (entity is CustomerFeedback)
                RemoveMemory(entity as CustomerFeedback);
            else if (entity is DetailImportReceipt)
                RemoveMemory(entity as DetailImportReceipt);
            else if (entity is Device)
                RemoveMemory(entity as Device);
            else if (entity is DeviceType)
                RemoveMemory(entity as DeviceType);
            else if (entity is Employee)
                RemoveMemory(entity as Employee);
            else if (entity is Fee)
                RemoveMemory(entity as Fee);
            else if (entity is Image)
                RemoveMemory(entity as Image);
            else if (entity is ImportReceipt)
                RemoveMemory(entity as ImportReceipt);
            else if (entity is Manufacturer)
                RemoveMemory(entity as Manufacturer);
            else if (entity is Payment)
                RemoveMemory(entity as Payment);
            else if (entity is PaymentFee)
                RemoveMemory(entity as PaymentFee);
            else if (entity is Provider)
                RemoveMemory(entity as Provider);
            else if (entity is ServiceForm)
                RemoveMemory(entity as ServiceForm);
            else if (entity is ServiceFormStatus)
                RemoveMemory(entity as ServiceFormStatus);
            else if (entity is ServicePack)
                RemoveMemory(entity as ServicePack);
            else if (entity is ServicePackFee)
                RemoveMemory(entity as ServicePackFee);
            else if (entity is Store)
                RemoveMemory(entity as Store);

            #endregion

            #region Bảng tự sinh Key

            #endregion
        }
    }
}