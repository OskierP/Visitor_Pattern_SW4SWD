public class Goat : IVisitable
{
 
    public Goat(){}
    
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
}