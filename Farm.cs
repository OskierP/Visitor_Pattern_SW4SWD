using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern_SW4SWD
{
    public class Farm
    {
        private List<IAnimal> animals = new List<IAnimal>();
        private List<Worker> workers = new List<Worker>();

        public void Produce();

        public void Admit(ref Worker w);
        public void Dismiss(ref Worker w);
    }
}
