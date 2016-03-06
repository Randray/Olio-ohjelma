using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä_7._3
{
    class Dosthiswork
    {
        public string Name { get; set; }
        public int Channel { get; set; }
        public string Info { get; set; }
        public int Start { get; set; }
        public int End { get; set; }

        public override string ToString()
        {
            return Name + ", " + Channel + ", " + Info + ", " + Start + ", " + End;
        }

        

    }
}
