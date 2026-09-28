using System;

namespace Gun2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Adınız: ");
            string name = Console.ReadLine();
            Console.Write("Yaşınız: ");
            int age;
            if (!int.TryParse(Console.ReadLine(), out age) || age < 0) { Console.WriteLine("Geçersiz yaş."); return; }
            Console.Write("Bugün kaç saat çalıştınız? ");
            decimal hours;
            if (!decimal.TryParse(Console.ReadLine(), out hours) || hours < 0) { Console.WriteLine("Geçersiz süre."); return; }
            Console.Write("Spor yaptınız mı? (e/h): ");
            bool exercised = string.Equals(Console.ReadLine(), "e", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"{name} ({age}) - çalışma: {hours} saat, spor: {(exercised ? "evet" : "hayır")}");
        }
    }
}
