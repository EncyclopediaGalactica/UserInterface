namespace UserInterface.Pages;

using Fluxor.Blazor.Web.Components;
using Services;
using Store.SelectModule;

public partial class EGMain
{
    private Module? Module { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        SubscribeToAction<SelectModuleAction>(a =>
        {
            Console.WriteLine("loaded module: " + a.Module.Name);
            Module = a.Module;
            StateHasChanged();
        });
    }
}