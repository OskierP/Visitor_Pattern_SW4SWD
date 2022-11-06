public class Pig: IAnimal
{
    public void accept(IWorker visitor)
    {
        visitor.Visit(this);
    }
}