using System;
namespace NUnitTesting
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Nunit testing!");
            bool flag = true;
            while (flag)
            {
                Console.Write("1.Vending machine\n2.exit\nEnter your option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        VendingManchine vending = new VendingManchine();
                        Console.WriteLine("Enter amount");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        vending.giveChange(amount);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}