using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public class Button : System.Windows.Forms.ButtonBase // fick från https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.button?view=windowsdesktop-8.0
    {
        //hämtar in klasser och array för brädet
        private HumanPlayer humanPlayer;
        private ComputerPlayer computerPlayer;
        private Player currantPlayer;
        private TableLayoutPanel tableLayoutPanel1;
        private int[,] board;//fick från koden i https://stackoverflow.com/questions/21369135/tic-tac-toe-help-determine-winner
        private System.Windows.Forms.Button button;
        private Form1 form;

        public Button(System.Windows.Forms.Button button)//konstruktor för knappen
        {
            this.button = button;
        }


        public void ButtonClick()
        {
            //beräknar rad och kolum för knappen
            int row = this.TabIndex / 3;
            int column = this.TabIndex % 3;
            if (currantPlayer is HumanPlayer)
            {
                this.Text = "O";//byter text så det ska vara enkelt att se vem som tryckt på vad
                board[row, column] = 1;//markerar själva brädet för att kunna använda checkwinner 
                if (checkWinner(1, tableLayoutPanel1))//koller om den knappen var en vinnare och sen om det är så då nollställs brädet och ett meddelande om att spelaren vann
                {
                    MessageBox.Show("{PlayerName.Text} Wins!");
                    form.Reset();
                }
                else currantPlayer = computerPlayer;
            }
            else if (currantPlayer is ComputerPlayer)
            {
                this.Text = "X";
                board[row, column] = 2;
                if (checkWinner(2, tableLayoutPanel1))
                {
                    MessageBox.Show("Computer Wins!");
                    form.Reset();
                }
                else currantPlayer = humanPlayer;
            }
        this.Enabled = false;
    }
        public bool checkWinner(int currantPlayer, TableLayoutPanel tableLayoutPanel1)
        {

            //check rows
            if (board[0, 0] == currantPlayer && board[0, 1] == currantPlayer && board[0, 2] == currantPlayer) { return true; }
            if (board[1, 0] == currantPlayer && board[1, 1] == currantPlayer && board[1, 2] == currantPlayer) { return true; }
            if (board[2, 0] == currantPlayer && board[2, 1] == currantPlayer && board[2, 2] == currantPlayer) { return true; }

            // check columns
            if (board[0, 0] == currantPlayer && board[1, 0] == currantPlayer && board[2, 0] == currantPlayer) { return true; }
            if (board[0, 1] == currantPlayer && board[1, 1] == currantPlayer && board[2, 1] == currantPlayer) { return true; }
            if (board[0, 2] == currantPlayer && board[1, 2] == currantPlayer && board[2, 2] == currantPlayer) { return true; }

            //check diags
            if (board[0, 0] == currantPlayer && board[1, 1] == currantPlayer && board[2, 2] == currantPlayer) { return true; }
            if (board[0, 2] == currantPlayer && board[1, 1] == currantPlayer && board[2, 0] == currantPlayer) { return true; }

            return false; // fick checkwinner från en kommentar på hemsidan https://stackoverflow.com/questions/21369135/tic-tac-toe-help-determine-winner
        }

}
}