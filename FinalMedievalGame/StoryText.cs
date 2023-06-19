using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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
            Console.WriteLine("The first path is a challenging journey through the Dark Forest, rumored to be haunted by evil spirits.");
            Console.WriteLine("The second path is a perilous climb up the treacherous Dragon's Peak, where a fearsome dragon resides.");
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
            Console.ReadKey(); //TODO: Thread.Sleep()

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("As you make your way deeper into the forest, you come across a fork in the path.");
            Console.WriteLine("To your left, a narrow trail disappears into the dense undergrowth.");
            Console.WriteLine("To your right, a wider path seems more traveled.");
            Console.ResetColor();
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
            Console.WriteLine("What will you do?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Engage in a direct battle with the dragon");
            Console.WriteLine("2. Flee and take cover");
            Console.ResetColor();
            Console.Write("Enter your choice (1 or 2): ");
            var battleChoiceD = int.Parse(Console.ReadLine());

            Console.Clear();

            if (battleChoiceD == 1)
            {
                StoryText.DragonBattle();
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You decide to seek cover and prepare to flee the fearsome dragon.");
                Console.WriteLine("With quick thinking, you scan your surroundings for any available cover.");
                Console.WriteLine("Luck is on your side as you spot a large boulder nearby, providing solid cover");
                Console.WriteLine("from the dragon's fiery breath.");
                Console.WriteLine("You quickly take refuge behind it, shielded from the dragon's line of sight.");
                Console.ResetColor();
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The dragon loses sight of you.");
                Console.WriteLine("Frustrated, he lets out a mighty roar and takes flight leaving the immediate area.");
                Console.WriteLine("You are safe for now, but it is probably best to leave before it returns.");
                Console.ResetColor();

                Console.ReadKey();




            }
            StoryText.DragonPeak2();

        }
        public static void DragonPeak2()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("With the dragon gone, the air around Dragon's peak begins to clear");
            Console.WriteLine("and a sense of calm replaces the once fiery chaos.");
            Console.WriteLine("As you examine the area, you notice a gleaming treasure hoard nearby.");
            Console.ResetColor();
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Glittering gold coins, precious gemstones, and ancient artifacts are scattered amidst the dragon's lair.");
            Console.WriteLine("This could be your chance to claim a reward for your heroic feat");
            Console.ResetColor();
            Console.ReadKey();

            Console.WriteLine("Will you explore the dragon's treasure hoard?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Yes, delve into the treasure hoard and search for valuable loot.");
            Console.WriteLine("2. No, leave the dragon's lair and continue your journey");
            Console.ResetColor();

            Console.Write("Enter your choice 1 or 2: ");
            var choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                Console.Clear();


                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("With a glimmer of excitement in your eyes, you make your way towards the dragon's treasure hoard.");
                Console.WriteLine("The pile of riches is unlike anything you have ever seen before. ");
                Console.WriteLine("You carefully navigate through the scattered coins and gems, taking in the sight of wealth beyond imagination.");
                Console.ResetColor();
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("As you dig deeper into the hoard, your hands come across a beautifully crafted, jeweled amulet.");
                Console.WriteLine("Its intricate design catches your attention, and you can sense a mysterious power emanating from it.");
                Console.WriteLine("It seems to hold ancient knowledge and untapped potential.");
                Console.ResetColor();
                Console.ReadKey();
                Console.WriteLine("Do you choose to wear the amulet and unlock its secrets?");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1. Yes, put the amulet on and embrace its power.");
                Console.WriteLine("2. No, leave the amulet behind and continue your journey.");
                Console.ResetColor();
                Console.Write("What do you choose (1-2): ");

                var choiceA = int.Parse(Console.ReadLine());

                Console.Clear();

                if (choiceA == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You take a deep breath, steeling yourself for whatever consequences may arise,");
                    Console.WriteLine("and decide to put on the jeweled amulet.");
                    Console.WriteLine("As you place it around your neck, a surge of energy courses through your veins.");
                    Console.WriteLine("The amulet glows brightly, illuminating your surroundings with an intense light.");
                    Console.WriteLine("Suddenly, you feel a surge of power filling your body.");
                    Console.WriteLine("The power within the amulet flows through you, empowering your abilities and expanding your strength.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The amulet proves to be a powerful ally, helping you overcome adversaries that once seemed insurmountable.");
                    Console.WriteLine("However, its power comes with a price.");
                    Console.WriteLine("The more you rely on the amulet, the more it demands of you.");
                    Console.WriteLine("It drains your life force both physically and mentally");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.WriteLine("Will you continue to embrace the amulet's power, despite the toll it takes on you?");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1. Yes I will embrace the amulet's power no matter the cost");
                    Console.WriteLine("2. No, I will find a way to break free of the amulet's influence and rely on my own abilities.");
                    Console.ResetColor();
                    Console.Write("What will you choose (1-2): ");


                    

                    var choiceKeepA = int.Parse(Console.ReadLine());
                    
                    Console.Clear();

                    if (choiceKeepA == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You resolve to embrace the amulet's power, fully aware of the toll it may take on you.");
                        Console.WriteLine("With each passing day, you become more proficient in wielding the amulet's power.");
                        Console.WriteLine("However, the amulet's influence over you grows stronger, its power addictive");
                        Console.WriteLine("You realize soon, that its power is too much. You search for a way to relieve yourself of this curse.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("After searching, you find a way to no longer wield this mighty power.");
                        Console.WriteLine("To be free you must fight the otherworldly foe that is the Sorceress.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.ForegroundColor= ConsoleColor.Green;
                        StoryText.SorceressBattle();

                    }
                    else
                    {
                        Console.ForegroundColor= ConsoleColor.DarkYellow;
                        Console.WriteLine("You decide that the allure of the amulets power is not worth the risk of losing yourself entirely.");
                        Console.WriteLine("Determined to reclaim your own destiny, you resolve to reclaim your own destiny and find a way to be free yourself from its grasp");
                        Console.WriteLine("Your journey takes you to ancient libraries and forgotten realms.");
                        Console.WriteLine("You seek knowledge and guidance from those who have encountered similar artifacts.");
                        Console.WriteLine("Through countless trials and tribulations, you gather the necessary information and resources to break free of the amulet's hold.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("With unwavering determination, you confront the source of the amulet's enchantment.");
                        Console.WriteLine("To remove the amulet's burden, a climactic battle ensues, where you face the full force of the amulet's strength,");
                        Console.WriteLine("a powerful Sorceress");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        StoryText.SorceressBattle();


                    }
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You emerge victorious in your battle with the sorceress.");


                }
            }
            else
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You decide to leave the dragon's lair and continue your journey.");
                Console.WriteLine("While the allure of the treasure hoard is tempting, you remind yourself that your primary");
                Console.WriteLine("goal is not material wealth but the pursuit of adventure and fulfilling your quest.");
                Console.WriteLine("Leaving the dragon's lair behind, you venture further into the surrounding wilderness.");
                Console.WriteLine("The landscape is breathtaking, with towering mountains, lush forests, and meandering rivers.");
                Console.WriteLine("The path ahead is uncertain, but you are determined to press on.");
                Console.WriteLine("As you traverse through the wilderness, you encounter various challenges and obstacles.");
                Console.WriteLine("You face treacherous terrains, cunning creatures, and mysterious encounters.");
                Console.WriteLine("Each step brings you closer to your ultimate destination, where you believe your true destiny awaits.");
                Console.WriteLine("Finally, after a long and arduous journey, you arrive at the fabled City of Eldoria.");
                Console.WriteLine("The city stands as a beacon of civilization and knowledge, bustling with people from all walks of life.");
                Console.WriteLine("It is a hub of trade, culture, and ancient wisdom.");
                Console.ResetColor();
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("As you step into the city's grand gates, you feel a sense of accomplishment and anticipation.");
                Console.WriteLine("The journey has been long, but your quest is far from over.");
                Console.WriteLine("Here, in the City of Eldoria, you hope to find answers, allies, and the next chapter of your extraordinary adventure.");
                Console.WriteLine("What awaits you in the city of Eldoria? How will you navigate the intrigues and challenges that lie ahead?");
                Console.ResetColor();
            }
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





            
            

            Console.ForegroundColor = ConsoleColor.Green;
            while (wolvesHealth > 0 && mainCharacterHealth > 0)
            {
                if (Fighter.ClassChoice == 1)
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
                        Console.WriteLine("You defeated the Wolves!");
                    }
                    mainCharacterHealth -= wolvesAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Wolves");
                    }
                    Console.WriteLine($"The Wolves attacked and did {wolvesAttack} damage");
                }
                else if (Fighter.ClassChoice == 2)
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
                        Console.WriteLine("You defeated the Wolves!");
                    }
                    mainCharacterHealth -= wolvesAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Wolves");
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
                        Console.WriteLine("You defeated the Wolves!");
                    }
                    mainCharacterHealth -= wolvesAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Wolves");
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

            //Dragon Stats
            var r = new Random();
            var dragonHealth = 50;
            var dragonAttack = r.Next(15, 20);





            
            
            Console.ForegroundColor = ConsoleColor.Green;
            while (dragonHealth > 0 && mainCharacterHealth > 0)
            {
                if (Fighter.ClassChoice == 1)
                {

                    Console.WriteLine($"{Character.Name}'s Health: {mainCharacterHealth}");
                    Console.WriteLine($"Dragon Health: {dragonHealth}");
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
                            Console.WriteLine($"{Character.Name} uses {warrior.Slash} and does {warrior.SlashDmg} damage to Dragon");
                            break;
                        case 2:
                            damage = warrior.StabDmg;
                            Console.WriteLine($"{Character.Name} uses {warrior.Stab} and does {warrior.StabDmg} damage to Dragon");
                            break;
                        case 3:
                            damage = warrior.StrikeDmg;
                            Console.WriteLine($"{Character.Name} uses {warrior.Strike} and does {warrior.StrikeDmg} damage to Dragon");
                            break;
                    }
                    dragonHealth -= damage;
                    if (dragonHealth < 0)
                    {
                        Console.WriteLine("You defeated the Dragon!");
                    }
                    mainCharacterHealth -= dragonAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Dragon");
                    }
                    Console.WriteLine($"The Dragon attacked and did {dragonAttack} damage");
                }
                else if (Fighter.ClassChoice == 2)
                {
                    Console.WriteLine($"{Character.Name}'s Health: {mainCharacterHealth}");
                    Console.WriteLine($"Dragon Health: {dragonHealth}");
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
                            Console.WriteLine($"{Character.Name} uses {ranger.FireArrow} and does {ranger.FireArrowDmg} damage to Dragon");
                            break;
                        case 2:
                            damage = ranger.PoisonArrowDmg;
                            Console.WriteLine($"{Character.Name} uses {ranger.PoisonArrow} and does {ranger.PoisonArrowDmg} damage to Dragon");
                            break;
                        case 3:
                            damage = ranger.RegularArrowDmg;
                            Console.WriteLine($"{Character.Name} uses {ranger.RegularArrow} and does {ranger.RegularArrowDmg} damage to Dragon");
                            break;

                    }
                    dragonHealth -= damage;
                    if (dragonHealth < 0)
                    {
                        Console.WriteLine("You defeated the Dragon!");
                    }
                    mainCharacterHealth -= dragonAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Dragon");
                    }
                    Console.WriteLine($"The Dragon attacked and did {dragonAttack} damage. ");

                }
                else
                {
                    Console.WriteLine($"{Character.Name}'s Health = {mainCharacterHealth}");
                    Console.WriteLine($"Dragon Health = {dragonHealth}");
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
                            Console.WriteLine($"{Character.Name} uses {sorcerer.FireBall} and does {sorcerer.FireBallDmg} damage to Dragon");
                            break;
                        case 2:
                            damage = sorcerer.LightningBoltDmg;
                            Console.WriteLine($"{Character.Name} uses {sorcerer.LightningBolt} and does {sorcerer.LightningBoltDmg} damage to Dragon");
                            break;
                        case 3:
                            damage = sorcerer.FrostBiteDmg;
                            Console.WriteLine($"{Character.Name} uses {sorcerer.FrostBite} and does {sorcerer.FrostBiteDmg} damage to Dragon");
                            break;


                    }
                    dragonHealth -= damage;
                    if (dragonHealth < 0)
                    {
                        Console.WriteLine("You defeated the Dragon!");
                    }
                    mainCharacterHealth -= dragonAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Dragon");
                    }
                    Console.WriteLine($"The Dragon attacked and did {dragonAttack} damage.");
                }

            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You emerged victorious in your battle with the Dragon!");
            Console.WriteLine("Take a moment to catch your breath and tend to any wounds.");
            Console.ResetColor();
            Console.WriteLine("PRESS ENTER TO VIEW INVENTORY");
            Console.ResetColor();
            Console.ReadKey();
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.Write("1. View Inventory: ");
            Console.ResetColor();
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Potion.ViewInventory();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection.");
                        break;
                }
            }
            
            var usePotion = Console.ReadLine();

            if (int.TryParse(usePotion, out int choice2))
            {
                Potion.RemovePotion();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
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




           
            Console.ResetColor();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            while (forestDwellerHealth > 0 && mainCharacterHealth > 0)
            {
                if (Fighter.ClassChoice == 1)
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
                else if (Fighter.ClassChoice == 2)
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
        public static void Eldoria()
        {

        }
        public static void SorceressBattle()
        {
            //Main Character Stats - Warrior
            var warrior = new Warrior();
            warrior.Name = "Warrior";
            warrior.Health = 75;
            warrior.StrikeDmg = 25;
            warrior.StabDmg = 15;
            warrior.SlashDmg = 21;
            warrior.Stab = "Stab";
            warrior.Strike = "Strike";
            warrior.Slash = "Slash";
            //Main Character Stats - Ranger
            var ranger = new Ranger();
            ranger.Name = "Ranger";
            ranger.Health = 75;
            ranger.RegularArrow = "Regular Arrow";
            ranger.PoisonArrow = "Poison Arrow";
            ranger.FireArrow = "Fire Arrow";
            ranger.FireArrowDmg = 25;
            ranger.RegularArrowDmg = 15;
            ranger.PoisonArrowDmg = 21;
            //Main Character Stats - Sorcerer
            var sorcerer = new Sorcerer();
            sorcerer.Name = "Sorcerer";
            sorcerer.Health = 75;
            sorcerer.FireBall = "FireBall";
            sorcerer.FireBallDmg = 25;
            sorcerer.FrostBite = "FrostBite";
            sorcerer.FrostBiteDmg = 15;
            sorcerer.LightningBolt = "Lightning Bolt";
            sorcerer.LightningBoltDmg = 21;
            //Extra stats
            var mainCharacterHealth = 75;
            int damage = 0;

            //Forest Dweller Stats
            var r = new Random();
            var sorceressHealth = 100;
            var sorceressAttack = r.Next(7, 10);





            Console.ResetColor();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            while (sorceressHealth > 0 && mainCharacterHealth > 0)
            {
                if (Fighter.ClassChoice == 1)
                {

                    Console.WriteLine($"{Character.Name}'s Health: {mainCharacterHealth}");
                    Console.WriteLine($"Sorceress Health: {sorceressHealth}");
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
                            Console.WriteLine($"{Character.Name} uses {warrior.Slash} and does {warrior.SlashDmg} damage to Sorceress");
                            break;
                        case 2:
                            damage = warrior.StabDmg;
                            Console.WriteLine($"{Character.Name} uses {warrior.Stab} and does {warrior.StabDmg} damage to Sorceress");
                            break;
                        case 3:
                            damage = warrior.StrikeDmg;
                            Console.WriteLine($"{Character.Name} uses {warrior.Strike} and does {warrior.StrikeDmg} damage to Sorceress");
                            break;
                    }
                    sorceressHealth -= damage;
                    if (sorceressHealth < 0)
                    {
                        Console.WriteLine("You defeated the Sorceress!");
                    }
                    mainCharacterHealth -= sorceressAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Sorceress");
                    }
                    Console.WriteLine($"The Sorceress attacked and did {sorceressAttack} damage");
                }
                else if (Fighter.ClassChoice == 2)
                {
                    Console.WriteLine($"{Character.Name}'s Health: {mainCharacterHealth}");
                    Console.WriteLine($"Sorceress Health: {sorceressHealth}");
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
                            Console.WriteLine($"{Character.Name} uses {ranger.FireArrow} and does {ranger.FireArrowDmg} damage to Sorceress");
                            break;
                        case 2:
                            damage = ranger.PoisonArrowDmg;
                            Console.WriteLine($"{Character.Name} uses {ranger.PoisonArrow} and does {ranger.PoisonArrowDmg} damage to Sorceress");
                            break;
                        case 3:
                            damage = ranger.RegularArrowDmg;
                            Console.WriteLine($"{Character.Name} uses {ranger.RegularArrow} and does {ranger.RegularArrowDmg} damage to Sorceress");
                            break;

                    }
                    sorceressHealth -= damage;
                    if (sorceressHealth < 0)
                    {
                        Console.WriteLine("You defeated the Sorceress!");
                    }
                    mainCharacterHealth -= sorceressAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Sorceress");
                    }
                    Console.WriteLine($"The Sorceress attacked and did {sorceressAttack} damage. ");

                }
                else
                {
                    Console.WriteLine($"{Character.Name}'s Health = {mainCharacterHealth}");
                    Console.WriteLine($"Sorceress Health = {sorceressHealth}");
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
                            Console.WriteLine($"{Character.Name} uses {sorcerer.FireBall} and does {sorcerer.FireBallDmg} damage to Sorceress");
                            break;
                        case 2:
                            damage = sorcerer.LightningBoltDmg;
                            Console.WriteLine($"{Character.Name} uses {sorcerer.LightningBolt} and does {sorcerer.LightningBoltDmg} damage to Sorceress");
                            break;
                        case 3:
                            damage = sorcerer.FrostBiteDmg;
                            Console.WriteLine($"{Character.Name} uses {sorcerer.FrostBite} and does {sorcerer.FrostBiteDmg} damage to Sorceress");
                            break;


                    }
                    sorceressHealth -= damage;
                    if (sorceressHealth < 0)
                    {
                        Console.WriteLine("You defeated the Sorceress!");
                    }
                    mainCharacterHealth -= sorceressAttack;

                    if (mainCharacterHealth < 0)
                    {
                        Console.WriteLine("You were defeated by the Sorceress");
                    }
                    Console.WriteLine($"The Sorceress attacked and did {sorceressAttack} damage.");
                }

            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You emerged victorious in your battle with the Sorceress!");
            Console.WriteLine("Take a moment to catch your breath and tend to any wounds.");
            Console.ResetColor();

        }
        public static int GetClass()
        {
            Warrior warrior = new Warrior();
            warrior.Name= "Warrior";
            Ranger ranger = new Ranger();
            ranger.Name = "Ranger";
            Sorcerer sorcerer = new Sorcerer();
            sorcerer.Name = "Sorcerer";




            Console.ResetColor();
            Console.WriteLine("Please select your class (1-3)");
            Console.WriteLine($"1.{warrior.Name}");
            Console.WriteLine($"2.{ranger.Name}");
            Console.WriteLine($"3.{sorcerer.Name}");

            var classChoice = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.ResetColor();
            
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



            return classChoice;

        }
    }
    
}










