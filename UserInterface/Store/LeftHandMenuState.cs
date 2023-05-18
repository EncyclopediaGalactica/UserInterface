namespace UserInterface.Store;

using Fluxor;

[FeatureState]
public class LeftHandMenuState
{
    public string DisplayedModuleMenu { get; }
    public LeftHandMenuState()
    {
    }

    public LeftHandMenuState(string displayedModuleMenu)
    {
        DisplayedModuleMenu = displayedModuleMenu;
    }
}