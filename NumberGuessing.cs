using System;

namespace Projects;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Bot: I randomly chose a number between 0 and 25. Can you guess it?");

        Random random = new Random();
        int number = random.Next(0, 26); // 0 to 25
        int guess;
        int tries = 0;

        while (true)
        {
            guess = Convert.ToInt32(Console.ReadLine());
            tries++;
            if (guess == number)
            {
                Console.WriteLine($"Congrats you beat the game. You did it in your {tries}. try.");
                break;
            }
            else if (guess != number)
            {
                Console.WriteLine($"Wrong number. Youre on your {tries}. try.");
                if (tries == 10)
                {
                    Console.WriteLine("You hit your 10th try so you lose.");
                    break;
                }

            }

        }
    }
}