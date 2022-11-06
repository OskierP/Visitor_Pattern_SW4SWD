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
        private List<IWorker> workers = new List<IWorker>();

        public void Produce(){}

        public void Admit(ref IWorker w){}
        public void Dismiss(ref IWorker w){}
    }
}
