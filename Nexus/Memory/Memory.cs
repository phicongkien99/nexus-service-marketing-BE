﻿using System;
using System.Collections.Generic;
using Nexus.Entity.Entities;
using Nexus.Entity.Keys;

namespace Nexus.Memory
{
    public class Memory
    {
        #region DicRole
        public static Dictionary<int,List<Permission>> DicUserPermission = new Dictionary<int, List<Permission>>();
        public static Dictionary<int,List<Permission>> DicRoleMapping = new Dictionary<int, List<Permission>>(); // key la id role, value la list permission
        

        #endregion


        #region Dang ki memory
        public static List<string> GetListEntityNameInit()
        {
            return new List<string>
            {
                Customer.EntityName(),
                Image.EntityName(),
                ImportReceipt.EntityName(),
                Manufacturer.EntityName(),
                OrderDetail.EntityName(),
                Permission.EntityName(),
                Post.EntityName(),
                Product.EntityName(),
                ProductType.EntityName(),
                Property.EntityName(),
                Provider.EntityName(),
                Role.EntityName(),
                RolePermission.EntityName(),
                UserInfo.EntityName(),
                UserLogin.EntityName(),
                UserRole.EntityName()
            };
        }
        #endregion

        public static Dictionary<string, int> DicMaxKeyEntity = new Dictionary<string, int>();
        public static Dictionary<int, Customer> DicCustomer = new Dictionary<int, Customer>();

        public static Dictionary<int, Image> DicImage = new Dictionary<int, Image>();
        public static Dictionary<int, Post> DicPost = new Dictionary<int, Post>();

        public static Dictionary<int, ImportReceipt> DicImportReceipt = new Dictionary<int, ImportReceipt>();

        public static Dictionary<int, Manufacturer> DicManufacturer = new Dictionary<int, Manufacturer>();

        public static Dictionary<int, OrderDetail> DicOrderDetail = new Dictionary<int, OrderDetail>();

        public static Dictionary<int, Permission> DicPermission = new Dictionary<int, Permission>();

        public static Dictionary<int, Product> DicProduct = new Dictionary<int, Product>();

        public static Dictionary<int, ProductType> DicProductType = new Dictionary<int, ProductType>();

        public static Dictionary<int, Property> DicProperty = new Dictionary<int, Property>();

        public static Dictionary<int, Provider> DicProvider = new Dictionary<int, Provider>();

        public static Dictionary<int, Role> DicRole = new Dictionary<int, Role>();

        public static Dictionary<RolePermissionKeys, RolePermission> DicRolePermission = new Dictionary<RolePermissionKeys, RolePermission>();

        public static Dictionary<int, UserInfo> DicUserInfo = new Dictionary<int, UserInfo>();

        public static Dictionary<int, UserLogin> DicUserLogin = new Dictionary<int, UserLogin>();

        public static Dictionary<UserRoleKeys, UserRole> DicUserRole = new Dictionary<UserRoleKeys, UserRole>();


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