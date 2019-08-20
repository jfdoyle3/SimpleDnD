using System;

namespace SimpleDnD
{
    class Program
    {
        static void Main(string[] args)
        {
            Die d20 = new Die(20);

            Console.WriteLine(d20.FaceUp);

            int modifer = Convert.ToInt32(Console.Read());

        }
    }
}
