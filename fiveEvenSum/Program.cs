using System;
using System.Linq;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int[] xArray = new int[5];

            while (x != 0)
            {
                OddsCorrection(ref (x));
                xArray[0] = x;
                for (int i = 1; i < xArray.Length; i++)
                {
                    xArray[i] = x + 2;
                    x = xArray[i];
                }

                Console.WriteLine($"{xArray.Sum()}");
                x = int.Parse(Console.ReadLine());
            }
        }

        private static int OddsCorrection(ref int y)
        {
            if (y % 2 != 0)
            {
                y++;
            }
            return y;
        }
    }
}
