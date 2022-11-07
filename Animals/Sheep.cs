public class Sheep : IAnimal
{
    
    public Sheep(){}
    
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
}