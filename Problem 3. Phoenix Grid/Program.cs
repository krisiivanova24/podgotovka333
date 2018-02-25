using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> strings = new List<string>();
            while (input != "ReadMe")
            {
                strings.Add(input);
                input = Console.ReadLine();
            }
            string[] results = new string[strings.Count];
            for (int i = 0; i < strings.Count; i++)
            {
                char[] masiv = strings[i].ToCharArray();
                Array.Reverse(masiv);
                //Console.WriteLine(string.Join(" ", masiv));
                if (String.Equals(string.Join("", masiv), strings[i]) && !strings[i].Contains(" ") && !strings[i].Contains("_"))
                {
                    results[i] = "YES";
                    continue;
                }
                int pos = strings[i].IndexOf('.');
                if (pos == -1 || pos != 3) //!strings[i].Contains("."))
                {
                    results[i] = "NO";
                    continue;
                }
                //imame tochka               
                string part1 = strings[i].Substring(0, pos - 1);
                string part2 = strings[i].Substring(pos + 1); //chete do kraq
                if (part1.Length!=3 || part2.Length !=3)
                {
                    results[i] = "NO";
                    continue;
                }
                if (part1.Contains(" ") || part1.Contains("_") || part2.Contains(" ") || part2.Contains("_"))
                {
                    results[i] = "NO";
                    continue;
                }
                
            }
            foreach (var index in results)
            {
                Console.WriteLine(index);
            }
            //Console.Write.Line(stringJoin("\n", result))
        }
    }
}
