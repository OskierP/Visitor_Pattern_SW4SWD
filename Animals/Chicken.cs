public class Chicken : IAnimal
{
    
    public Chicken(){}
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
}