using Widgets.Domain.Aggregates;

namespace Widgets.Domain.DomainExceptions;

internal class AttemptToUpdateNotExistingEventHandler
    : Exception
{
    public AttemptToUpdateNotExistingEventHandler(EventType eventType, Provider id) : base($"Attempt to update not existing event handler. Event type: {eventType}, Entity id: {id}") { }
}
