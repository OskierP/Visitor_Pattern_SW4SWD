public class Cow : IVisitable
{
    public Cow(){}
    
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
}