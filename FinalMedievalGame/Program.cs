namespace FinalMedievalGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            StoryText.StartGame();
            StoryText.Introduction();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Old Man: Greetings traveler! What is your name?");
            Console.ResetColor();
            Character.Name = StoryText.GetName();
             
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"It is lovely to meet you {Character.Name}. I sense you have a longing for adventure. I can offer you two paths.");
            Console.ResetColor();
            StoryText.IntroductionCont();
            StoryText.PathChoice();
            int pathChoice = int.Parse(Console.ReadLine());
            Console.Clear();
            
            if (pathChoice == 1 )
            {
                StoryText.StartDarkForest1();
                

               
            }
            else
            {
                StoryText.StartDragonPeak1();
                //battle sequence for dragon
                Console.WriteLine("What will you do?");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1. Engage in a direct battle with the dragon");
                Console.WriteLine("2. Flee and take cover");
                Console.ResetColor();
                Console.Write("Enter your choice (1 or 2): ");

                
                    
            }
        }
        
    }
}