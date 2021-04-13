using System;

namespace tibiacalc
{
    class TibiaCalc
    {
        const int baseHp = 185;
        const int baseMana = 90;
        const int hpChangeKnight = 15;
        const int hpChangePaladin = 10;
        const int hpChangeMage = 5;
        const int manaChangeKnight = 5;
        const int manaChangePaladin = 15;
        const int manaChangeMage = 30;
        const int manaChangeNovoc = 5;
        const int hpChangeNovoc = 5;

        static void Main(string[] args)
        {
            Calculate();
        }
        static void DisplayStats(int lvl)
        {
            int mana = 0;
            int hp = 0;
            Console.WriteLine("Choose one of the four vocation:");
            Console.WriteLine("\t Knight");
            Console.WriteLine("\t Paladin");
            Console.WriteLine("\t Druid");
            Console.WriteLine("\t Sorcerer");

            switch (Console.ReadLine())
            {
                case "Knight":
                    hp = baseHp + (hpChangeKnight * (lvl - 8));
                    mana = baseMana + (manaChangeKnight * (lvl - 8));
                    break;

                case "Paladin":
                    hp = baseHp + (hpChangePaladin * (lvl - 8));
                    mana = baseMana + (manaChangePaladin * (lvl - 8));
                    break;

                case "Druid":
                case "Sorcerer":
                    hp = baseHp + (hpChangeMage * (lvl - 8));
                    mana = baseMana + (manaChangeMage * (lvl - 8));
                    break;

                default:
                    Console.WriteLine("Type proper vocation");
                    DisplayStats(lvl);
                    return;

            }
            Console.WriteLine($"You have {hp} health points and {mana} mana points");
        }

        private static void Calculate()
        {
         
            try
            {
                Console.WriteLine("Type level (digits) or exit to close");
                string input = Console.ReadLine();
                if (input == "exit" )
                {
                    return;
                }
                int lvl = Convert.ToInt32(input);
                if (lvl < 1)
                {
                    Console.WriteLine("You cannot have this level in tibia");
                }
                else if (lvl < 8)
                {
                    int hp = baseHp - (8 - lvl) * hpChangeNovoc;
                    int mana = baseMana - (8 - lvl) * manaChangeNovoc;
                    Console.WriteLine($"You have {hp} health points and {mana} mana points");
                }
                else
                {
                    DisplayStats(lvl);  
                   
                }
            }
            catch (FormatException fexcp)
            {
                Console.WriteLine("jestes debilem bo miales podac liczbe");
            }
            catch (DivideByZeroException zero)
            {
                Console.WriteLine("Pamietaj cholero nie dziel przedz zero");
            }
            catch (Exception excp)
            {
                Console.WriteLine("Ops cos poszlo nie tak");
            }
            Console.WriteLine();
            Calculate();
        }
       
    }
}
