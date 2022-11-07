public class Pig : IAnimal
{
    public Pig(){}
    
    public void accept(IWorker visitor)
    {
        visitor.visit(this);
    }
}