using System;

namespace Nexus.Models.Request
{
    public class ChangePasswordReq : IDisposable
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }

        public void Dispose()
        {
        }
        public static string EntityName()
        {
            return typeof(ChangePasswordReq).Name;
        }

        public static string GetName()
        {
            return EntityName();
        }

    }
}