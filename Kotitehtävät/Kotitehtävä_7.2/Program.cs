using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Kotitehtävä_7._3
{
    class Program


    {



        static void Main(string[] args)
        {
            IFormatter formatter = new BinaryFormatter();

            List<Dosthiswork> work = new List<Dosthiswork>();

            work.Add(new Dosthiswork {Name="Angel of Darkness", Channel=3,Info="Show about fallen angels",Start=20,End=22 });
            work.Add(new Dosthiswork { Name = "DOOM", Channel = 1, Info = "Show about DOOM", Start = 20, End = 22 });
            work.Add(new Dosthiswork { Name = "Undertale", Channel = 19, Info = "U know", Start = 20, End = 22 });
            work.Add(new Dosthiswork { Name = "Angel of Darkness", Channel = 3, Info = "Show about fallen angels", Start = 20, End = 22 });

            Stream writeMultipleStream = new FileStream("MyTVprograms.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(writeMultipleStream, work);
            writeMultipleStream.Close();

            Stream openStream = new FileStream("MyTVprograms.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Dosthiswork> TVPrograms = (List<Dosthiswork>)formatter.Deserialize(openStream);
            openStream.Close();


            foreach (Dosthiswork p in TVPrograms)
            {
                Console.WriteLine("Shows name is {0},",p.Name+"Channel is {1},",p.Channel+"Info {2},",p.Info+"Show starts at {3},",p.Start+"Show ends at {4}.",p.End);
            }


















        }
        }   
    
        
    }
