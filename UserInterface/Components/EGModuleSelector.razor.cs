namespace UserInterface.Components;

using Microsoft.Fast.Components.FluentUI;

public partial class EGModuleSelector
{
    public List<Option<string>> Menus { get; } = new List<Option<string>>
    {
        new Option<string> { Value = "1", Text = "Documents 1" },
        new Option<string> { Value = "2", Text = "Finance 2" },
        new Option<string> { Value = "3", Text = "Health 3" },
        new Option<string> { Value = "4", Text = "Core 4" },
    };
}