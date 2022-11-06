public class Chicken : IAnimal
{
    public void accept(IWorker visitor)
    {
        visitor.Visit(this);
    }
}