using System;

namespace OOP_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameAccount andrii = new GameAccount("Andrii");
            //GameAccount stepan = andrii; //same player exception test
            GameAccount stepan = new GameAccount("Stepan");

            for (int i = 0; i < 10; i++)
            {
                Match.Play(andrii, stepan);
            }
            Console.WriteLine();

            andrii.GetStats();
            Console.WriteLine();
            stepan.GetStats();
        }
    }
}
