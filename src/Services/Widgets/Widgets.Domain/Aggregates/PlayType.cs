using Widgets.Domain.SeedWork;

namespace Widgets.Domain.Aggregates;

public class PlayType
    : Enumeration
{
    public static PlayType Single => new(1, nameof(Single));
    public static PlayType Repeat => new(2, nameof(Repeat));

    public PlayType(int id, string name) : base(id, name)
    {
    }
}