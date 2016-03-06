using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä_8._2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Products> pr = new List<Products>();

            pr.Add(new Products { Name = "Milk", Price = 1.4f });
            pr.Add(new Products { Name = "Beer", Price = 2.2f });
            pr.Add(new Products { Name = "Butter", Price = 3.2f });
            pr.Add(new Products { Name = "Cheese", Price = 4.4f });



            Console.WriteLine("All products in colegtions:");
            foreach (Products p in pr)
            {

                Console.WriteLine("- pruduct : {0} {1} e",p.Name,p.Price);
            }


        }
    }
}
