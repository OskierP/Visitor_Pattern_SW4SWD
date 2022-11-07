public class Cow : IAnimal
{
    public Cow(){}
    
    public void accept(IWorker visitor)
    {
        visitor.visit(this);
    }
}