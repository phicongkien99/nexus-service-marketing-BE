using Nexus.Entity.Entities;
                                        using Nexus.Entity.Keys;
                                        
namespace Nexus.Memory
{
public partial class MemorySet : Memory
{
internal static void SetMemory(Area objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicArea[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(Area objectValue)
{
if (DicArea.ContainsKey(objectValue.Id))
DicArea.Remove(objectValue.Id);
}

internal static void SetMemory(Connection objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicConnection[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(Connection objectValue)
{
if (DicConnection.ContainsKey(objectValue.Id))
DicConnection.Remove(objectValue.Id);
}

internal static void SetMemory(ConnectionStatus objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicConnectionStatus[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(ConnectionStatus objectValue)
{
if (DicConnectionStatus.ContainsKey(objectValue.Id))
DicConnectionStatus.Remove(objectValue.Id);
}

internal static void SetMemory(ConnectionType objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicConnectionType[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(ConnectionType objectValue)
{
if (DicConnectionType.ContainsKey(objectValue.Id))
DicConnectionType.Remove(objectValue.Id);
}

internal static void SetMemory(Contract objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicContract[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(Contract objectValue)
{
if (DicContract.ContainsKey(objectValue.Id))
DicContract.Remove(objectValue.Id);
}

internal static void SetMemory(ContractStatus objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicContractStatus[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(ContractStatus objectValue)
{
if (DicContractStatus.ContainsKey(objectValue.Id))
DicContractStatus.Remove(objectValue.Id);
}

internal static void SetMemory(Customer objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicCustomer[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(Customer objectValue)
{
if (DicCustomer.ContainsKey(objectValue.Id))
DicCustomer.Remove(objectValue.Id);
}

internal static void SetMemory(CustomerFeedback objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicCustomerFeedback[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(CustomerFeedback objectValue)
{
if (DicCustomerFeedback.ContainsKey(objectValue.Id))
DicCustomerFeedback.Remove(objectValue.Id);
}

internal static void SetMemory(DetailImportReceipt objectValue)
{
var key = new DetailImportReceiptKeys
{
IdDevice = objectValue.IdDevice,
IdImportReceipt = objectValue.IdImportReceipt
};
DicDetailImportReceipt[key] = objectValue;
}
internal static void RemoveMemory(DetailImportReceipt objectValue)
{
var key = new DetailImportReceiptKeys
{
IdDevice = objectValue.IdDevice,
IdImportReceipt = objectValue.IdImportReceipt
};
if (DicDetailImportReceipt.ContainsKey(key))
DicDetailImportReceipt.Remove(key);
}

internal static void SetMemory(Device objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicDevice[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(Device objectValue)
{
if (DicDevice.ContainsKey(objectValue.Id))
DicDevice.Remove(objectValue.Id);
}

internal static void SetMemory(DeviceType objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicDeviceType[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(DeviceType objectValue)
{
if (DicDeviceType.ContainsKey(objectValue.Id))
DicDeviceType.Remove(objectValue.Id);
}

internal static void SetMemory(Employee objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicEmployee[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(Employee objectValue)
{
if (DicEmployee.ContainsKey(objectValue.Id))
DicEmployee.Remove(objectValue.Id);
}

internal static void SetMemory(Fee objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicFee[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(Fee objectValue)
{
if (DicFee.ContainsKey(objectValue.Id))
DicFee.Remove(objectValue.Id);
}

internal static void SetMemory(Image objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicImage[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(Image objectValue)
{
if (DicImage.ContainsKey(objectValue.Id))
DicImage.Remove(objectValue.Id);
}

internal static void SetMemory(ImportReceipt objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicImportReceipt[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(ImportReceipt objectValue)
{
if (DicImportReceipt.ContainsKey(objectValue.Id))
DicImportReceipt.Remove(objectValue.Id);
}

internal static void SetMemory(Manufacturer objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicManufacturer[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(Manufacturer objectValue)
{
if (DicManufacturer.ContainsKey(objectValue.Id))
DicManufacturer.Remove(objectValue.Id);
}

internal static void SetMemory(Payment objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicPayment[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(Payment objectValue)
{
if (DicPayment.ContainsKey(objectValue.Id))
DicPayment.Remove(objectValue.Id);
}

internal static void SetMemory(PaymentFee objectValue)
{
var key = new PaymentFeeKeys
{
IdFee = objectValue.IdFee,
IdPayment = objectValue.IdPayment
};
DicPaymentFee[key] = objectValue;
}
internal static void RemoveMemory(PaymentFee objectValue)
{
var key = new PaymentFeeKeys
{
IdFee = objectValue.IdFee,
IdPayment = objectValue.IdPayment
};
if (DicPaymentFee.ContainsKey(key))
DicPaymentFee.Remove(key);
}

internal static void SetMemory(Provider objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicProvider[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(Provider objectValue)
{
if (DicProvider.ContainsKey(objectValue.Id))
DicProvider.Remove(objectValue.Id);
}

internal static void SetMemory(ServiceForm objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicServiceForm[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(ServiceForm objectValue)
{
if (DicServiceForm.ContainsKey(objectValue.Id))
DicServiceForm.Remove(objectValue.Id);
}

internal static void SetMemory(ServiceFormStatus objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicServiceFormStatus[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(ServiceFormStatus objectValue)
{
if (DicServiceFormStatus.ContainsKey(objectValue.Id))
DicServiceFormStatus.Remove(objectValue.Id);
}

internal static void SetMemory(ServicePack objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicServicePack[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(ServicePack objectValue)
{
if (DicServicePack.ContainsKey(objectValue.Id))
DicServicePack.Remove(objectValue.Id);
}

internal static void SetMemory(ServicePackFee objectValue)
{
var key = new ServicePackFeeKeys
{
IdFee = objectValue.IdFee,
IdServicePack = objectValue.IdServicePack
};
DicServicePackFee[key] = objectValue;
}
internal static void RemoveMemory(ServicePackFee objectValue)
{
var key = new ServicePackFeeKeys
{
IdFee = objectValue.IdFee,
IdServicePack = objectValue.IdServicePack
};
if (DicServicePackFee.ContainsKey(key))
DicServicePackFee.Remove(key);
}

internal static void SetMemory(Store objectValue)
{
string entityName = objectValue.GetName();
// chua co thi khoi tao
if (!DicMaxKeyEntity.ContainsKey(entityName))
DicMaxKeyEntity[entityName] = 0;
// co roi thi so sanh roi set max key vao dic
if (DicMaxKeyEntity[entityName] < objectValue.Id)
{
DicMaxKeyEntity[entityName] = objectValue.Id;
}
DicStore[objectValue.Id] = objectValue;
}
internal static void RemoveMemory(Store objectValue)
{
if (DicStore.ContainsKey(objectValue.Id))
DicStore.Remove(objectValue.Id);
}

}
}


