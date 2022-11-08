public class Farm: IVisitable
{
    private readonly List<IVisitable> _locationsList;
    
    public Farm(List<IVisitable> list)
    {
        _locationsList = list;
    }

    public List<IVisitable> GetList()
    {
        return _locationsList;
    }
    
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
}