public class Chicken : IVisitable
{
    
    public Chicken(){}
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
}