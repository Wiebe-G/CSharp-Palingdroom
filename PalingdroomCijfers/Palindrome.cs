using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PalingdroomCijfers
{
    internal class Palindrome
    {
        // lijst om bevestigde nummers in op te slaan
        internal HashSet<ulong> lijst = new HashSet<ulong>();
        ulong MaxValue = 0;
        internal void MaxPalingdroomProduct()
        {
            // TODO: Maak dit sneller
            ulong Sum;
            ulong num2 = 10000;
            for (ulong i = 10000; i <= 99999; i++)
            {
                if (num2 >= 99999)
                {
                    break;
                }
                Sum = i * num2;
                if (lijst.Contains(Sum))
                {
                    break;
                }
                if (IsPalindrome(Sum))
                {
                    Console.WriteLine($"{Sum} is een palindroom.");
                    lijst.Add(Sum);
                    if (Sum > MaxValue)
                    {
                        MaxValue = Sum;
                    }
                }

                if (i == 99999)
                {
                    num2++;
                    i = 10000;
                }
            }

            Console.WriteLine($"Hoogste cijfer is {MaxValue}");
        }

        internal bool IsPalindrome(ulong Sum)
        {
            // check hier of palindroom is

            // loop door Sum, pak laatste digit, en zet die als eerste in New
            string Original = Sum.ToString();
            string Reversed = ReverseString(Sum.ToString());
            if (Reversed == Original)
            {
                return true;
            }

            return false;
            //while (Sum > 0)
            //{
            //    Reversed = (Reversed * 10) + Sum % 10;
            //    Sum /= 10;
            //}

            //return Original == Reversed;
        }

        private string ReverseString(string Sum)
        {
            if (Sum.Length == 0)
            {
                return Sum;
            }

            return ReverseString(Sum.Substring(1)) + Sum[0];
        }
    }
}
