using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gün2
{
    public class DayTwo
    {
        public string Name;
        public decimal Height, Weight;
        public Boolean IsWorked;
        public int Hour, Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DayTwo dayTwo = new DayTwo();

            Console.WriteLine("--------Daily Report--------");
            Console.Write("Name: ");
            dayTwo.Name = Console.ReadLine(); Console.WriteLine();

            Console.Write("Height: ");
            dayTwo.Height = decimal.Parse(Console.ReadLine()); Console.WriteLine();

            Console.Write("Weight: ");
            dayTwo.Weight = decimal.Parse(Console.ReadLine()); Console.WriteLine();
            
            Console.Write("Is Worked: ");
            dayTwo.IsWorked = Boolean.Parse(Console.ReadLine()); Console.WriteLine();
            
            if (dayTwo.IsWorked != true && dayTwo.IsWorked != false) { Console.Write("Wrong variable, please enter true or false"); Console.ReadLine(); };

            Console.Write("Hour: ");
            dayTwo.Hour = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
            
            Console.Write("Age: ");
            dayTwo.Age = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
            

            Console.Clear();
            Console.WriteLine("--------Daily Report--------");

            Console.WriteLine($"Name: {dayTwo.Name}\n" +
                $"Height: {dayTwo.Height}\n" +
                $"Weight: {dayTwo.Weight}\n" +
                $"Is Worked: {dayTwo.IsWorked}\n" +
                $"Hour: {dayTwo.Hour}\n" +
                $"Age: {dayTwo.Age}\n");

            Console.ReadLine();
        }
    }
}
