using System;

namespace exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите растояние");
            int distance = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите простой");
            int plain = int.Parse(Console.ReadLine());
            if (distance >= 5)
            {
                int cost = (distance - 5 )*3 + 20 + plain;
                Console.WriteLine($"Стоимость поездки {cost} грн.");
            }
            else
            {
                int cost = 20 + plain;
                Console.WriteLine($"Стоимость поездки {cost} грн.");
            }


        }
    }
}
