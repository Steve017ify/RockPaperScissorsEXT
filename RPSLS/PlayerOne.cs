using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class PlayerOne : Player
    {
        public PlayerOne(string name) : base(name)
        {
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Which gesture would you like to play?");
            chosenGesture = Console.ReadLine();
        }
    }
}
