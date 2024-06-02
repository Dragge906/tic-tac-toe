using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class Player
    {
        internal string Symbol { get; }//lagrar spelarens symbol

        public Player(string symbol)//konstruktor för symbol
        {
            Symbol = symbol;
        }
    }
}

