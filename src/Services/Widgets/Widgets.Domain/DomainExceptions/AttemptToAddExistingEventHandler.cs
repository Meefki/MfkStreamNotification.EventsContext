using Widgets.Domain.Aggregates;

namespace Widgets.Domain.DomainExceptions;

internal class AttemptToAddExistingEventHandler
    : Exception
{
    public AttemptToAddExistingEventHandler(EventType eventType, Provider id) : base($"Attempt to add existing event handler. Event type: {eventType}, Entity id: {id}") { }
}
