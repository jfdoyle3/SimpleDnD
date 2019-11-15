using System;

namespace SimpleDnD
{
    internal class Game
    {
        public static void DNDGame()
        {
            Turn();

        }

        public static int Roll(Die die)
        {
            int roll = die.FaceUp;

            return roll;
        }
        public static void Turn()
        {
            int mods = 0;
            Die d20 = new Die(20);
            int cast = Roll(d20);
            Console.WriteLine("Roll:");
            Console.Write(cast);
            switch (cast)
            {
                case 1:
                    Console.WriteLine("Critical Miss");
                    break;
                case 20:
                    Console.WriteLine("Critical hit");
                    //Damage();
                    break;
                default:
                   mods=Attack(cast);
                   break;

            }
            dynamic wDmg=Damage(mods);
            Console.WriteLine();
            
        }
        public static dynamic Damage(int mods)
        {
            Console.WriteLine("What is the weapon damage");
            string wpnDmg = Console.ReadLine();
            Console.WriteLine(wpnDmg);
            return wpnDmg;

        }
        public static int Attack(int cast)
        {
            Console.WriteLine("\nEnter Damage Modifiers");
            int modifer = Convert.ToInt32(Console.ReadLine());  
            int modRoll =  cast- modifer;
            Console.WriteLine("Armor Class");
            int armorClass = Convert.ToInt32(Console.ReadLine());
            if (modRoll < armorClass)
            {
                Console.WriteLine("Missed");
                return 0;

            }
            else
            {
                Console.WriteLine("Hit");
                return modRoll;
            }

        }
        
    }
}