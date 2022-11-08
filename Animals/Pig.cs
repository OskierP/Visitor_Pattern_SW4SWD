public class Pig : IVisitable
{
    public Pig(){}
    
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
}