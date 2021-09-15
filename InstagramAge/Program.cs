using System;

namespace InstagramAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 või vanem, sisi ta võib Instagram-i kasutada;
            //kui kasutaja on noorem, kui 13, siis ta on liiga noor;

            Console.WriteLine("Palun sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge >= 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagram-i kontot luua.");
            }
            else
            {
                Console.WriteLine("Oled liga noor, et Instagram-i kontot luua");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
