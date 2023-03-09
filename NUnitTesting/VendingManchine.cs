using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class VendingManchine
    {
        int[] notes = { 2000, 500, 100, 50, 20, 5, 2, 1 };  
        public void giveChange(int amount)
        {
            int countOfNotes = 0;
            for(int i = 0; i < notes.Length; i++)
            {
                if (amount > 0 && amount / notes[i] >= 1)
                {
                    int change = amount / notes[i];
                    countOfNotes += change;
                    Console.WriteLine(notes[i] + "------>>>" + change);
                    amount -= notes[i] * change;
                }
            }
            Console.WriteLine("The total number of notes needed are " + countOfNotes);
        }
    }
}
