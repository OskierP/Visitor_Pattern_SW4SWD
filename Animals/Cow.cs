public class Cow : IAnimal
{
    public void accept(IWorker visitor)
    {
        throw new NotImplementedException();
    }

     public bool hasMilk(){
        return false;
    }
}