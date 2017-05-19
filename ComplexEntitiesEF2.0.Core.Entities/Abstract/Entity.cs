using System;
using ComplexEntitiesEF2._0.Core.Entities;

namespace ComplexEntitiesEF2._0.Core.Entities.Abstract
{
    public abstract class EntityGuid : Entity<Guid>
    {

    }
    public abstract class Entity<T>
    {
        public T Id { get; set; }
        public bool IsDeleted { get; set; }
        public Metadata Metadata { get; set; } // Previosly in EFCore 1.1 Metadata wasn't recorded in database.
    }
}