using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävät
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Deck> deck = new List<Deck>();

            deck.Add(new Deck {Land= "hertta", Nro=1 });
            deck.Add(new Deck { Land = "hertta", Nro = 2 });
            deck.Add(new Deck { Land = "hertta", Nro = 3 });
            deck.Add(new Deck { Land = "hertta", Nro = 4 });
            deck.Add(new Deck { Land = "hertta", Nro = 5 });
            deck.Add(new Deck { Land = "hertta", Nro = 6 });
            deck.Add(new Deck { Land = "hertta", Nro = 7 });
            deck.Add(new Deck { Land = "hertta", Nro = 8 });
            deck.Add(new Deck { Land = "hertta", Nro = 9 });
            deck.Add(new Deck { Land = "hertta", Nro = 10 });
            deck.Add(new Deck { Land = "hertta", Nro = 11 });
            deck.Add(new Deck { Land = "hertta", Nro = 12 });
            deck.Add(new Deck { Land = "hertta", Nro = 13 });
            deck.Add(new Deck { Land = "ruutu", Nro = 1 });
            deck.Add(new Deck { Land = "ruutu", Nro = 2 });
            deck.Add(new Deck { Land = "ruutu", Nro = 3 });
            deck.Add(new Deck { Land = "ruutu", Nro = 4 });
            deck.Add(new Deck { Land = "ruutu", Nro = 5 });
            deck.Add(new Deck { Land = "ruutu", Nro = 6 });
            deck.Add(new Deck { Land = "ruutu", Nro = 7 });
            deck.Add(new Deck { Land = "ruutu", Nro = 8 });
            deck.Add(new Deck { Land = "ruutu", Nro = 9 });
            deck.Add(new Deck { Land = "ruutu", Nro = 10 });
            deck.Add(new Deck { Land = "ruutu", Nro = 11 });
            deck.Add(new Deck { Land = "ruutu", Nro = 12 });
            deck.Add(new Deck { Land = "ruutu", Nro = 13 });
            deck.Add(new Deck { Land = "risti", Nro = 1 });
            deck.Add(new Deck { Land = "risti", Nro = 2 });
            deck.Add(new Deck { Land = "risti", Nro = 3 });
            deck.Add(new Deck { Land = "risti", Nro = 4 });
            deck.Add(new Deck { Land = "risti", Nro = 5 });
            deck.Add(new Deck { Land = "risti", Nro = 6 });
            deck.Add(new Deck { Land = "risti", Nro = 7 });
            deck.Add(new Deck { Land = "risti", Nro = 8 });
            deck.Add(new Deck { Land = "risti", Nro = 9 });
            deck.Add(new Deck { Land = "risti", Nro = 10 });
            deck.Add(new Deck { Land = "risti", Nro = 11 });
            deck.Add(new Deck { Land = "risti", Nro = 12});
            deck.Add(new Deck { Land = "risti", Nro = 13 });
            deck.Add(new Deck { Land = "pata", Nro = 1 });
            deck.Add(new Deck { Land = "pata", Nro = 2 });
            deck.Add(new Deck { Land = "pata", Nro = 3 });
            deck.Add(new Deck { Land = "pata", Nro = 4 });
            deck.Add(new Deck { Land = "pata", Nro = 5 });
            deck.Add(new Deck { Land = "pata", Nro = 6 });
            deck.Add(new Deck { Land = "pata", Nro = 7 });
            deck.Add(new Deck { Land = "pata", Nro = 8 });
            deck.Add(new Deck { Land = "pata", Nro = 9 });
            deck.Add(new Deck { Land = "pata", Nro = 10 });
            deck.Add(new Deck { Land = "pata", Nro = 11 });
            deck.Add(new Deck { Land = "pata", Nro = 12 });
            deck.Add(new Deck { Land = "pata", Nro = 13 });


            foreach(Deck decks in deck)
            {
                Console.WriteLine(decks.ToString());
            }
           

        }
    }
}
