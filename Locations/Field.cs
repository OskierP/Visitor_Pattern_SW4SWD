public class Field: IVisitable
{
    
    private List<IVisitable> _animals;

    public Field(List<IVisitable> list)
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