using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BomberMan
{
    public partial class Menu : Form
    {
        List<Player> players { get; set; }
        public int NumberOfPlayers { set; get; }

        public Menu()
        {
            InitializeComponent();
            players = new List<Player>();
            NumberOfPlayers = 2;
            Player player1 = new Player("Player1");
            Player player2 = new Player("Player2");
            Player player3 = new Player("Player3");
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

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
            StartGame newGame = new StartGame(NumberOfPlayers, players);
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

            players[0].Name = tbName1.Text;
            players[1].Name = tbName2.Text;
            if (NumberOfPlayers == 3)
                players[2].Name = tbName3.Text;

            pMenu.Visible = true;
            pOption.Visible = false;
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            string[] parts;
            List<Player> players = new List<Player>();
            StringBuilder sb = new StringBuilder();
            sb.Append("Единаесте најдобри играчи се:\n");
            using (FileStream sr = new FileStream("HighScore.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader read = new StreamReader(sr)){
                    string s = String.Empty;
                    while ((s = read.ReadLine()) != null)
                    {
                        parts = s.Split(' ');
                        Player p = new Player(parts[0], Convert.ToInt32(parts[1]));
                        players.Add(p);
                    }
                }
            }

            players = players.OrderByDescending(x => x.Score).ToList();
            foreach (Player p in players)
                sb.Append(p.ToString() + "\n");
            MessageBox.Show(sb.ToString(), "Најдобри играчи", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
