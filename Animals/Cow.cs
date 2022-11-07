public class Cow : IAnimal
{
    public Cow(){}
    
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }
}