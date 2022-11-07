using System.Diagnostics;
using System.Runtime.Versioning;
using Visitor_Pattern_SW4SWD.Workers;

namespace Visitor_Pattern_SW4SWD
{


    class Program
    {
        public static void Main(string[] args)
        {
            Barn barn = new Barn(new List<IAnimal>{new Pig(), new Goat(), new Sheep()});
            Field field = new Field(new List<IAnimal> { new Cow(), new Sheep() });
            Pen pen = new Pen(new List<IAnimal> { new Chicken() });
            
            Farm farm = new Farm(new List<ILocations>{barn, field, pen});
            
            Console.WriteLine("Hi, I'm Shearer\n");
            Shearer shearer = new Shearer();
            farm.accept(shearer);
            Console.WriteLine($"I've got {shearer.ShowWool()}kg of wool 🥳");
            
            Console.WriteLine("====================================");
            
            Console.WriteLine("\nHi, I'm Tourist\n");
            Tourist tourist = new Tourist();
            farm.accept(tourist);
            Console.WriteLine($"I've taken {tourist.ShowPics()} pictures of animals 📸");
            
            Console.WriteLine("====================================");
            
            Console.WriteLine("\nHi, I'm Milker");
            Milker milker = new Milker();
            farm.accept(milker);
            Console.WriteLine($"I've got {milker.ShowMilk()}l of milk ");
            
            Console.WriteLine("====================================");
            
            Console.WriteLine("\nHi, I'm a Butcher muhahah\nDon't look\n");
            Butcher butcher = new Butcher();
            farm.accept(butcher);
            

        }
    }
}
