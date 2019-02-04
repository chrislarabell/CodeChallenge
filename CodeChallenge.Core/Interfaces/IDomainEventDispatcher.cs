using CodeChallenge.Core.SharedKernel;

namespace CodeChallenge.Core.Interfaces
{
    public interface IDomainEventDispatcher
    {
        void Dispatch(BaseDomainEvent domainEvent);
    }
}
