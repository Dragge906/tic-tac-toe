using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        //hämtar in alla klasser och skapar en lista
        private HumanPlayer humanPlayer;
        private ComputerPlayer computerPlayer;
        private Player currantPlayer;
        private Button button;
        private List<Button> availableButtons;
        

        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Visible = false; //gömmer spelbrädet när programmet startas
            availableButtons = new List<Button>(); //initierar listan med tillgängliga knappar
        }
        public void Reset()
        {
            foreach (Control control in tableLayoutPanel1.Controls) //fick iden från https://stackoverflow.com/questions/42821682/foreach-loop-of-controls-in-tablelayoutpanel-c-winforms och sen efter att ha kollat runt lite så fattade jag att ctrl var en from av variabel som jag kunde använda för att deklarera vad den skulle kontrollera
            {
                if (control is Button button) //om kontroll är en knapp
                {

                    button.Text = "";//nollställer texten
                    button.Enabled = true;//aktiverar knappen
                    availableButtons.Add(button);//lägger till knappen i listan
                }
            }
        }
        public Button Random()
        {
            {
                Random rnd = new Random();//skapar en slumpgenerator
                foreach (Control control in tableLayoutPanel1.Controls)//kollar igenom alla kontroller i tablelayoutpanel
                {
                    if (control is Button button && button.Enabled)//kollar om kontroll är en aktiverad knapp
                {
                    availableButtons.Add(button);//lägg då till i listan
                    }
            }

            Button chosenButton = availableButtons[rnd.Next(0, availableButtons.Count)];//välj en slumpmässig knapp från listan
            return chosenButton;//skicka tillbaka den knappen
        }
}
private void PlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//knappen som ska tryckas på efter man har fyllt i sitt namn
        {
            var playerName = PlayerName.Text.Trim();//hämtar och trimmar namnet som fyldes i
            if (string.IsNullOrEmpty(playerName))//kolla om det är tomt i namnrutan
            {
                MessageBox.Show("Please enter a name for Player.");
                return;//skicka då tillbaka med detta meddelande
            }
            //tar sen fram spelbrädet och bort med namn rutan och startknappen
            PlayerName.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            tableLayoutPanel1.Visible = true;
            humanPlayer = new HumanPlayer(PlayerName.Text);
            computerPlayer = new ComputerPlayer("Computer");
            currantPlayer = humanPlayer;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (currantPlayer is HumanPlayer)
            {
                button2.Text = "O";
                currantPlayer = computerPlayer;
            }
            else if (currantPlayer is ComputerPlayer)
            {
                button2.Text = "X";
                currantPlayer = humanPlayer;
            }
            button2.Enabled = false;
            Console.WriteLine(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currantPlayer is HumanPlayer)
            {
                button3.Text = "O";
                currantPlayer = computerPlayer;
            }
            else if (currantPlayer is ComputerPlayer)
            {
                button3.Text = "X";
                currantPlayer = humanPlayer;
            }
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currantPlayer is HumanPlayer)
            {
                button4.Text = "O";
                currantPlayer = computerPlayer;
            }
            else if (currantPlayer is ComputerPlayer)
            {
                button4.Text = "X";
                currantPlayer = humanPlayer;
            }
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (currantPlayer is HumanPlayer)
            {
                button5.Text = "O";
                currantPlayer = computerPlayer;
            }
            else if (currantPlayer is ComputerPlayer)
            {
                button5.Text = "X";
                currantPlayer = humanPlayer;
            }
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (currantPlayer is HumanPlayer)
            {
                button6.Text = "O";
                currantPlayer = computerPlayer;
            }
            else if (currantPlayer is ComputerPlayer)
            {
                button6.Text = "X";
                currantPlayer = humanPlayer;
            }
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                clickedButton.ButtonClick();//allt här handlar om att konvertera klassen och sen se om den lyckades därmed kalla på funktionen
            }
        }//fick ideen från https://www.codeproject.com/Questions/493301/canplussomeoneplusexplainplusthispluscode-3fplusBu men utvecklade den sedan baserat på 50 felkoder

        private void button8_Click(object sender, EventArgs e)
        {
            if (currantPlayer is HumanPlayer)
            {
                button8.Text = "O";
                currantPlayer = computerPlayer;
            }
            else if (currantPlayer is ComputerPlayer)
            {
                button8.Text = "X";
                currantPlayer = humanPlayer;
            }
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (currantPlayer is HumanPlayer)
            {
                button9.Text = "O";
                currantPlayer = computerPlayer;
            }
            else if (currantPlayer is ComputerPlayer)
            {
                button9.Text = "X";
                currantPlayer = humanPlayer;
            }
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (currantPlayer is HumanPlayer)
            {
                button10.Text = "O";
                currantPlayer = computerPlayer;
            }
            else if (currantPlayer is ComputerPlayer)
            {
                button10.Text = "X";
                currantPlayer = humanPlayer;
            }
            button10.Enabled = false;
        }
 
    }
}
