using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{
    struct Item
    {
        public string name;
        public string type;
        public int statBoost;
        public int cost;
        public int level;
    }
    class Game
    {
        private bool _gameOver = false;
        private Entity _player1;
        private Entity _enemy;
        private Item _sword;
        private Item _dagger;
        private Item _nuke;
        private Item _cherryBomb;
        private Item _bow;
        private Item _crossBow;
        private Item _medevilShield;
        private Item _modernShield;
        private Item _poision;
        private Item _lightning;

        //Run the game
        public void Run()
        {
            Start();
            while(_gameOver == false)
            {
                Update();
            }
            End();
        }

        //possible ways to take ask a question for the user and return input
        public void GetInput(out char input, string option1, string option2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.Write("> ");

            input = ' ';
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input != '1' && input != '2')
                {
                    Console.WriteLine("invalid input!");
                }
            }
        }
        public void GetInput(out char input, string option1, string option2, string option3, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.WriteLine("3." + option3);
            Console.Write("> ");

            input = ' ';
            while (input != '1' && input != '2' && input != '3')
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input != '1' && input != '2' && input != '3')
                {
                    Console.WriteLine("invalid input!");
                }
            }
        }
        public void GetInput(out char input, string option1, string option2, string option3, string query, bool messUp)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.WriteLine("3." + option3);
            Console.Write("> ");

            input = ' ';
            if (messUp == false)
            {
                while (input != '1' && input != '2' && input != '3')
                {
                    input = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (input != '1' && input != '2' && input != '3')
                    {
                        Console.WriteLine("invalid input!");
                    }
                }
            }
            else
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
        }
        public void GetInput(out char input, string option1, string option2, string option3, string option4, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.WriteLine("3." + option3);
            Console.WriteLine("4." + option4);
            Console.Write("> ");

            input = ' ';
            while (input != '1' && input != '2' && input != '3' && input != '4')
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input != '1' && input != '2' && input != '3' && input != '4')
                {
                    Console.WriteLine("invalid input!");
                }
            }
        }
        public void GetInput(out char input, string option1, string option2, string option3, string option4, string query, bool messUp)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.WriteLine("3." + option3);
            Console.WriteLine("4." + option4);
            Console.Write("> ");

            input = ' ';
            if (messUp == false)
            {
                while (input != '1' && input != '2' && input != '3' && input != '4')
                {
                    input = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (input != '1' && input != '2' && input != '3' && input != '4')
                    {
                        Console.WriteLine("invalid input!");
                    }
                }
            }
            else
            {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
        }

        public void InitItems()
        {
            _sword.name = "sword";
            _sword.type = "weapon";
            _sword.statBoost = 10;
            _sword.cost = 5;
            _sword.level = 1;

            _dagger.name = "dagger";
            _dagger.type = "weapon";
            _dagger.statBoost = 10;
            _dagger.cost = 5;
            _dagger.level = 1;

            _nuke.name = "nuke";
            _nuke.type = "weapon";
            _nuke.statBoost = 10;
            _nuke.cost = 5;
            _nuke.level = 1;

            _cherryBomb.name = "cherrybomb";
            _cherryBomb.type = "weapon";
            _cherryBomb.statBoost = 10;
            _cherryBomb.cost = 5;
            _cherryBomb.level = 1;

            _bow.name = "bow";
            _bow.type = "weapon";
            _bow.statBoost = 10;
            _bow.cost = 5;
            _bow.level = 1;

            _crossBow.name = "crossbow";
            _crossBow.type = "weapon";
            _crossBow.statBoost = 10;
            _crossBow.cost = 5;
            _crossBow.level = 1;

            _medevilShield.name = "old shield";
            _medevilShield.type = "shield";
            _medevilShield.statBoost = 10;
            _medevilShield.cost = 5;
            _medevilShield.level = 1;

            _modernShield.name = "blocker";
            _modernShield.type = "shield";
            _modernShield.statBoost = 10;
            _modernShield.cost = 5;
            _modernShield.level = 1;

            _poision.name = "poision";
            _poision.type = "potion";
            _poision.statBoost = 10;
            _poision.cost = 5;
            _poision.level = 1;

            _lightning.name = "lightning";
            _lightning.type = "potion";
            _lightning.statBoost = 10;
            _lightning.cost = 5;
            _lightning.level = 1;
        }

        public Entity GenEnemy()
        {

            return _enemy = new Entity();
        }

        //give user instructions 
        public void Intro()
        {
            string name;
            char input = ' ';
            Console.WriteLine("Good morning and welcome");
            Console.WriteLine("let's start with introductions!");
            Console.WriteLine("What's your name traveler?");
            name = Console.ReadLine();
            while(input != '1')
            {
                GetInput(out input, "yes", "change it", "do you want to keep this name");
                switch (input)
                {
                    case '1':
                        {
                            Console.WriteLine("your forever name will be " + name + "!");
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("Alright lets change that name of yours");
                            break;
                        }
                }
            }
            Console.WriteLine("thank you for coming " + name );
            Console.WriteLine("now lets get to it!");
            Console.WriteLine("whole objective survive if you die gameover");
            GetInput(out input, "tutorial", "new game","continue", "what to do?");
            if(input == '1')
            {
                Tutorial();
            }
            else if(input == '2')
            {
                _player1 = new Player(name, 100, 10, 10, 3);
                SelectLoadout((Player)_player1);
            }
            else
            {
                Load();
            }

        }
        //tell  you how to play the game
        public void Tutorial()
        {
            Console.WriteLine("you enter a room bright with an enemy on the other side");
            Console.WriteLine("you get to select a loadout that has three classes of items");
            Console.WriteLine("potion/weapon/shield");
            Console.WriteLine("starting with basic stats boost per item");
            Battle(GenEnemy());
        }

        public void Battle(Entity enemy)
        {
            Console.WriteLine("you spot an enemy!");
            if ()
            {

            }
            while(_player1.IsAlive() && enemy.IsAlive())
            {

            }
        }

        public void Explore()
        {
            
        }

        //gives the player the option to select a basic loadout
        public void SelectLoadout(Player player)
        {
            Console.Clear();
            Console.WriteLine("Loadout 1: ");
            Console.WriteLine(_crossBow.name);
            Console.WriteLine(_medevilShield.name);
            Console.WriteLine(_poision.name);
            Console.WriteLine();
            Console.WriteLine("Loadout 2: ");
            Console.WriteLine(_bow.name);
            Console.WriteLine(_modernShield.name);
            Console.WriteLine(_lightning);
            Console.WriteLine();
            Console.WriteLine("Loadout 3: ");
            Console.WriteLine(_sword.name);
            Console.WriteLine(_medevilShield.name);
            Console.WriteLine(_cherryBomb.name);
            Console.WriteLine();
            Console.WriteLine("Loadout 4:");
            Console.WriteLine(_dagger.name);
            Console.WriteLine(_modernShield.name);
            Console.WriteLine(_nuke.name);
            char input;
            GetInput(out input, "loadout 1", "loadout 2","loadout 3","loadout 4", "choose your weapon!");
            if (input == '1')
            {
                player.AddItemToInv(_crossBow, 0);
                player.AddItemToInv(_medevilShield, 1);
                player.AddItemToInv(_poision, 2);
            }
            else if (input == '2')
            {
                player.AddItemToInv(_bow, 0);
                player.AddItemToInv(_modernShield, 1);
                player.AddItemToInv(_lightning, 2);
            }
            else if (input == '3')
            {
                player.AddItemToInv(_sword, 0);
                player.AddItemToInv(_medevilShield, 1);
                player.AddItemToInv(_cherryBomb, 2);
            }
            else if (input == '4')
            {
                player.AddItemToInv(_dagger, 0);
                player.AddItemToInv(_modernShield, 1);
                player.AddItemToInv(_nuke, 2);
            }
            Console.WriteLine("player " + player.GetName());
            player.PrintStats();
            Console.ReadKey();
            Console.Clear();
        }

        public void Save()
        {
            StreamWriter writer = new StreamWriter("SaveData.txt");
            _player1.Save(writer);
            writer.Close();
        }

        public void Load()
        {
            StreamReader reader = new StreamReader("SaveData.txt");
            _player1.load(reader);
            reader.Close();
        }

        //Performed once when the game begins
        public void Start()
        {
            InitItems();
            Intro();
        }

        //Repeated until the game ends
        public void Update()
        {
            
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
