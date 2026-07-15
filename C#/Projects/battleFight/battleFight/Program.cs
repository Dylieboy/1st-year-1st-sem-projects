using System;
using System.IO;

namespace BattleFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroHealth = 10;
            int monsterHealth = 10;
            Random attack = new Random();

            // The loop runs as long as BOTH are alive
            while (heroHealth > 0 && monsterHealth > 0)
            {
                // 1. Hero's Turn
                // (We don't need to check "if (heroHealth > 0)" because the while loop guarantees it)
                int damage = attack.Next(1, 11);
                monsterHealth -= damage;

                // Math.Max(0, ...) prevents printing negative health values (looks much cleaner!)
                Console.WriteLine($"Monster was damaged and lost {damage} health and now has {Math.Max(0, monsterHealth)} health.");

                // If the monster died from the hero's attack, skip its turn immediately
                if (monsterHealth <= 0)
                    continue;

                // 2. Monster's Turn
                damage = attack.Next(1, 11);
                heroHealth -= damage;
                Console.WriteLine($"Hero was damaged and lost {damage} health and now has {Math.Max(0, heroHealth)} health.");
            }

            // 3. Declare Winner (Checked once after the loop ends)
            Console.WriteLine();
            if (heroHealth > 0)
            {
                Console.WriteLine("Hero won!!");
            }
            else
            {
                Console.WriteLine("Monster won!!");
            }
        }//end main
    }//end class
}//end namespace