using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variables (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {
            int playerOneScore = 0;
            int playerTwoScore = 0;
            new Random();
        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n" +
                "Scissors cut paper\n" +
                "Paper covers rock\n" +
                "Rock breaks scissors\n" +
                "Rock crushes lizard\n" +
                "Lizard poisons Spock\n" +
                "Spock smashes scissors\n" +
                "Scissors decapitates lizard\n" +
                "Lizard eats paper\n" +
                "Paper disproves Spock\n" +
                "Spock vaporizes rock\n" +
                "The 1st to 2 wins is the champion.");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("How many human players will participate?");
            string humanPlayers = Console.ReadLine();
            int officialPlayers = int.Parse(humanPlayers);
            return officialPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            playerOne = new PlayerOne("John");
        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
        }
    }
}
