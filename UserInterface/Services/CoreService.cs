namespace UserInterface.Services;

public class CoreService : ICoreService
{
    private readonly List<Module> _repository = new List<Module>
    {
        new Module
        {
            Id = 1,
            Name = "Document",
            Description = "Managing Document data structures of the system",
            Functionalities = new List<Functionality>
            {
                new Functionality
                {
                    Id = 100,
                    Name = "List documents",
                    Desc = "Returns a Grid of Documents for listing and filtering"
                },
                new Functionality
                {
                    Id = 101,
                    Name = "Document Builder",
                    Desc = "Building a new Document structure"
                }
            }
        },
        new Module
        {
            Id = 2,
            Name = "Finance",
            Description = "Provides pages to manage personal finances",
            Functionalities = new List<Functionality>
            {
                new Functionality
                {
                    Id = 200,
                    Name = "Incomes and costs",
                    Desc = "a grid providing functionalities to manage income and costs items"
                },
                new Functionality
                {
                    Id = 201,
                    Name = "Investment overview",
                    Desc = "Overview of the investments"
                }
            }
        },
        new Module
        {
            Id = 3,
            Name = "Health",
            Description = "All health related information is displayed here",
            Functionalities = new List<Functionality>
            {
                new Functionality
                {
                    Id = 301,
                    Name = "Nutrition intake",
                    Desc = "What do you eat?"
                },
                new Functionality
                {
                    Id = 302,
                    Name = "Exercise",
                    Desc = "How much do you exercise?"
                }
            }
        },
        new Module
        {
            Id = 4,
            Name = "Cloud Management",
            Description = "All the cloud related stuff",
            Functionalities = new List<Functionality>{
                new Functionality
                {
                    Id = 401,
                    Name = "Servers",
                    Desc = "List of servers I'm running"
                },
            }
    }
};

public List<Module> GetModules()
{
    return _repository;
}

public Module GetModuleById(long moduleId)
{
    return _repository.Find(i => i.Id == moduleId);
}

public List<Functionality> GetFunctionalitiesByModuleId(long moduleId)
{
    return _repository.Find(i => i.Id == moduleId)?.Functionalities;
}

}