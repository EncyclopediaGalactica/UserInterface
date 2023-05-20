namespace UserInterface.Store.SelectModule;

using Fluxor;
using Services;

[FeatureState]
public class SelectModuleState
{
    public Module Module { get; }
    private SelectModuleState() {}

    public SelectModuleState(Module module)
    {
        Module = module;
    }
}