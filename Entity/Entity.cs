using Nexus.Entity.Entities;

namespace Nexus.Entity
{
    public class Entity
    {
        public string EntityName { get; set; }

        public Entity()
        {
        }

        public Entity(BaseEntity entity)
        {
            SetEntity(entity);
        }

        public BaseEntity GetEntity()
        {
            if (string.IsNullOrWhiteSpace(EntityName)) return null;
            var prop = this.GetType().GetProperty(EntityName);
            if (prop == null) return null;
            return prop.GetValue(this, null) as BaseEntity;
        }

        public void SetEntity(BaseEntity entity)
        {
            var typeName = entity.GetType().Name;
            var myPropInfo = GetType().GetProperty(typeName);
            if (myPropInfo != null)
            {
                myPropInfo.SetValue(this, entity, null);
                EntityName = typeName;
            }
        }

        public string GetName()
        {
            return EntityName;
        }

        #region MyObject

        #endregion


        #region MyView

        #endregion


        #region MyEntity

        public Area Area { get; set; }
        public Connection Connection { get; set; }
        public ConnectionStatus ConnectionStatus { get; set; }
        public ConnectionType ConnectionType { get; set; }
        public Contract Contract { get; set; }
        public ContractStatus ContractStatus { get; set; }
        public Customer Customer { get; set; }
        public CustomerFeedback CustomerFeedback { get; set; }
        public DetailImportReceipt DetailImportReceipt { get; set; }
        public Device Device { get; set; }
        public DeviceType DeviceType { get; set; }
        public Employee Employee { get; set; }
        public Fee Fee { get; set; }
        public Image Image { get; set; }
        public ImportReceipt ImportReceipt { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Payment Payment { get; set; }
        public PaymentFee PaymentFee { get; set; }
        public Provider Provider { get; set; }
        public ServiceForm ServiceForm { get; set; }
        public ServiceFormStatus ServiceFormStatus { get; set; }
        public ServicePack ServicePack { get; set; }
        public ServicePackFee ServicePackFee { get; set; }
        public Store Store { get; set; }


        #endregion
    }
}