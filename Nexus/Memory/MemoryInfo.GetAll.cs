using System;
using System.Collections.Generic;
using System.Globalization;
using Nexus.Entity.Keys;
using System.Linq;
using Nexus.Common.Enum;
using Nexus.Entity.Entities;

namespace Nexus.Memory
{
    public partial class MemoryInfo : Memory
    {
        public static List<Area> GetAllArea()
        {
            return DicArea.Select(obj => obj.Value.Clone() as Area).ToList();
        }

        public static List<Connection> GetAllConnection()
        {
            return DicConnection.Select(obj => obj.Value.Clone() as Connection).ToList();
        }

        public static List<ConnectionStatus> GetAllConnectionStatus()
        {
            return DicConnectionStatus.Select(obj => obj.Value.Clone() as ConnectionStatus).ToList();
        }

        public static List<ConnectionType> GetAllConnectionType()
        {
            return DicConnectionType.Select(obj => obj.Value.Clone() as ConnectionType).ToList();
        }

        public static List<Contract> GetAllContract()
        {
            return DicContract.Select(obj => obj.Value.Clone() as Contract).ToList();
        }

        public static List<Customer> GetAllCustomer()
        {
            return DicCustomer.Select(obj => obj.Value.Clone() as Customer).ToList();
        }

        public static List<CustomerFeedback> GetAllCustomerFeedback()
        {
            return DicCustomerFeedback.Select(obj => obj.Value.Clone() as CustomerFeedback).ToList();
        }

        public static List<DetailImportReceipt> GetAllDetailImportReceipt()
        {
            return DicDetailImportReceipt.Select(obj => obj.Value.Clone() as DetailImportReceipt).ToList();
        }

        public static List<Device> GetAllDevice()
        {
            return DicDevice.Select(obj => obj.Value.Clone() as Device).ToList();
        }

        public static List<DeviceType> GetAllDeviceType()
        {
            return DicDeviceType.Select(obj => obj.Value.Clone() as DeviceType).ToList();
        }

        public static List<Employee> GetAllEmployee()
        {
            return DicEmployee.Select(obj => obj.Value.Clone() as Employee).ToList();
        }

        public static List<Fee> GetAllFee()
        {
            return DicFee.Select(obj => obj.Value.Clone() as Fee).ToList();
        }

        public static List<Image> GetAllImage()
        {
            return DicImage.Select(obj => obj.Value.Clone() as Image).ToList();
        }

        public static List<ImportReceipt> GetAllImportReceipt()
        {
            return DicImportReceipt.Select(obj => obj.Value.Clone() as ImportReceipt).ToList();
        }

        public static List<Manufacturer> GetAllManufacturer()
        {
            return DicManufacturer.Select(obj => obj.Value.Clone() as Manufacturer).ToList();
        }

        public static List<Payment> GetAllPayment()
        {
            return DicPayment.Select(obj => obj.Value.Clone() as Payment).ToList();
        }

        public static List<PaymentFee> GetAllPaymentFee()
        {
            return DicPaymentFee.Select(obj => obj.Value.Clone() as PaymentFee).ToList();
        }

        public static List<Provider> GetAllProvider()
        {
            return DicProvider.Select(obj => obj.Value.Clone() as Provider).ToList();
        }

        public static List<ServiceForm> GetAllServiceForm()
        {
            return DicServiceForm.Select(obj => obj.Value.Clone() as ServiceForm).ToList();
        }

        public static List<ServiceFormStatus> GetAllServiceFormStatus()
        {
            return DicServiceFormStatus.Select(obj => obj.Value.Clone() as ServiceFormStatus).ToList();
        }

        public static List<ServicePack> GetAllServicePack()
        {
            return DicServicePack.Select(obj => obj.Value.Clone() as ServicePack).ToList();
        }

        public static List<ServicePackFee> GetAllServicePackFee()
        {
            return DicServicePackFee.Select(obj => obj.Value.Clone() as ServicePackFee).ToList();
        }

        public static List<Store> GetAllStore()
        {
            return DicStore.Select(obj => obj.Value.Clone() as Store).ToList();
        }
    }
}