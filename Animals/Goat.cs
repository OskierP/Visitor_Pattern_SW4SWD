public class Goat : IAnimal
{
 
    public Goat(){}
    
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
}