namespace UserInterface.Components;

using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.Fast.Components.FluentUI;

public partial class EGHeader
{
    [Inject]
    public IDispatcher Dispatcher { get; set; }

    private Option<string> selectedOption = default!;
    private string selectedValue;

    private List<Option<string>> Modules { get; } = new()
    {
        { new Option<string> { Value = "1", Text = "Library" } },
        { new Option<string> { Value = "2", Text = "Finance" } },
        { new Option<string> { Value = "3", Text = "Health", Selected = true } },
        { new Option<string> { Value = "4", Text = "Games" } },
    };

    private async Task OptionSelected()
    {
        throw new NotImplementedException();
    }
}