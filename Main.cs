using System.Runtime.Versioning;

namespace Visitor_Pattern_SW4SWD
{


    class Program
    {
        public static void Main(string[] args)
        {
            Barn barn = new Barn(new List<IAnimal>{new Pig(), new Goat()});
            Field field = new Field(new List<IAnimal> { new Cow(), new Sheep() });
            Pen pen = new Pen(new List<IAnimal> { new Chicken() });
            
            Farm farm = new Farm(new List<ILocations>{barn, field, pen});
            
            farm.accept(new Shearer());

        }
    }
}
