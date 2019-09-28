using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        private int clickedByPlayerNo, clickNo;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            buttonClicked(sender);
        }       

        private void btn2_Click(object sender, EventArgs e)
        {
            buttonClicked(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            buttonClicked(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            buttonClicked(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            buttonClicked(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            buttonClicked(sender);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            buttonClicked(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            buttonClicked(sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            buttonClicked(sender);
        }

        private void buttonClicked(object Sender)
        {
            clickNo += 1; //Increase no. of clicks every time a button is clicked

            //All odd numbered clicks are done by 1st player and all even numbered clicks are done by 2nd player.
            if (clickNo % 2 == 1)
                clickedByPlayerNo = 1;
            else
                clickedByPlayerNo = 2;

            
            //for 1st player, assign 'X' and for 2nd player assign '0'
            if (clickedByPlayerNo == 1)
                ((Button)Sender).Text = "X";
            else                
                ((Button)Sender).Text = "0";            
            ((Button)Sender).Enabled = false; //Disable the button once it is clicked

            checkWinner();            
        }

        private void checkWinner()
        {
            if (clickNo > 4)
            {
                //Check if a row if it is having same value and not blank
                if (btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "")
                {                   
                    displayWinner();                    
                }
                else if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "")
                {                    
                    displayWinner();
                }
                else if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "")
                {                    
                    displayWinner();
                }
                else if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "")
                {
                    displayWinner();
                }
                else if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "")
                {
                    displayWinner();
                }
                else if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "")
                {
                    displayWinner();
                }
                else if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "")
                {
                    displayWinner();
                }
                else if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "")
                {
                    displayWinner();
                }
                else if (clickNo == 9)
                {
                    MessageBox.Show("Game Draw!");
                    clearWindow();
                    confirmNewGame();
                }
            }             
        }
        private void displayWinner()
        {
            if (clickedByPlayerNo == 1)
                MessageBox.Show("Winner is A!");
            else
                MessageBox.Show("Winner is B!");
            
            clearWindow();
            confirmNewGame();
        }

        private void clearWindow()
        {
            btn1.Text = "";
            btn1.Enabled = false;
            btn2.Text = "";
            btn2.Enabled = false;
            btn3.Text = "";
            btn3.Enabled = false;
            btn4.Text = "";
            btn4.Enabled = false;
            btn5.Text = "";
            btn5.Enabled = false;
            btn6.Text = "";
            btn6.Enabled = false;
            btn7.Text = "";
            btn7.Enabled = false;
            btn8.Text = "";
            btn8.Enabled = false;
            btn9.Text = "";
            btn9.Enabled = false;            
        }

        private void confirmNewGame()
        {
            if (MessageBox.Show("Want to play a new game?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                newGame();
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void newGame()
        {
            clearWindow();
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            clickNo = 0;
            clickedByPlayerNo = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Howtoplay frmObj = new Howtoplay(); 
            frmObj.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutTicTacToe frmObj = new AboutTicTacToe();
            frmObj.ShowDialog();
        }
        
    }
}
