public class Barn: ILocation
{
    private readonly List<IAnimal> _animals;

    public Barn(List<IAnimal> list)
    {
        _animals = list;
    }

    public List<IAnimal> GetAnimals()
    {
        return _animals;
    }
    
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
    
}