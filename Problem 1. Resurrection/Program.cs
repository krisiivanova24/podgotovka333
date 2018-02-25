using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiPh = int.Parse(Console.ReadLine());
            List < int > lengthL = new List<int>();
            List < float > widthL = new List<float>();
            List < int > wingL = new List<int>();
            for (int i = 0; i < broiPh; i++)
            {
                int length = int.Parse(Console.ReadLine());
                lengthL.Add(length);
                float width = float.Parse(Console.ReadLine());
                widthL.Add(width);
                int wing = int.Parse(Console.ReadLine());
                wingL.Add(wing);
            }
        }
    }
}
