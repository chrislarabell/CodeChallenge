namespace CodeChallenge.Core.SharedKernel
{
    using CodeChallenge.Core.Interfaces;
    using System.Collections.Generic;
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}
