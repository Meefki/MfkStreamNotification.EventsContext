using Widgets.Domain.SeedWork.Mediator;

namespace Widgets.Domain.SeedWork;

public interface IEntity
{
    public IReadOnlyCollection<IDomainEvent> DomainEvents { get; }
    public void ClearDomainEvents();
}
