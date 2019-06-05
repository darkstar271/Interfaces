using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Weevils : IData, ILifeFormType
    {


        public string Food { get; set; }
        public string CountLegs { get; set; }


        public string Name { get; set; }
        public string Origin { get; set; }
        public string Tastes { get; set; }
        public string Species { get; set; }
        public string Genus { get; set; }
        public string Family { get; set; }
    }
}
