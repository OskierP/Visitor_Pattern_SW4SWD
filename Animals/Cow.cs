public class Cow : IAnimal
{
    public void accept(IWorker visitor)
    {
        visitor.Visit(this);
    }

     public bool hasMilk(){
        return false;
    }
}