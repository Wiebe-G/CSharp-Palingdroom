using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalingdroomCijfers
{
    internal class Program
    {
        internal LinkedList<ulong> lijst = new LinkedList<ulong>();
        static void Main(string[] args)
        {
            Program program = new Program();
            program.MaxPalingdroomProduct();
        }

        internal void MaxPalingdroomProduct()
        {
            ulong Sum;
            ulong num2 = 10000;
            for (ulong i = 10000; i <= 99999; i++)
            {
                if (num2 >= 99999)
                {
                    return;
                }
                Sum = i * num2;
                if (lijst.Contains(Sum))
                {
                    return;
                }
                if (IsPalindrome(Sum))
                {
                    Console.WriteLine($"{Sum} is een palindroom");
                    lijst.AddLast(Sum);
                }

                // een zeer helder idee
                // 89999 keer de loop uitvoeren
                // 5head
                //if (i == 99999)
                //{
                //    num2++;
                //    i = 10000;
                //}
            }
        }

        internal bool IsPalindrome(ulong Sum)
        {
            // check hier of palindroom is

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
