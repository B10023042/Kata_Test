using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class CellOfConway
    {
        public StateOfCell CheckCheckState(StateOfCell state, int amoutOfAliveNeighbours)
        {
            if (state == StateOfCell.Dead)
            {
                return (amoutOfAliveNeighbours == 3) ? StateOfCell.Alive : StateOfCell.Dead;
            }

            return (amoutOfAliveNeighbours < 2) ? StateOfCell.Dead :
                (amoutOfAliveNeighbours < 4) ? StateOfCell.Alive : StateOfCell.Dead;


        }
    }

    public enum StateOfCell
    {
        Dead, Alive
    }
}
