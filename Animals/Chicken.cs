public class Chicken : IAnimal
{
    
    public Chicken(){}
    public void accept(IWorker visitor)
    {
        visitor.visit(this);
    }
}