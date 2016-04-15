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
        public Menu()
        {
            InitializeComponent();
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
            pStart.Visible = true;
            pMenu.Visible = false;
             
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pMenu.Visible = true;
            pStart.Visible = false;
           
        }

        private void btnSingle_MouseHover(object sender, EventArgs e)
        {
            btnSingle.BackColor = Color.DarkCyan;
            Cursor = Cursors.Hand;
        }

        private void btnSingle_MouseLeave(object sender, EventArgs e)
        {
            btnSingle.BackColor = Color.BurlyWood;
            Cursor = DefaultCursor;
        }

        private void btnTwo_MouseHover(object sender, EventArgs e)
        {
            btnTwo.BackColor = Color.DarkCyan;
            Cursor = Cursors.Hand;
        }
    

        private void btnTwo_MouseLeave(object sender, EventArgs e)
        {
            btnTwo.BackColor = Color.BurlyWood;
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
            pOptions.Visible = true;
            pMenu.Visible = false;
        }
    }
}
