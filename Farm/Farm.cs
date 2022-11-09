public class Farm: IElement
{
    private readonly List<ILocation> _locationsList;
    
    public Farm(List<ILocation> list)
    {
        _locationsList = list;
    }

    public List<ILocation> GetLocations()
    {
        return _locationsList;
    }
    
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
}