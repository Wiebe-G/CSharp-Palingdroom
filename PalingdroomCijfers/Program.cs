using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalingdroomCijfers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.MaxPalingdroomProduct();
        }

        internal void MaxPalingdroomProduct()
        {
            ulong Sum;
            for (ulong i = 10000; i <= 99999; i++)
            //for (ulong i = 3; i < 15; i++)
            {
                Sum = i * i;
                if (IsPalindrome(Sum))
                {
                    Console.WriteLine($"{Sum} is een palindroom");
                }
            }
        }

        internal bool IsPalindrome(ulong Sum)
        {
            // check hier of palindroom is
            //return Sum.ToString().SequenceEqual(Sum.ToString().Reverse());
            if (Sum < 0)
            {
                return false;
            }

            // loop door Sum, pak laatste digit, en zet die als eerste in New
            ulong Original = Sum;
            ulong Reversed = 0;

            while (Sum > 0)
            {
                Reversed = (Reversed * 10) + Sum % 10;
                Sum /= 10;
            }

            return Original == Reversed;
        }

    }
}
