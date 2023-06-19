namespace FinalMedievalGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;

            
            while (cont)
            {
                Console.WriteLine("Would you like to play, enter yes/no");
                var userResponse = Console.ReadLine();

                while (userResponse != "yes" &&  userResponse != "no")
                {
                    Console.WriteLine("That is not an option, enter yes/no");
                    userResponse = Console.ReadLine();
                }

                if (userResponse == "no")
                {
                    return; 
                }
                

                StoryText.StartGame();
                StoryText.Introduction();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Old Man: Greetings traveler! What is your name?");
                Console.ResetColor();
                Character.Name = StoryText.GetName();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Old Man: and what is your class?");
                Fighter.ClassChoice = StoryText.GetClass();

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"It is lovely to meet you {Character.Name}. I sense you have a longing for adventure. I can offer you two paths.");
                Console.ResetColor();
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Old Man: But Before you make your choice I want to offer you this Health Potion, you never know when you may need it!");
                    Console.ResetColor();
                    Potion.AddPotion();

                    StoryText.IntroductionCont();
                    StoryText.PathChoice();
                    int pathChoice = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (pathChoice == 1)
                    {
                        StoryText.StartDarkForest1();
                        break;
                    }
                    else
                    {
                        StoryText.StartDragonPeak1();
                        break;
                        StoryText.DragonPeak2();
                        break;
                    }

                    Console.WriteLine("Do you want to play again? Yes/No");

                    userResponse = Console.ReadLine();

                    while (userResponse != "yes" && userResponse != "no")
                    {
                        Console.WriteLine("That is not an option, enter yes/no");
                        userResponse = Console.ReadLine();
                    }

                    if (userResponse == "no")
                    {
                        cont = false; 
                    }
                }
            }
        }

    }
}