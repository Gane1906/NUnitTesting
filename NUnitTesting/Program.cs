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
                Console.Write("1.Vending machine\n2.Day of week\n3.Degree Conversions\n4.exit\nEnter your option: ");
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
                        DayOfWeek d = new DayOfWeek();
                        Console.WriteLine("Enter year");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter month");
                        int month = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter date");
                        int date = Convert.ToInt32(Console.ReadLine());
                        d.day(month, date, year);
                        break;
                    case 3:
                        TemperatureConverter tc = new TemperatureConverter();
                        tc.conversion();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}