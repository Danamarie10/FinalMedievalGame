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
            bool exit = false;
            while ( !exit )
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("But Before you make your choice I want to offer you this Health Potion, you never know when you may need it");
                Console.ResetColor();
                Potion.AddPotion(); 
            
            StoryText.IntroductionCont();
            StoryText.PathChoice();
            int pathChoice = int.Parse(Console.ReadLine());
            Console.Clear();

                if (pathChoice == 1)
                {
                    StoryText.StartDarkForest1();



                }
                else
                {
                    StoryText.StartDragonPeak1();




                }        
            }
        }
        
    }
}