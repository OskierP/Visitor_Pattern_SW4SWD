namespace Visitor_Pattern_SW4SWD.Workers;

public class Tourist : IVisitor
{
    private int picturesTaken = 0;

    public void TakePicutre()
    {
        picturesTaken++;
    }

    public int ShowPics()
    {
        return picturesTaken;
    }
    public void visit(Cow animal)
    {
       Console.WriteLine($"Pic taken of {animal.GetType()}");
       TakePicutre();
    }

    public void visit(Sheep animal)
    {
        Console.WriteLine($"Pic taken of {animal.GetType()}");
        TakePicutre();
    }

    public void visit(Pig animal)
    {
        Console.WriteLine($"Pic taken of {animal.GetType()}");
        TakePicutre();
    }

    public void visit(Chicken animal)
    {
        Console.WriteLine($"Pic taken of {animal.GetType()}");
        TakePicutre();
    }

    public void visit(Goat animal)
    {
        Console.WriteLine($"Pic taken of {animal.GetType()}");
        TakePicutre();
    }
    
    public void visit(Farm farm)
    {
        Console.WriteLine("Wow, what an amaizing farm! First selfie: 🧑‍🌾");
        foreach(var location in farm.GetList())
        {
            location.accept(this);
        }
    }

    public void visit(Barn barn)
    {
        Console.WriteLine("I'm in a barn");
        foreach (var animals in barn.GetList())
        {
            animals.accept(this);
        }
        Console.WriteLine("");
    }

    public void visit(Pen pen)
    {
        Console.WriteLine("As a Tourist I'm not going to Pen\n");
    }

    public void visit(Field field)
    {
        Console.WriteLine("I'm in a field");
        foreach (var animals in field.GetList())
        {
            animals.accept(this);
        }
        Console.WriteLine("");
    }
    
    
}