using System;

namespace Nexus.Entity
{
    public abstract class BaseEntity : ICloneable, IDisposable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Dispose()
        {
        }

        public abstract bool IsValid();
        public abstract string GetName();
    }
}