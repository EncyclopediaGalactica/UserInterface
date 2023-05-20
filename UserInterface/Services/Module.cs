namespace UserInterface.Services;

public class Module
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Functionality> Functionalities { get; set; }
}