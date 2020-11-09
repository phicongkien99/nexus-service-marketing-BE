using System;
using System.Collections.Generic;
using Nexus.Entity.Entities;

namespace Nexus.Models.Response
{
    public class TokenResponse : IDisposable
    {
        public TokenResponse(string token, Employee userInfo)
        {
            Token = token;
            UserInfo = userInfo;
            ListPermission = new List<string>();
        }
        public string Token { get; set; }
        public Employee UserInfo { get; set; }
        public List<string> ListPermission { get; set; }

        public void Dispose()
        {
            ListPermission = null;
        }
    }
}