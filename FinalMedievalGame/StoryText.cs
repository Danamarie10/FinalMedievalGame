using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FinalMedievalGame
{
    internal class StoryText
    {
        public static void StartGame()
        {
            Console.WriteLine("Press enter to start the game");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Introduction()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("You find yourself in a medieval village, surrounded by thatched-roof cottages and villagers going about daily chores.");
            Console.WriteLine("As you walkthrough the village square, a weathered old man approaches you, his cloak billowing in the wind.");
            Console.ResetColor();
            Console.ReadKey();
        }
        public static string GetName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.ResetColor();
            return Console.ReadLine();


        }


        public static void IntroductionCont()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The first is a challenging journey through the Dark Forest, rumored to be haunted by evil spirits.");
            Console.WriteLine("The second is a perilous climb up the treacherous Dragon's Peak, where a fearsome dragon resides.");
            Console.ResetColor();
            Console.ReadKey();
        }
        public static void PathChoice()
        {
            Console.WriteLine("Which path will you choose");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Venture through the Dark Forest");
            Console.WriteLine("2. Ascend Dragon's Peak");
            Console.ResetColor();

            Console.Write("Enter your choice (1 or 2): ");

        }

        public static void StartDarkForest1()
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("You decide to venture through the Dark Forest, despite the rumors of evil spirits that haunt its depths.");
            Console.WriteLine("The old man nods solemnly, cautioning you to be wary of the forest's dangers.");
            Console.WriteLine("He hands you a flickering lantern to light your way and points you in the direction of the forest's entrance.");
            Console.WriteLine("With the Lantern held high, you step into the eerie darkness of the Dark Forest.");
            Console.WriteLine("Twisted trees with gnarled branches reach out, casting long shadows that dance in the dim light.");
            Console.WriteLine("The air is heavy with an otherworldly stillness.");
            Console.ResetColor();
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("As you make your way deeper into the forest, you come across a fork in the path.");
            Console.WriteLine("To your left, a narrow trail disappears into the dense undergrowth.");
            Console.WriteLine("To your right, a wider path seems more traveled.");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("Which way will you go?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Take the narrow trail to the left");
            Console.WriteLine("2. Follow the wider, more traveled path");
            Console.ResetColor();
            Console.Write("Enter your choice (1 or 2): ");

            int choice1 = int.Parse(Console.ReadLine());

            Console.Clear();

            if (choice1 == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You decide to take the narrow trail to the left, following the path that disappears into the dense undergrowth.");
                Console.WriteLine("The forest grows even darker as your proceed, and the air becomes colder causing a shiver to run down your spine.");
                Console.WriteLine("The branches of the trees seem to twist and contort with an otherworldly presence.");
                Console.WriteLine("As you navigate the winding trail, you hear a faint rustling sound nearby.");
                Console.ResetColor();
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("You pause, your senses heightened, trying to discern its source.");
                Console.WriteLine("Suddenly, a pair of glowing eyes appear from the shadows - a fearsome creature known as a Forest Dweller emerges.");
                Console.WriteLine("The Forest Dweller is a formidable opponent standing on two legs with razor-sharp claws and a gnarled, twisted body. It snarls, ready to attack");
                Console.ResetColor();
                Console.ReadKey();

                Console.WriteLine("What will you do?");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1. Engage in a direct battle with the Forest Dweller.");
                Console.WriteLine("2. Attempt to evade the creature and continue on your path");
                Console.ResetColor();
                Console.Write("Enter your choice (1 or 2): ");
                Console.ReadLine();
                var battleChoiceF = int.Parse(Console.ReadLine());

                if (battleChoiceF == 1)
                {
                    StoryText.ForestDwellerBattle();
                }
               else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You choose to attempt to evade the Forest Dweller and find an alternative route.");
                    Console.WriteLine("With quick thinking, you assess the situation and decide that engaging in a direct battle may be too risky.");
                    Console.WriteLine("You quietly step back, trying to create a distance between yourself and the creature");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You carefully navigate through the undergrowth, seeking an alternative route");
                    Console.WriteLine("to bypass the Forest Dweller's territory.");
                    Console.WriteLine("After some time, you discover a hidden path veering to the right.");
                    Console.WriteLine("It seems less traveled and may offer a safer passage through the Dark Forest");
                    Console.ResetColor();
                    Console.ReadKey();
                }


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You decide to follow the wider, more traveled path to the right, hoping that it leads to a safer route through the Dark Forest.");
                Console.WriteLine("As you continue along the path, you notice faint signs of previous travelers- a broken branch, a print in the mud.");
                Console.WriteLine("It provides some reassurance that you are on the right track.");
                Console.WriteLine("As you walk, the forest seems to grow even darker, the trees looming closer together.");
                Console.WriteLine("Whispers and rustling sounds fill the air, making your heart race.");
                Console.ResetColor();
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Suddenly, you hear a low growl coming from the underbrush nearby.");
                Console.WriteLine("Before you can react, a pack of menacing wolves emerges from the shadows, their eyes gleaming with hunger.");
                Console.WriteLine("You must defend yourself against the wolves. Fortunately, you have your weapon handy.");
                Console.WriteLine("The pack encircles you, ready to attack.");
                Console.ResetColor();
                Console.ReadKey();

                Console.WriteLine("What will you do?");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1. Engage in a direct battle with the Wolves.");
                Console.WriteLine("2. Attempt to scare them off by brandishing your weapon");
                Console.ResetColor();
                Console.Write("Enter your choice here (1 or 2): ");
                var battleChoiceW = int.Parse(Console.ReadLine());

                Console.Clear();

                if (battleChoiceW == 1)
                {
                    StoryText.WolvesBattle();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You choose to attempt to scare off the wolves by brandishing your weapon.");
                    Console.WriteLine("You raise your weapon high in the air and let out a fierce battle cry");
                    Console.WriteLine("hoping to intimate the pack of wolves and make them think twice before attacking");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The wolves, momentarily taken aback by your display of aggression, hesitate.");
                    Console.WriteLine("Their growls soften, and a couple of them take a step back, unsure of whether to continue the attack.");
                    Console.WriteLine("You let out another battle cry.");
                    Console.WriteLine("The wolves retreat, scurrying back into the forest");
                }

            }
        }
        public static void StartDragonPeak1()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("You decide to ascend Dragon's peak, eager to face the challenge of the fearsome dragon that resides there.");
            Console.WriteLine("The old man nods gravely, cautioning you about the dangers that lie ahead.");
            Console.WriteLine("He directs you towards the rugged mountain trail that leads to the peak.");
            Console.WriteLine("As you make your way up the treacherous path, the air grows thinner, and the temperature drops.");
            Console.WriteLine("The terrain becomes steeper and more challenging with each step.");
            Console.WriteLine("Finally, after a long and arduous climb, you reach the summit of Dragon's Peak.");
            Console.ResetColor();
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Before you stands the fearsome dragon, its scales glistening in the sunlight.");
            Console.WriteLine("It lets out a deafening roar, shaking the very ground beneath you.");
            Console.WriteLine("The dragon's fiery breath engulfs the sky as it prepares to attack");
            Console.ResetColor();
            Console.ReadKey();

        }
        public static void DragonPeak2()
        {

        }
        public static void DarkForest2()
        {

        }
        public static void WolvesBattle()
        {
            //Main Character Stats - Warrior
            var warrior = new Warrior();
            warrior.Name = "Warrior";
            warrior.Health = 100;
            warrior.StrikeDmg = 10;
            warrior.StabDmg = 16;
            warrior.SlashDmg = 20;
            warrior.Stab = "Stab";
            warrior.Strike = "Strike";
            warrior.Slash = "Slash";
            //Main Character Stats - Ranger
            var ranger = new Ranger();
            ranger.Name = "Ranger";
            ranger.Health = 100;
            ranger.RegularArrow = "Regular Arrow";
            ranger.PoisonArrow = "Poison Arrow";
            ranger.FireArrow = "Fire Arrow";
            ranger.FireArrowDmg = 20;
            ranger.RegularArrowDmg = 10;
            ranger.PoisonArrowDmg = 16;
            //Main Character Stats - Sorcerer
            var sorcerer = new Sorcerer();
            sorcerer.Name = "Sorcerer";
            sorcerer.Health = 100;
            sorcerer.Health = 100;
            sorcerer.FireBall = "FireBall";
            sorcerer.FireBallDmg = 20;
            sorcerer.FrostBite = "FrostBite";
            sorcerer.FrostBiteDmg = 10;
            sorcerer.LightningBolt = "Lightning Bolt";
            sorcerer.LightningBoltDmg = 16;
            //Extra stats
            var mainCharacterHealth = 100;
            int damage = 0;

            //Wolves Dweller Stats
            var r = new Random();
            var wolvesHealth = 125;
            var wolvesAttack = r.Next(3, 7);





            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please select your class (1-3)");
            Console.WriteLine($"1.{warrior.Name}");
            Console.WriteLine($"2.{ranger.Name}");
            Console.WriteLine($"3.{sorcerer.Name}");

            var classChoice = int.Parse(Console.ReadLine());
            if (classChoice == 1)
            {
                Console.WriteLine($"You have chosen the {warrior.Name} class.");

            }
            else if (classChoice == 2)
            {
                Console.WriteLine($"You have chosen the {ranger.Name} class");
            }
            else
            {
                Console.WriteLine($"You have chosen the {sorcerer.Name} class.");

            }
            Console.ResetColor();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            while (wolvesHealth > 0 && mainCharacterHealth > 0)
            {
                if (classChoice == 1)
                {

                    Console.WriteLine($"{Character.Name}'s Health: {mainCharacterHealth}");
                    Console.WriteLine($"Wolves Health: {wolvesHealth}");
                    Console.WriteLine($"1. {warrior.Slash}");
                    Console.WriteLine($"2. {warrior.Stab}");
                    Console.WriteLine($"3. {warrior.Strike}");
                    Console.WriteLine("Choose your attack (1-3)");
                    var attackChoiceW = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------");

                    switch (attackChoiceW)
                    {
                        case 1:
                            damage = warrior.SlashDmg;
                            Console.WriteLine($"{Character.Name} uses {warrior.Slash} and does {warrior.SlashDmg} damage to Wolves");
                            break;
                        case 2:
                            damage = warrior.StabDmg;
                            Console.WriteLine($"{Character.Name} uses {warrior.Stab} and does {warrior.StabDmg} damage to Wolves");
                            break;
                        case 3:
                            damage = warrior.StrikeDmg;
                            Console.WriteLine($"{Character.Name} uses {warrior.Strike} and does {warrior.StrikeDmg} damage to Wolves");
                            break;
                    }
                    wolvesHealth -= damage;
                    if (wolvesHealth < 0)
                    {
                        Console.WriteLine("You defeated the Forest Dweller!");
                    }
                    mainCharacterHealth -= wolvesAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Forest Dweller");
                    }
                    Console.WriteLine($"The Wolves attacked and did {wolvesAttack} damage");
                }
                else if (classChoice == 2)
                {
                    Console.WriteLine($"{Character.Name}'s Health: {mainCharacterHealth}");
                    Console.WriteLine($"Wolves Health: {wolvesHealth}");
                    Console.WriteLine($"1. {ranger.FireArrow}");
                    Console.WriteLine($"2. {ranger.PoisonArrow}");
                    Console.WriteLine($"3. {ranger.RegularArrow}");
                    Console.WriteLine("Choose your attack (1-3)");
                    var attackChoiceR = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------");

                    switch (attackChoiceR)
                    {
                        case 1:
                            damage = ranger.FireArrowDmg;
                            Console.WriteLine($"{Character.Name} uses {ranger.FireArrow} and does {ranger.FireArrowDmg} damage to Wolves");
                            break;
                        case 2:
                            damage = ranger.PoisonArrowDmg;
                            Console.WriteLine($"{Character.Name} uses {ranger.PoisonArrow} and does {ranger.PoisonArrowDmg} damage to Wolves");
                            break;
                        case 3:
                            damage = ranger.RegularArrowDmg;
                            Console.WriteLine($"{Character.Name} uses {ranger.RegularArrow} and does {ranger.RegularArrowDmg} damage to Wolves");
                            break;

                    }
                    wolvesHealth -= damage;
                    if (wolvesHealth < 0)
                    {
                        Console.WriteLine("You defeated the Forest Dweller!");
                    }
                    mainCharacterHealth -= wolvesAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Forest Dweller");
                    }
                    Console.WriteLine($"The Wolves attacked and did {wolvesAttack} damage. ");

                }
                else
                {
                    Console.WriteLine($"{Character.Name}'s Health = {mainCharacterHealth}");
                    Console.WriteLine($"Wolves Health = {wolvesHealth}");
                    Console.WriteLine($"1. {sorcerer.FireBall}");
                    Console.WriteLine($"2. {sorcerer.LightningBolt}");
                    Console.WriteLine($"3. {sorcerer.FrostBite}");
                    Console.WriteLine("Choose your attack (1-3)");
                    var attackChoiceS = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------");

                    switch (attackChoiceS)
                    {
                        case 1:
                            damage = sorcerer.FireBallDmg;
                            Console.WriteLine($"{Character.Name} uses {sorcerer.FireBall} and does {sorcerer.FireBallDmg} damage to Wolves");
                            break;
                        case 2:
                            damage = sorcerer.LightningBoltDmg;
                            Console.WriteLine($"{Character.Name} uses {sorcerer.LightningBolt} and does {sorcerer.LightningBoltDmg} damage to Wolves");
                            break;
                        case 3:
                            damage = sorcerer.FrostBiteDmg;
                            Console.WriteLine($"{Character.Name} uses {sorcerer.FrostBite} and does {sorcerer.FrostBiteDmg} damage to Wolves");
                            break;


                    }
                    wolvesHealth -= damage;
                    if (wolvesHealth < 0)
                    {
                        Console.WriteLine("You defeated the Forest Dweller!");
                    }
                    mainCharacterHealth -= wolvesAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Forest Dweller");
                    }
                    Console.WriteLine($"The Wolves attacked and did {wolvesAttack} damage.");
                }

            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You emerged victorious in your battle with the Wolves!");
            Console.WriteLine("Take a moment to catch your breath and tend to any wounds.");
            Console.ResetColor();
        }
        public static void DragonBattle()
        {

        }
        public static void ForestDwellerBattle()
        {
            //Main Character Stats - Warrior
            var warrior = new Warrior();
            warrior.Name = "Warrior";
            warrior.Health = 100;
            warrior.StrikeDmg = 10;
            warrior.StabDmg = 16;
            warrior.SlashDmg = 20;
            warrior.Stab = "Stab";
            warrior.Strike = "Strike";
            warrior.Slash = "Slash";
            //Main Character Stats - Ranger
            var ranger = new Ranger();
            ranger.Name = "Ranger";
            ranger.Health = 100;
            ranger.RegularArrow = "Regular Arrow";
            ranger.PoisonArrow = "Poison Arrow";
            ranger.FireArrow = "Fire Arrow";
            ranger.FireArrowDmg = 20;
            ranger.RegularArrowDmg = 10;
            ranger.PoisonArrowDmg = 16;
            //Main Character Stats - Sorcerer
            var sorcerer = new Sorcerer();
            sorcerer.Name = "Sorcerer";
            sorcerer.Health = 100;
            sorcerer.Health = 100;
            sorcerer.FireBall = "FireBall";
            sorcerer.FireBallDmg = 20;
            sorcerer.FrostBite = "FrostBite";
            sorcerer.FrostBiteDmg = 10;
            sorcerer.LightningBolt = "Lightning Bolt";
            sorcerer.LightningBoltDmg = 16;
            //Extra stats
            var mainCharacterHealth = 100;
            int damage = 0;

            //Forest Dweller Stats
            var r = new Random();
            var forestDwellerHealth = 80;
            var forestDwellerAttack = r.Next(7, 15);
            



            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please select your class (1-3)");
            Console.WriteLine($"1.{warrior.Name}");
            Console.WriteLine($"2.{ranger.Name}");
            Console.WriteLine($"3.{sorcerer.Name}");

            var classChoice = int.Parse(Console.ReadLine());
            if (classChoice == 1)
            {
                Console.WriteLine($"You have chosen the {warrior.Name} class.");

            }
            else if (classChoice == 2)
            {
                Console.WriteLine($"You have chosen the {ranger.Name} class");
            }
            else
            {
                Console.WriteLine($"You have chosen the {sorcerer.Name} class.");

            }
            Console.ResetColor();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            while (forestDwellerHealth > 0 && mainCharacterHealth > 0)
            {
                if (classChoice == 1)
                {
                   
                    Console.WriteLine($"{Character.Name}'s Health: {mainCharacterHealth}");
                    Console.WriteLine($"Forest Dweller Health: {forestDwellerHealth}");
                    Console.WriteLine($"1. {warrior.Slash}");
                    Console.WriteLine($"2. {warrior.Stab}");
                    Console.WriteLine($"3. {warrior.Strike}");
                    Console.WriteLine("Choose your attack (1-3)");
                    var attackChoiceW = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------");

                    switch (attackChoiceW)
                    {
                        case 1:
                            damage = warrior.SlashDmg;
                            Console.WriteLine($"{Character.Name} uses {warrior.Slash} and does {warrior.SlashDmg} damage to Forest Dweller");
                            break;
                        case 2:
                            damage = warrior.StabDmg;
                            Console.WriteLine($"{Character.Name} uses {warrior.Stab} and does {warrior.StabDmg} damage to Forest Dweller");
                            break;
                        case 3:
                            damage = warrior.StrikeDmg;
                            Console.WriteLine($"{Character.Name} uses {warrior.Strike} and does {warrior.StrikeDmg} damage to Forest Dweller");
                            break;
                    }
                    forestDwellerHealth -= damage;
                    if (forestDwellerHealth < 0)
                    {
                        Console.WriteLine("You defeated the Forest Dweller!");
                    }
                    mainCharacterHealth -= forestDwellerAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Forest Dweller");
                    }
                    Console.WriteLine($"The forest Dweller attacked and did {forestDwellerAttack} damage");
                }
                else if (classChoice == 2)
                {
                    Console.WriteLine($"{Character.Name}'s Health: {mainCharacterHealth}");
                    Console.WriteLine($"Forest Dweller Health: {forestDwellerHealth}");
                    Console.WriteLine($"1. {ranger.FireArrow}");
                    Console.WriteLine($"2. {ranger.PoisonArrow}");
                    Console.WriteLine($"3. {ranger.RegularArrow}");
                    Console.WriteLine("Choose your attack (1-3)");
                    var attackChoiceR = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------");

                    switch (attackChoiceR)
                    {
                        case 1:
                            damage = ranger.FireArrowDmg;
                            Console.WriteLine($"{Character.Name} uses {ranger.FireArrow} and does {ranger.FireArrowDmg} damage to Forest Dweller");
                            break;
                        case 2:
                            damage = ranger.PoisonArrowDmg;
                            Console.WriteLine($"{Character.Name} uses {ranger.PoisonArrow} and does {ranger.PoisonArrowDmg} damage to Forest Dweller");
                            break;
                        case 3:
                            damage = ranger.RegularArrowDmg;
                            Console.WriteLine($"{Character.Name} uses {ranger.RegularArrow} and does {ranger.RegularArrowDmg} damage to Forest Dweller");
                            break;

                    }
                    forestDwellerHealth -= damage;
                    if (forestDwellerHealth < 0)
                    {
                        Console.WriteLine("You defeated the Forest Dweller!");
                    }
                    mainCharacterHealth -= forestDwellerAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Forest Dweller");
                    }
                    Console.WriteLine($"The forest Dweller attacked and did {forestDwellerAttack} damage. ");

                }
                else
                {
                    Console.WriteLine($"{Character.Name}'s Health = {mainCharacterHealth}");
                    Console.WriteLine($"Forest Dweller Health = {forestDwellerHealth}");
                    Console.WriteLine($"1. {sorcerer.FireBall}");
                    Console.WriteLine($"2. {sorcerer.LightningBolt}");
                    Console.WriteLine($"3. {sorcerer.FrostBite}");
                    Console.WriteLine("Choose your attack (1-3)");
                    var attackChoiceS = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------");

                    switch (attackChoiceS)
                    {
                        case 1:
                            damage = sorcerer.FireBallDmg;
                            Console.WriteLine($"{Character.Name} uses {sorcerer.FireBall} and does {sorcerer.FireBallDmg} damage to Forest Dweller");
                            break;
                        case 2:
                            damage = sorcerer.LightningBoltDmg;
                            Console.WriteLine($"{Character.Name} uses {sorcerer.LightningBolt} and does {sorcerer.LightningBoltDmg} damage to Forest Dweller");
                            break;
                        case 3:
                            damage = sorcerer.FrostBiteDmg;
                            Console.WriteLine($"{Character.Name} uses {sorcerer.FrostBite} and does {sorcerer.FrostBiteDmg} damage to Forest Dweller");
                            break;


                    }
                    forestDwellerHealth -= damage;
                    if (forestDwellerHealth < 0)
                    {
                        Console.WriteLine("You defeated the Forest Dweller!");
                    }
                    mainCharacterHealth -= forestDwellerAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Forest Dweller");
                    }
                    Console.WriteLine($"The forest Dweller attacked and did {forestDwellerAttack} damage.");
                }
                
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You emerged victorious in your battle with the Forest Dweller!");
            Console.WriteLine("Take a moment to catch your breath and tend to any wounds.");
            Console.ResetColor();


        }
        
    }
}










