﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    struct Item
    {
        public string name;
        public string type;
        public int statBoost;
    }
    class Game
    {
        private bool _gameOver = false;
        private Entity _player1;
        private Item _sword;
        private Item _dagger;
        private Item _nuke;
        private Item _cherrybomb;
        private Item _bow;
        private Item _crossbow;
        private Item _medevilShield;
        private Item _modernSheild;
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

            _dagger.name = "dagger";
            _dagger.type = "weapon";
            _dagger.statBoost = 10;

            _nuke.name = "nuke";
            _nuke.type = "weapon";
            _nuke.statBoost = 10;

            _cherrybomb.name = "cherrybomb";
            _cherrybomb.type = "weapon";
            _cherrybomb.statBoost = 10;

            _bow.name = "bow";
            _bow.type = "weapon";
            _bow.statBoost = 10;

            _crossbow.name = "crossbow";
            _crossbow.type = "weapon";
            _crossbow.statBoost = 10;

            _medevilShield.name = "old shield";
            _medevilShield.type = "shield";
            _medevilShield.statBoost = 10;

            _modernSheild.name = "blocker";
            _modernSheild.type = "shield";
            _modernSheild.statBoost = 10;

            _poision.name = "poision";
            _poision.type = "potion";
            _poision.statBoost = 10;

            _lightning.name = "lightning";
            _lightning.type = "potion";
            _lightning.statBoost = 10;
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
                            _player1 = new Player(name, 100, 10, 3);
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
            GetInput(out input, "yes", "no", "do you need a tutorial?");
            if(input == '1')
            {
                Tutorial();
            }

        }
        //tell  you how to play the game
        public void Tutorial()
        {
            Console.WriteLine("you enter a room bright with an enemy on the other side");
            Console.WriteLine("you get to select a loadout that has three classes of items");
            Console.WriteLine("potion/weapon/shield");
            Console.WriteLine("starting with basic stats boost per item");
        }
        //gives the player the option to select a basic loadout
        public void SelectLoadout()
        {
             
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
