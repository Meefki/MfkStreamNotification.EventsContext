using System.Linq;

namespace Widgets.Domain.DomainExceptions;

internal class AttemptToCreateEmptyViewPortException
    : Exception
{
    public AttemptToCreateEmptyViewPortException() : base($"Attempt to create an empty viewport") { }
}
