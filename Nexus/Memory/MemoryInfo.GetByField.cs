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
#region Area
public static List<Area> GetListAreaByField(string fieldValue, Area.AreaFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<Area>();
if (fieldName == Area.AreaFields.CreatedBy)
{
listValue = DicArea.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Area.AreaFields.Id)
{
listValue = DicArea.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Area.AreaFields.IsDeleted)
{
listValue = DicArea.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Area.AreaFields.Name)
{
listValue = DicArea.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Name.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Area.AreaFields.ShortName)
{
listValue = DicArea.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.ShortName.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Area.AreaFields.UpdatedBy)
{
listValue = DicArea.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as Area).ToList();
}
#endregion

#region Connection
public static List<Connection> GetListConnectionByField(string fieldValue, Connection.ConnectionFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<Connection>();
if (fieldName == Connection.ConnectionFields.CreatedBy)
{
listValue = DicConnection.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Connection.ConnectionFields.Id)
{
listValue = DicConnection.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Connection.ConnectionFields.IdConnectionStatus)
{
listValue = DicConnection.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdConnectionStatus.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Connection.ConnectionFields.IdContract)
{
listValue = DicConnection.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdContract.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Connection.ConnectionFields.IdDevice)
{
listValue = DicConnection.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdDevice.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Connection.ConnectionFields.IdServicePack)
{
listValue = DicConnection.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdServicePack.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Connection.ConnectionFields.IsDeleted)
{
listValue = DicConnection.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Connection.ConnectionFields.UpdatedBy)
{
listValue = DicConnection.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as Connection).ToList();
}
#endregion

#region ConnectionStatus
public static List<ConnectionStatus> GetListConnectionStatusByField(string fieldValue, ConnectionStatus.ConnectionStatusFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<ConnectionStatus>();
if (fieldName == ConnectionStatus.ConnectionStatusFields.CreatedBy)
{
listValue = DicConnectionStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ConnectionStatus.ConnectionStatusFields.Description)
{
listValue = DicConnectionStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Description.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ConnectionStatus.ConnectionStatusFields.Id)
{
listValue = DicConnectionStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ConnectionStatus.ConnectionStatusFields.IsDeleted)
{
listValue = DicConnectionStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ConnectionStatus.ConnectionStatusFields.Name)
{
listValue = DicConnectionStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Name.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ConnectionStatus.ConnectionStatusFields.UpdatedBy)
{
listValue = DicConnectionStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as ConnectionStatus).ToList();
}
#endregion

#region ConnectionType
public static List<ConnectionType> GetListConnectionTypeByField(string fieldValue, ConnectionType.ConnectionTypeFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<ConnectionType>();
if (fieldName == ConnectionType.ConnectionTypeFields.CreatedBy)
{
listValue = DicConnectionType.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ConnectionType.ConnectionTypeFields.Description)
{
listValue = DicConnectionType.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Description.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ConnectionType.ConnectionTypeFields.Id)
{
listValue = DicConnectionType.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ConnectionType.ConnectionTypeFields.IsDeleted)
{
listValue = DicConnectionType.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ConnectionType.ConnectionTypeFields.Name)
{
listValue = DicConnectionType.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Name.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ConnectionType.ConnectionTypeFields.UpdatedBy)
{
listValue = DicConnectionType.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as ConnectionType).ToList();
}
#endregion

#region Contract
public static List<Contract> GetListContractByField(string fieldValue, Contract.ContractFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<Contract>();
if (fieldName == Contract.ContractFields.Address)
{
listValue = DicContract.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Address.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Contract.ContractFields.ContractId)
{
listValue = DicContract.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.ContractId.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Contract.ContractFields.CreatedBy)
{
listValue = DicContract.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Contract.ContractFields.Id)
{
listValue = DicContract.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Contract.ContractFields.IdArea)
{
listValue = DicContract.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdArea.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Contract.ContractFields.IdCustomer)
{
listValue = DicContract.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdCustomer.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Contract.ContractFields.IsDeleted)
{
listValue = DicContract.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Contract.ContractFields.UpdatedBy)
{
listValue = DicContract.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as Contract).ToList();
}
#endregion

#region ContractStatus
public static List<ContractStatus> GetListContractStatusByField(string fieldValue, ContractStatus.ContractStatusFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<ContractStatus>();
if (fieldName == ContractStatus.ContractStatusFields.CreatedBy)
{
listValue = DicContractStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ContractStatus.ContractStatusFields.Description)
{
listValue = DicContractStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Description.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ContractStatus.ContractStatusFields.Id)
{
listValue = DicContractStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ContractStatus.ContractStatusFields.IsDeleted)
{
listValue = DicContractStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ContractStatus.ContractStatusFields.Name)
{
listValue = DicContractStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Name.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ContractStatus.ContractStatusFields.UpdatedBy)
{
listValue = DicContractStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as ContractStatus).ToList();
}
#endregion

#region Customer
public static List<Customer> GetListCustomerByField(string fieldValue, Customer.CustomerFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<Customer>();
if (fieldName == Customer.CustomerFields.Address)
{
listValue = DicCustomer.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Address.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Customer.CustomerFields.CreatedBy)
{
listValue = DicCustomer.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Customer.CustomerFields.Email)
{
listValue = DicCustomer.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Email.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Customer.CustomerFields.Id)
{
listValue = DicCustomer.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Customer.CustomerFields.IsDeleted)
{
listValue = DicCustomer.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Customer.CustomerFields.Name)
{
listValue = DicCustomer.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Name.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Customer.CustomerFields.Phone)
{
listValue = DicCustomer.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Phone.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Customer.CustomerFields.UpdatedBy)
{
listValue = DicCustomer.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as Customer).ToList();
}
#endregion

#region CustomerFeedback
public static List<CustomerFeedback> GetListCustomerFeedbackByField(string fieldValue, CustomerFeedback.CustomerFeedbackFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<CustomerFeedback>();
if (fieldName == CustomerFeedback.CustomerFeedbackFields.Content)
{
listValue = DicCustomerFeedback.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Content.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == CustomerFeedback.CustomerFeedbackFields.CreatedBy)
{
listValue = DicCustomerFeedback.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == CustomerFeedback.CustomerFeedbackFields.Id)
{
listValue = DicCustomerFeedback.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == CustomerFeedback.CustomerFeedbackFields.IdCustomer)
{
listValue = DicCustomerFeedback.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdCustomer.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == CustomerFeedback.CustomerFeedbackFields.IsDeleted)
{
listValue = DicCustomerFeedback.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == CustomerFeedback.CustomerFeedbackFields.Rating)
{
listValue = DicCustomerFeedback.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Rating.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == CustomerFeedback.CustomerFeedbackFields.UpdatedBy)
{
listValue = DicCustomerFeedback.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as CustomerFeedback).ToList();
}
#endregion

#region DetailImportReceipt
public static List<DetailImportReceipt> GetListDetailImportReceiptByField(string fieldValue, DetailImportReceipt.DetailImportReceiptFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<DetailImportReceipt>();
if (fieldName == DetailImportReceipt.DetailImportReceiptFields.CreatedBy)
{
listValue = DicDetailImportReceipt.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == DetailImportReceipt.DetailImportReceiptFields.IsDeleted)
{
listValue = DicDetailImportReceipt.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == DetailImportReceipt.DetailImportReceiptFields.Price)
{
listValue = DicDetailImportReceipt.Values.ToList().FindAll(obj => obj.Price.HasValue &&
fieldValue.Equals(obj.Price.Value.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == DetailImportReceipt.DetailImportReceiptFields.Quantity)
{
listValue = DicDetailImportReceipt.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Quantity.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == DetailImportReceipt.DetailImportReceiptFields.UpdatedBy)
{
listValue = DicDetailImportReceipt.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as DetailImportReceipt).ToList();
}
#endregion

#region Device
public static List<Device> GetListDeviceByField(string fieldValue, Device.DeviceFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<Device>();
if (fieldName == Device.DeviceFields.CreatedBy)
{
listValue = DicDevice.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Device.DeviceFields.Id)
{
listValue = DicDevice.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Device.DeviceFields.IdDeviceType)
{
listValue = DicDevice.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdDeviceType.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Device.DeviceFields.IdManufacturer)
{
listValue = DicDevice.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdManufacturer.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Device.DeviceFields.IsDeleted)
{
listValue = DicDevice.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Device.DeviceFields.Name)
{
listValue = DicDevice.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Name.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Device.DeviceFields.Stock)
{
listValue = DicDevice.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Stock.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Device.DeviceFields.UpdatedBy)
{
listValue = DicDevice.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Device.DeviceFields.Using)
{
listValue = DicDevice.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Using.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as Device).ToList();
}
#endregion

#region DeviceType
public static List<DeviceType> GetListDeviceTypeByField(string fieldValue, DeviceType.DeviceTypeFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<DeviceType>();
if (fieldName == DeviceType.DeviceTypeFields.CreatedBy)
{
listValue = DicDeviceType.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == DeviceType.DeviceTypeFields.Description)
{
listValue = DicDeviceType.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Description.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == DeviceType.DeviceTypeFields.Id)
{
listValue = DicDeviceType.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == DeviceType.DeviceTypeFields.IsDeleted)
{
listValue = DicDeviceType.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == DeviceType.DeviceTypeFields.Name)
{
listValue = DicDeviceType.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Name.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == DeviceType.DeviceTypeFields.UpdatedBy)
{
listValue = DicDeviceType.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as DeviceType).ToList();
}
#endregion

#region Employee
public static List<Employee> GetListEmployeeByField(string fieldValue, Employee.EmployeeFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<Employee>();
if (fieldName == Employee.EmployeeFields.Address)
{
listValue = DicEmployee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Address.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Employee.EmployeeFields.CreatedBy)
{
listValue = DicEmployee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Employee.EmployeeFields.Email)
{
listValue = DicEmployee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Email.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Employee.EmployeeFields.Id)
{
listValue = DicEmployee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Employee.EmployeeFields.IdStore)
{
listValue = DicEmployee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdStore.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Employee.EmployeeFields.IsActivated)
{
listValue = DicEmployee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsActivated.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Employee.EmployeeFields.IsDeleted)
{
listValue = DicEmployee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Employee.EmployeeFields.Name)
{
listValue = DicEmployee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Name.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Employee.EmployeeFields.Password)
{
listValue = DicEmployee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Password.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Employee.EmployeeFields.Phone)
{
listValue = DicEmployee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Phone.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Employee.EmployeeFields.Role)
{
listValue = DicEmployee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Role.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Employee.EmployeeFields.UpdatedBy)
{
listValue = DicEmployee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as Employee).ToList();
}
#endregion

#region Fee
public static List<Fee> GetListFeeByField(string fieldValue, Fee.FeeFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<Fee>();
if (fieldName == Fee.FeeFields.CreatedBy)
{
listValue = DicFee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Fee.FeeFields.Description)
{
listValue = DicFee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Description.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Fee.FeeFields.Id)
{
listValue = DicFee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Fee.FeeFields.IsDeleted)
{
listValue = DicFee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Fee.FeeFields.Name)
{
listValue = DicFee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Name.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Fee.FeeFields.UpdatedBy)
{
listValue = DicFee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as Fee).ToList();
}
#endregion

#region Image
public static List<Image> GetListImageByField(string fieldValue, Image.ImageFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<Image>();
if (fieldName == Image.ImageFields.CreatedBy)
{
listValue = DicImage.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Image.ImageFields.Id)
{
listValue = DicImage.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Image.ImageFields.IdCustomer)
{
listValue = DicImage.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdCustomer.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Image.ImageFields.IsDeleted)
{
listValue = DicImage.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Image.ImageFields.UpdatedBy)
{
listValue = DicImage.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Image.ImageFields.Url)
{
listValue = DicImage.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Url.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as Image).ToList();
}
#endregion

#region ImportReceipt
public static List<ImportReceipt> GetListImportReceiptByField(string fieldValue, ImportReceipt.ImportReceiptFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<ImportReceipt>();
if (fieldName == ImportReceipt.ImportReceiptFields.CreatedBy)
{
listValue = DicImportReceipt.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ImportReceipt.ImportReceiptFields.Id)
{
listValue = DicImportReceipt.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ImportReceipt.ImportReceiptFields.IdProvider)
{
listValue = DicImportReceipt.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdProvider.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ImportReceipt.ImportReceiptFields.IsDeleted)
{
listValue = DicImportReceipt.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ImportReceipt.ImportReceiptFields.TotalPrice)
{
listValue = DicImportReceipt.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.TotalPrice.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ImportReceipt.ImportReceiptFields.UpdatedBy)
{
listValue = DicImportReceipt.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as ImportReceipt).ToList();
}
#endregion

#region Manufacturer
public static List<Manufacturer> GetListManufacturerByField(string fieldValue, Manufacturer.ManufacturerFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<Manufacturer>();
if (fieldName == Manufacturer.ManufacturerFields.CreatedBy)
{
listValue = DicManufacturer.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Manufacturer.ManufacturerFields.Id)
{
listValue = DicManufacturer.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Manufacturer.ManufacturerFields.IsDeleted)
{
listValue = DicManufacturer.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Manufacturer.ManufacturerFields.Logo)
{
listValue = DicManufacturer.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Logo.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Manufacturer.ManufacturerFields.Name)
{
listValue = DicManufacturer.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Name.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Manufacturer.ManufacturerFields.UpdatedBy)
{
listValue = DicManufacturer.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as Manufacturer).ToList();
}
#endregion

#region Payment
public static List<Payment> GetListPaymentByField(string fieldValue, Payment.PaymentFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<Payment>();
if (fieldName == Payment.PaymentFields.CreatedBy)
{
listValue = DicPayment.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Payment.PaymentFields.Id)
{
listValue = DicPayment.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Payment.PaymentFields.IdContract)
{
listValue = DicPayment.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdContract.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Payment.PaymentFields.IsDeleted)
{
listValue = DicPayment.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Payment.PaymentFields.TotalPrice)
{
listValue = DicPayment.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.TotalPrice.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Payment.PaymentFields.UpdatedBy)
{
listValue = DicPayment.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as Payment).ToList();
}
#endregion

#region PaymentFee
public static List<PaymentFee> GetListPaymentFeeByField(string fieldValue, PaymentFee.PaymentFeeFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<PaymentFee>();
if (fieldName == PaymentFee.PaymentFeeFields.CreatedBy)
{
listValue = DicPaymentFee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == PaymentFee.PaymentFeeFields.IsDeleted)
{
listValue = DicPaymentFee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == PaymentFee.PaymentFeeFields.UpdatedBy)
{
listValue = DicPaymentFee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == PaymentFee.PaymentFeeFields.Value)
{
listValue = DicPaymentFee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Value.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as PaymentFee).ToList();
}
#endregion

#region Provider
public static List<Provider> GetListProviderByField(string fieldValue, Provider.ProviderFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<Provider>();
if (fieldName == Provider.ProviderFields.Address)
{
listValue = DicProvider.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Address.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Provider.ProviderFields.CreatedBy)
{
listValue = DicProvider.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Provider.ProviderFields.Email)
{
listValue = DicProvider.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Email.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Provider.ProviderFields.Id)
{
listValue = DicProvider.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Provider.ProviderFields.IsDeleted)
{
listValue = DicProvider.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Provider.ProviderFields.Name)
{
listValue = DicProvider.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Name.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Provider.ProviderFields.Phone)
{
listValue = DicProvider.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Phone.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Provider.ProviderFields.UpdatedBy)
{
listValue = DicProvider.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as Provider).ToList();
}
#endregion

#region ServiceForm
public static List<ServiceForm> GetListServiceFormByField(string fieldValue, ServiceForm.ServiceFormFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<ServiceForm>();
if (fieldName == ServiceForm.ServiceFormFields.Address)
{
listValue = DicServiceForm.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Address.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceForm.ServiceFormFields.CreatedBy)
{
listValue = DicServiceForm.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceForm.ServiceFormFields.Id)
{
listValue = DicServiceForm.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceForm.ServiceFormFields.IdArea)
{
listValue = DicServiceForm.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdArea.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceForm.ServiceFormFields.IdCustomer)
{
listValue = DicServiceForm.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdCustomer.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceForm.ServiceFormFields.IdEmployee)
{
listValue = DicServiceForm.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdEmployee.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceForm.ServiceFormFields.IdServiceFormStatus)
{
listValue = DicServiceForm.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdServiceFormStatus.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceForm.ServiceFormFields.IdServicePack)
{
listValue = DicServiceForm.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdServicePack.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceForm.ServiceFormFields.IsDeleted)
{
listValue = DicServiceForm.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceForm.ServiceFormFields.ServiceFormId)
{
listValue = DicServiceForm.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.ServiceFormId.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceForm.ServiceFormFields.UpdatedBy)
{
listValue = DicServiceForm.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as ServiceForm).ToList();
}
#endregion

#region ServiceFormStatus
public static List<ServiceFormStatus> GetListServiceFormStatusByField(string fieldValue, ServiceFormStatus.ServiceFormStatusFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<ServiceFormStatus>();
if (fieldName == ServiceFormStatus.ServiceFormStatusFields.CreatedBy)
{
listValue = DicServiceFormStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceFormStatus.ServiceFormStatusFields.Description)
{
listValue = DicServiceFormStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Description.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceFormStatus.ServiceFormStatusFields.Id)
{
listValue = DicServiceFormStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceFormStatus.ServiceFormStatusFields.IsDeleted)
{
listValue = DicServiceFormStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceFormStatus.ServiceFormStatusFields.Name)
{
listValue = DicServiceFormStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Name.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServiceFormStatus.ServiceFormStatusFields.UpdatedBy)
{
listValue = DicServiceFormStatus.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as ServiceFormStatus).ToList();
}
#endregion

#region ServicePack
public static List<ServicePack> GetListServicePackByField(string fieldValue, ServicePack.ServicePackFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<ServicePack>();
if (fieldName == ServicePack.ServicePackFields.CreatedBy)
{
listValue = DicServicePack.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServicePack.ServicePackFields.Description)
{
listValue = DicServicePack.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Description.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServicePack.ServicePackFields.Id)
{
listValue = DicServicePack.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServicePack.ServicePackFields.IdConnectionType)
{
listValue = DicServicePack.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdConnectionType.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServicePack.ServicePackFields.IsDeleted)
{
listValue = DicServicePack.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServicePack.ServicePackFields.Name)
{
listValue = DicServicePack.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Name.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServicePack.ServicePackFields.UpdatedBy)
{
listValue = DicServicePack.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as ServicePack).ToList();
}
#endregion

#region ServicePackFee
public static List<ServicePackFee> GetListServicePackFeeByField(string fieldValue, ServicePackFee.ServicePackFeeFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<ServicePackFee>();
if (fieldName == ServicePackFee.ServicePackFeeFields.CreatedBy)
{
listValue = DicServicePackFee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServicePackFee.ServicePackFeeFields.IsDeleted)
{
listValue = DicServicePackFee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServicePackFee.ServicePackFeeFields.UpdatedBy)
{
listValue = DicServicePackFee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == ServicePackFee.ServicePackFeeFields.Value)
{
listValue = DicServicePackFee.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Value.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as ServicePackFee).ToList();
}
#endregion

#region Store
public static List<Store> GetListStoreByField(string fieldValue, Store.StoreFields fieldName)
{
if (string.IsNullOrEmpty(fieldValue)) fieldValue = "";
var listValue = new List<Store>();
if (fieldName == Store.StoreFields.Address)
{
listValue = DicStore.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Address.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Store.StoreFields.CreatedBy)
{
listValue = DicStore.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.CreatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Store.StoreFields.Id)
{
listValue = DicStore.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Id.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Store.StoreFields.IdArea)
{
listValue = DicStore.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IdArea.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Store.StoreFields.IsClosed)
{
listValue = DicStore.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsClosed.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Store.StoreFields.IsDeleted)
{
listValue = DicStore.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.IsDeleted.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Store.StoreFields.Name)
{
listValue = DicStore.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.Name.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
else if (fieldName == Store.StoreFields.UpdatedBy)
{
listValue = DicStore.Values.ToList().FindAll(obj =>
fieldValue.Equals(obj.UpdatedBy.ToString(), StringComparison.InvariantCultureIgnoreCase));
}
return listValue.Select(value => value.Clone() as Store).ToList();
}
#endregion

}
}


