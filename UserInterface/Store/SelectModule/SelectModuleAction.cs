namespace UserInterface.Store.SelectModule;

using Services;

public class SelectModuleAction
{
    public Module Module { get; }
    public SelectModuleAction(Module module)
    {
        Module = module;
    }
}