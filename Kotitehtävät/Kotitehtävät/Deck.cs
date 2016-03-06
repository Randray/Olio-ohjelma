using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävät
{
    class Deck
    {
        public string Land { get; set; }
        public int Nro { get; set; }

        public override string ToString()
        {
            return Land + " " + Nro;
        }

    }
}
