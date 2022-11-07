public class Goat : IAnimal
{
 
    public Goat(){}
    
    public void accept(IWorker visitor)
    {
        visitor.visit(this);
    }
}