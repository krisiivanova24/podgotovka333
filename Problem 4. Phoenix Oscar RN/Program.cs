using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Phoenix_Oscar_RN
{
    class Program
    {
        static void Main(string[] args)
        {
            string creature = Console.ReadLine();
            Dictionary<string, List<string>> allCreat = new Dictionary<string, List<string>>();
            while (creature != "Blaze it!")
            {
                List<string> list = creature.Split(' ').ToList();
                string captain = list[0];
                string mate = list[2];
                //allCreat[captain] = new List<string>();
                //allCreat[captain].Add(mate);

                if (allCreat.ContainsKey(captain))
                {
                    if (allCreat[captain].Contains(mate) == false)
                    {
                        allCreat[captain].Add(mate);
                    }
                }
                else
                {
                    if (mate != captain)
                    {
                        List<string> otbor = new List<string>();
                        otbor.Add(mate);
                        allCreat[captain] = otbor;
                    }
                }
                creature = Console.ReadLine();
            }
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (var item in allCreat.Keys)
            {
                Console.WriteLine($"{item} ---- {string.Join(", ", allCreat[item])} ");
                counts.Add(item, allCreat[item].Count);
            }
            counts = counts.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} +++++ {item.Value} ");
                
            }
        }
    }
}
