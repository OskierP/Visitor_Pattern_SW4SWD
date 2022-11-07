public class Pig : IAnimal
{
    public Pig(){}
    
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
}