public class Goat: IAnimal
{
    public void accept(IWorker visitor)
    {
        visitor.Visit(this);
    }
}