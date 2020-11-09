using System;
using System.Data.SqlClient;
using BaseUtils;
using Nexus.Common.Config;
using Nexus.DatabaseDAL.EntitySql;
using Nexus.Entity.Entities;

namespace Nexus.DatabaseDAL.Common
{
    public class EntityManager
    {
        private readonly DatabaseConfig _databaseConfig;
        private readonly string _connectionString;
        private readonly bool _isUseMySql;
        #region Instance

        public static EntityManager Instance
        {
            get { return Nested.Instance; }
        }

        private class Nested
        {
            internal static readonly EntityManager Instance = new EntityManager();
        }

        #endregion

        public EntityManager()
        {
            var configLoader = new ConfigLoader(typeof(DatabaseConfig));
            _databaseConfig = configLoader.Config as DatabaseConfig;

            if (_databaseConfig == null)
                throw new Exception("Not found config database");
            Console.WriteLine("------------------------------------");
            _connectionString = _databaseConfig.ConnectionString;
            Console.WriteLine(_connectionString);
            
        }

        public EntityBaseSql GetMyEntity(string entityName)
        {

            #region GetMyEntity
            if (entityName.Equals(Area.EntityName())) { return new AreaSql(); }
            if (entityName.Equals(Connection.EntityName())) { return new ConnectionSql(); }
            if (entityName.Equals(ConnectionStatus.EntityName())) { return new ConnectionStatusSql(); }
            if (entityName.Equals(ConnectionType.EntityName())) { return new ConnectionTypeSql(); }
            if (entityName.Equals(Contract.EntityName())) { return new ContractSql(); }
            if (entityName.Equals(ContractStatus.EntityName())) { return new ContractStatusSql(); }
            if (entityName.Equals(Customer.EntityName())) { return new CustomerSql(); }
            if (entityName.Equals(CustomerFeedback.EntityName())) { return new CustomerFeedbackSql(); }
            if (entityName.Equals(DetailImportReceipt.EntityName())) { return new DetailImportReceiptSql(); }
            if (entityName.Equals(Device.EntityName())) { return new DeviceSql(); }
            if (entityName.Equals(DeviceType.EntityName())) { return new DeviceTypeSql(); }
            if (entityName.Equals(Employee.EntityName())) { return new EmployeeSql(); }
            if (entityName.Equals(Fee.EntityName())) { return new FeeSql(); }
            if (entityName.Equals(Image.EntityName())) { return new ImageSql(); }
            if (entityName.Equals(ImportReceipt.EntityName())) { return new ImportReceiptSql(); }
            if (entityName.Equals(Manufacturer.EntityName())) { return new ManufacturerSql(); }
            if (entityName.Equals(Payment.EntityName())) { return new PaymentSql(); }
            if (entityName.Equals(PaymentFee.EntityName())) { return new PaymentFeeSql(); }
            if (entityName.Equals(Provider.EntityName())) { return new ProviderSql(); }
            if (entityName.Equals(ServiceForm.EntityName())) { return new ServiceFormSql(); }
            if (entityName.Equals(ServiceFormStatus.EntityName())) { return new ServiceFormStatusSql(); }
            if (entityName.Equals(ServicePack.EntityName())) { return new ServicePackSql(); }
            if (entityName.Equals(ServicePackFee.EntityName())) { return new ServicePackFeeSql(); }
            if (entityName.Equals(Store.EntityName())) { return new StoreSql(); }

            #endregion

            Console.WriteLine(entityName);

            return null;
        }

        public SqlConnection GetConnection(string entityName)
        {
            return GetConnection();
        }

        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection { ConnectionString = _connectionString };
            // Get connection string from Config File and set to the connection
            connection.Open();
            return connection;
        }

        

        public string GetNameDataWorking()
        {
            var stringName = _connectionString;

            var connection = new SqlConnection { ConnectionString = stringName };
            return connection.Database;
        }
    }
}
