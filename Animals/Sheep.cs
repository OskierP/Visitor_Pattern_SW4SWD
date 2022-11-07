public class Sheep : IAnimal
{
    
    public Sheep(){}
    
    public void accept(IWorker visitor)
    {
        visitor.visit(this);
    }
}