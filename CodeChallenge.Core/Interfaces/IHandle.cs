using CodeChallenge.Core.SharedKernel;

namespace CodeChallenge.Core.Interfaces
{
    public interface IHandle<T> where T : BaseDomainEvent
    {
        void Handle(T domainEvent);
    }
}
