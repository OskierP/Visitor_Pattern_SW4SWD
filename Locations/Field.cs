public class Field: ILocation
{
    
    private readonly List<IAnimal> _animals;

    public Field(List<IAnimal> list)
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