using System.Diagnostics;

namespace ConsoleApp1
{
    enum Months
    {
        January = 1,    
        February,  
        March,     
        April,      
        May,       
        June,       
        July,
        August,
        September,
        October,
        November,
        December
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case (int)Months.January:
                    Console.WriteLine(Months.January);
                    break;
                case (int)Months.February:
                    Console.WriteLine(Months.February);
                    break;
                case (int)Months.March:
                    Console.WriteLine(Months.March);
                    break;
                case (int)Months.April:
                    Console.WriteLine(Months.April);
                    break;
               case (int)Months.May: 
                    Console.WriteLine(Months.May);
                    break;
               case (int)Months.June:
                    Console.WriteLine(Months.June);
                    break;
               case (int)Months.July:
                    Console.WriteLine(Months.July);
                    break;
               case (int)Months.August:
                    Console.WriteLine(Months.August);
                    break;
               case (int)Months.September:
                    Console.WriteLine(Months.September);
                    break;
               case (int)Months.October:
                    Console.WriteLine(Months.October);
                    break;
               case (int)Months.November:
                    Console.WriteLine(Months.November);
                    break;
                case (int)Months.December:
                    Console.WriteLine(Months.December);
                    break;
            }
            
            
        }
    }
}