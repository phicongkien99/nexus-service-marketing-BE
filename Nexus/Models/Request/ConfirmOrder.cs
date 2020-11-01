using System;

namespace Nexus.Models.Request
{
    public class ConfirmOrder : IDisposable
    {
        public int OrderId { get; set; }

        public void Dispose()
        {
        }
        public static string EntityName()
        {
            return typeof(ConfirmOrder).Name;
        }

        public static string GetName()
        {
            return EntityName();
        }

    }
}