namespace TaskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallCarpetPrice = 25;
            int largeCarpetPrice = 35;
            double taxRate = 0.06;
            Console.WriteLine("please enter the number of small carpets");
            int smallCarpetCount = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the number of large carpets");
            int LargeCarpetCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Price per small room: $25\r\nPrice per large room: $35");
            int cost=(smallCarpetCount * smallCarpetPrice) +(LargeCarpetCount * largeCarpetPrice);
            Console.WriteLine($"cost is: {cost}");
            double tax = cost * taxRate;
            Console.WriteLine($"Tax: {tax}$");
            Console.WriteLine($"Total estimate: {cost+tax}$");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
