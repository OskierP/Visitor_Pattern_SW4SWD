public class Sheep : IVisitable
{
    
    public Sheep(){}
    
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
}