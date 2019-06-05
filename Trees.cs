using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Trees : IData, IVegetation
    {
        public string TrunkType { get; set; }
        public string LeafColor { get; set; }
        //  public Type { get; set; }


        public string Name { get; set; }
        public string Origin { get; set; }
        public string Tastes { get; set; }
        public bool HasRoots { get; set; }
    }
}
