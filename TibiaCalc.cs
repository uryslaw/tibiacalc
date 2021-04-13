using System;

namespace tibiacalc
{
    class TibiaCalc
    {
        static void Main(string[] args)
        {
            int lvl;
            int mana;
            int hp;
            Console.WriteLine("Type level (digit)");
            lvl = Convert.ToInt32(Console.ReadLine());
            if ( lvl < 1)
            {
                Console.WriteLine("You cannot have this level in tibia");
            }
            else if (lvl < 8)
            {
                hp = 150 + (lvl * 5);
                mana = 55 + (lvl * 5);
                Console.WriteLine($"You have {hp} health points and {mana} mana points");
            }
            else
            {
                Console.WriteLine("Choose one of the four vocation:");
                Console.WriteLine("\t Knight");
                Console.WriteLine("\t Paladin");
                Console.WriteLine("\t Druid");
                Console.WriteLine("\t Sorcerer");

                switch (Console.ReadLine())
                {
                    case "Knight":
                        hp = 1000 + (15 * (lvl - 8));
                        mana = 90 + (5 * (lvl - 8));
                        Console.WriteLine($"You have {hp} health points and {mana} mana points");
                        break;

                    case "Paladin":
                        hp = 1000 + (10 * (lvl - 8));
                        mana = 90 + (15 * (lvl - 8));
                        Console.WriteLine($"You have {hp} health points and {mana} mana points");
                        break;

                    case "Druid":
                        hp = 1000 + (5 * (lvl - 8));
                        mana = 90 + (30 * (lvl - 8));
                        Console.WriteLine($"You have {hp} health points and {mana} mana points");
                        break;

                    case "Sorcerer":
                        hp = 1000 + (5 * (lvl - 8));
                        mana = 90 + (30 * (lvl - 8));
                        Console.WriteLine($"You have {hp} health points and {mana} mana points");
                        break;

                }
            }
        }
    }
}
