namespace UserInterface.Store.SelectModule;

using Fluxor;
using Services;

public static class SelectModuleReducers
{
    [ReducerMethod]
    public static SelectModuleState ReduceSelectModuleAction(
        SelectModuleState state,
        SelectModuleAction action)
    {
        return new SelectModuleState(action.Module);
    }
}