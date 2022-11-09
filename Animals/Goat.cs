public class Goat : IAnimal
{
 
    public Goat(){}
    
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }

    public bool IsAngry()
    {
        Random gen = new Random();
        int prob = gen.Next(100);
        return prob < 20;
    }

    public int Milk()
    {
        return 3;
    }
}