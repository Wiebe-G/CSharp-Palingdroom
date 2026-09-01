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
            int Sum;
            for (int i = 10000; i <= 99999; i++)
            {
                Sum = i * i;
                if (IsPalindrome(Sum))
                {
                    Console.WriteLine($"{Sum} is wel een palindroom");
                }
            }
        }

        internal bool IsPalindrome(int Sum)
        {
            // check hier of palindroom is
            if (Sum > 0)
            {
                return true;
            }
            return false;
        }
    }
}
