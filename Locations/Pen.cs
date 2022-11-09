public class Pen: ILocation
{
    
    private readonly List<IAnimal> _animals;

    public Pen(List<IAnimal> list)
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