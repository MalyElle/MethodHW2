using System;

namespace reviewLoopHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Beautiful!");

            Console.WriteLine("Favorite ice cream flavors?");
            Console.WriteLine("Choose: 1.Strawberry Shortcake, 2.Mint Chocolatechip, 3.Chocolate Brownie: ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    methodFirst();
                    break;
                case "2":
                    methodSecond(1);
                    break;
                case "3":
                    string goodFlavor = methodThird(5);
                    Console.WriteLine(goodFlavor);
                    break;
                default:
                    Console.WriteLine("You're just lactose intolerance! SSSAAAAADDDD!!");
                    break;
            }
        }
        private static void methodFirst()
        {
            Console.WriteLine("Strawberry Shortcake is your favorite ice cream!");
            Console.WriteLine("You must love eating alot of Strawberry then!");
        }

        private static void methodSecond(int yummy)
        {
            Console.WriteLine("Mint Chocolatechip is your favorite ice cream!");
            Console.WriteLine("You like to really eat this {0} ice cream!", yummy);
        }

        private static string methodThird(int looper)
        {
            Console.WriteLine("Chocolate Brownie is your favorite ice cream!");
            for(int i = 0; i < looper; i++)
            {
                methodSecond(i);
            }
            return "You must be sick and tired of eating this ice cream now!";
        }
    }
}