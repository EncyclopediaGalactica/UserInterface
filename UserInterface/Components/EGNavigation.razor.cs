namespace UserInterface.Components;

using Fluxor;
using Fluxor.Blazor.Web.Components;
using Microsoft.AspNetCore.Components;
using Services;
using Store;
using Store.SelectModule;

public partial class EGNavigation
{
    [Inject]
    public IStore Store { get; set; }

    [Inject]
    public ICoreService CoreService { get; set; }

    public List<Functionality> Functionalities { get; set; } = new List<Functionality>();
    

    protected override void OnInitialized()
    {
        base.OnInitialized();
        SubscribeToAction<SelectModuleAction>(moduleAction =>
        {
            Console.WriteLine("executed...");
            Functionalities = CoreService.GetFunctionalitiesByModuleId(moduleAction.Module.Id);
        });
    }
}