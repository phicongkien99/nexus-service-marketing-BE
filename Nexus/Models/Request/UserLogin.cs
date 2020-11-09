using System;

namespace Nexus.Models.Request
{
    public class UserLogin : IDisposable
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public void Dispose()
        {
        }
        public static string EntityName()
        {
            return typeof(UserLogin).Name;
        }

        public static string GetName()
        {
            return EntityName();
        }

    }
}