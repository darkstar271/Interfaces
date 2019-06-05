using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Carrots : IData, IVegetation

    {
        public string Color { get; set; }
        public string LeafColor { get; set; }


        public string Name { get; set; }
        public string Origin { get; set; }
        public string Tastes { get; set; }
        public bool HasRoots { get; set; }
    }
}
