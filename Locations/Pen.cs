public class Pen: IVisitable
{
    
    private List<IVisitable> _animals;

    public Pen(List<IVisitable> list)
    {
        _animals = list;
    }

    public List<IVisitable> GetList()
    {
        return _animals;
    }

    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
}