using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BomberMan
{
    public partial class Menu : Form
    {
        public int NumberOfPlayers {set; get;}
        public string[] names;
        public Menu()
        {
            InitializeComponent();
            NumberOfPlayers = 2;
            names = new string[2];
            names[0] = "Player1";
            names[1] = "Player2";
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.DarkCyan;
            Cursor = Cursors.Hand;
            
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.BurlyWood;
            Cursor = DefaultCursor;
            
        }

        private void btnScore_MouseHover(object sender, EventArgs e)
        {
            btnScore.BackColor = Color.DarkCyan;
            Cursor = Cursors.Hand;
        }

        private void btnScore_MouseLeave(object sender, EventArgs e)
        {
            btnScore.BackColor = Color.BurlyWood;
            Cursor = DefaultCursor;
        }
        private void btnOptions_MouseHover(object sender, EventArgs e)
        {
            btnOptions.BackColor = Color.DarkCyan;
            Cursor = Cursors.Hand;
        }
        private void btnOptions_MouseLeave(object sender, EventArgs e)
        {
            btnOptions.BackColor = Color.BurlyWood;
            Cursor = DefaultCursor;

        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.BurlyWood;
            Cursor = DefaultCursor;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.DarkCyan;
            Cursor = Cursors.Hand;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame newGame = new StartGame(NumberOfPlayers, names);
            newGame.ShowDialog();
             
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pMenu.Visible = true;
            pOption.Visible = false;
           
        }

        private void btnSingle_MouseHover(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.DarkCyan;
            Cursor = Cursors.Hand;
        }

        private void btnSingle_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.BurlyWood;
            Cursor = DefaultCursor;
        }
        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.DarkCyan;
            Cursor = Cursors.Hand;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.BurlyWood;
            Cursor = DefaultCursor;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            pOption.Visible = true;
            pMenu.Visible = false;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            NumberOfPlayers = 2;
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            NumberOfPlayers = 3;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rb2.Checked == true)
                NumberOfPlayers = 2;
            else if (rb3.Checked == true)
                NumberOfPlayers = 3;

            names = new string[NumberOfPlayers];
            names[0] = tbName1.Text;
            names[1] = tbName2.Text;
            if (NumberOfPlayers == 3)
                names[2] = tbName3.Text;

            pMenu.Visible = true;
            pOption.Visible = false;
        }
    }
}
