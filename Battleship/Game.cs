using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {
        // member variables
        public Player player1;
        public Player player2;
        public int numberOfPlayers;

        // constructors


        // member methods

        public void runGame()
        {
            DisplayRules();
            int numberOfPlayers = GetNumberOfPlayers();
            SetUpPlayers(numberOfPlayers);
            player1.ChooseName();
            player2.ChooseName();
        }
        public void DisplayRules()
        {
            Console.WriteLine("");
        }
        public int GetNumberOfPlayers()
        {
            Console.WriteLine("How many human players? Enter 1 or 2");
            while (int.TryParse(Console.ReadLine(), out numberOfPlayers) && numberOfPlayers > 2 || numberOfPlayers < 1)
            {
                Console.WriteLine("Please enter 1 or 2");
            }
            return numberOfPlayers;
        }
        public void SetUpPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new AI();
            }
            //else if(numberOfPlayers == 0) //cpu vs. cpu option, change GetNumberofPlayers low limit from 1 to 0
            //{
            //    player1 = new CPU();
            //    player2 = new CPU();
            //}
            else
            {
                player1 = new Human();
                player2 = new Human();
            }
        }
    }
}
