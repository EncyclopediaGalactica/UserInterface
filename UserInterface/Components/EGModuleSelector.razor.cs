namespace UserInterface.Components;

using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.Fast.Components.FluentUI;
using Services;
using Store;
using Store.SelectModule;

public partial class EGModuleSelector
{
    [Inject]
    public IStore Store { get; set; }
    
    [Inject]
    public IState<SelectModuleState> SelectedModuleState { get; set; }
    
    [Inject]
    public ICoreService CoreService { get; set; }
    
    [Inject]
    public IDispatcher Dispatcher { get; set; }
    
    public List<Option<string>> Menus { get; set; }

    private Option<string> selectedModule;

    protected override async Task OnInitializedAsync()
    {
        await PopulateModulesData();
        selectedModule = Menus.Find(item => item.Text == "Document");
        Module selected = await FindModuleByName(selectedModule.Text);
        Dispatcher.Dispatch(new SelectModuleAction(selected));
        await base.OnInitializedAsync();
    }

    private async Task PopulateModulesData()
    {
        List<Option<string>> result = new List<Option<string>>();
        CoreService.GetModules().ForEach(module =>
        {
            result.Add(
                new Option<string>
                {
                    Value = module.Id.ToString(),
                    Text = module.Name
                });
        });
        Menus = result;
    }

    private async Task<Module> FindModuleByName(string moduleName)
    {
        Module? result = CoreService.GetModules().Find(item => item.Name == moduleName);
        return result;
    }

    private async Task ModuleSelectionAction(ChangeEventArgs arg)
    {
        selectedModule = Menus.Find(item => item.Text.Equals(arg.Value));
        Module result = await FindModuleByName(arg.Value.ToString());
        Dispatcher.Dispatch(new SelectModuleAction(result));
    }
}