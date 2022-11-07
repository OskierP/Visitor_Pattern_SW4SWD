public class Farm: IFarm
{
    private readonly List<ILocations> _locationsList;
    
    public Farm(List<ILocations> list)
    {
        _locationsList = list;
    }

    public List<ILocations> GetList()
    {
        return _locationsList;
    }
    
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
}