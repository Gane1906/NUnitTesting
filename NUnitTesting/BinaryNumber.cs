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
            int[] binary = new int[num];
            int i = 0;
            while (num > 0)
            {
                binary[i] = num % 2;
                i++;
                num /= 2;
            }
            Console.Write("The binary value of " + num + " is: ");
            for (int j = i - 1; j >= 0; j--)
                Console.Write(binary[j]);
            Console.WriteLine();

        }
    }
}
/*
 * 10 >0
 * A[0]----- >0
 * 5 >0
 * A[1]----->1
 * 2 >0
 * A[2]----->0
 * 1>0
 *A[3]------>1 
 *
*/
