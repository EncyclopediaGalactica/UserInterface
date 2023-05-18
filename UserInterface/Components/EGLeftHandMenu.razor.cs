namespace UserInterface.Components;

using Fluxor;
using Microsoft.AspNetCore.Components;
using Store;

public partial class EGLeftHandMenu
{
    [Inject]
    public IStore Store { get; set; }
    
    [Inject]
    public IState<LeftHandMenuState> LeftHandMenuState { get; set; }

    private List<string> Menus = new List<string> { "System", "Finance", "Health", "Games" };
}