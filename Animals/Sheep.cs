public class Sheep: IAnimal
{
    public void accept(IWorker visitor)
    {
        visitor.Visit(this);
    }

    public bool isShearable(){
        return false;
    }
}