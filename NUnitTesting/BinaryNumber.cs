using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class BinaryNumber
    {
        public static void toBinary(int num)
        {
            string binary = " ", res = " ";
            while (num > 0)
            {
                binary += num % 2;
                //i++;
                num /= 2;
            }
            for (int i = binary.Length - 1; i >= 0; i--)
                res += binary[i];
            Console.WriteLine(res);
        }
    }
}