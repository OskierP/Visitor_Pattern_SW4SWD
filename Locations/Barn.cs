
public class Barn: ILocations
{
    private List<IAnimal> _animals;

    public Barn(List<IAnimal> list)
    {
        _animals = list;
    }

    public List<IAnimal> GetList()
    {
        return _animals;
    }
    
    public void accept(IWorker visitor)
    {
       visitor.visit(this);
    }
    
}