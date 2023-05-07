namespace UserInterface.Components;

using Microsoft.Fast.Components.FluentUI;

public partial class EGHeader
{
    public List<Option<string>> Modules { get; set; } = new()
    {
        { new Option<string>(){Value = "1", Text = "Library"} },
        { new Option<string>(){Value = "2", Text = "Finance"} },
        { new Option<string>(){Value = "2", Text = "Health"} },
        { new Option<string>(){Value = "2", Text = "Games"} },
    };
}