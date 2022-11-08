public class Sheep : IAnimal
{
    
    public Sheep(){}
    
    public void accept(IVisitor visitor)
    {
        visitor.visit(this);
    }

    public int Milk()
    {
        return 1;
    }

    public bool HasMilk()
    {
        Random gen = new Random();
        int prob = gen.Next(100);
        return prob < 70;
    }
}