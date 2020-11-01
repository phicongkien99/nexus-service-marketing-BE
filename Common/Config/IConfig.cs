using System;

namespace Nexus.Common.Config
{
    public interface IConfig : IDisposable
    {
        string GetFileName();
    }
}
