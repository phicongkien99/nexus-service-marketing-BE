using System;
using Nexus.Common.Enum;

namespace Nexus.Entity
{
    public class EntityCommand : IDisposable, ICloneable
    {
        public Entity BaseEntity { get; set; }
        public EntityAction EntityAction { get; set; }
        public void Dispose()
        {

        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}