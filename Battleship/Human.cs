using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Human : Player
    {
        // member variables

        // constructors

        // member methods
        public override string ChooseName()
        {
            Console.WriteLine("Choose name");
            name = Console.ReadLine();
            return name;
        }
    }

}
