using System;

namespace DomainSample.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public byte[] RowVersion { get; set; }
    }
}