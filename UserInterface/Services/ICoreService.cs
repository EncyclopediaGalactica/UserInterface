namespace UserInterface.Services;

public interface ICoreService
{
    List<Module> GetModules();
    Module GetModuleById(long moduleId);
    List<Functionality> GetFunctionalitiesByModuleId(long moduleId);
}