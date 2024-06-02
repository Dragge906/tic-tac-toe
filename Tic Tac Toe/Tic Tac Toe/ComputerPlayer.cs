using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    internal class ComputerPlayer: Player
    {
        //hämtar klasser
        private Form1 form;
        private Button button;
        public ComputerPlayer(string name) : base(name) { }//konsturktor
        public void MakeRandomMove()
        {
            Button randomButton = form.Random();//hämtar in knappen som valdes från random funktionen
            if (randomButton != null)//om den funkar så tryck den med funktionen som ligger i knapp funktionen
            {
                randomButton.ButtonClick();
            }
        }
    }
}
