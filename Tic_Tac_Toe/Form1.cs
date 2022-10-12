using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private int player;
        private int count=0;
        public Form1()
        {
            InitializeComponent();
            this.Width = 460;
            this.Height = 360;
            label1.Text = "Player X";
            player = 1;
            label2.Text = "number of games:" + count;

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            switch(player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    player = 0;
                    label1.Text = "Player O";

                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");
                    player = 1;
                    label1.Text = "Player X";
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            //MessageBox.Show(sender.GetType().GetProperty("Name").GetValue(sender).ToString());
            Check_Win();
        }
        private void Check_Win()
        {
            if((button1.Text==button2.Text && button1.Text==button3.Text) && (button1.Text!="" && button2.Text!="" && button3.Text!=""))
            { MessageBox.Show("win");
                count++;
                label2.Text = "number of games:" + count;
            }
            if ((button4.Text == button5.Text && button4.Text == button6.Text) && (button4.Text != "" && button5.Text != "" && button6.Text != ""))
            {
                MessageBox.Show("win");
                count++;
                label2.Text = "number of games:" + count;
            }
            if ((button7.Text == button8.Text && button7.Text == button9.Text) && (button7.Text != "" && button8.Text != "" && button9.Text != ""))
            {
                MessageBox.Show("win");
                count++;
                label2.Text = "number of games:" + count;
            }
            if ((button1.Text == button4.Text && button1.Text == button7.Text) && (button1.Text != "" && button4.Text != "" && button7.Text != ""))
            {
                MessageBox.Show("win");
                count++;
                label2.Text = "number of games:" + count;
            }
            if ((button2.Text == button5.Text && button2.Text == button8.Text) && (button2.Text != "" && button5.Text != "" && button8.Text != ""))
            {
                MessageBox.Show("win");
                count++;
                label2.Text = "number of games:" + count;
            }
            if ((button3.Text == button6.Text && button3.Text == button9.Text) && (button3.Text != "" && button6.Text != "" && button9.Text != ""))
            {
                MessageBox.Show("win");
                count++;
                label2.Text = "number of games:" + count;
            }
            if ((button1.Text == button5.Text && button1.Text == button9.Text) && (button1.Text != "" && button5.Text != "" && button9.Text != ""))
            {
                MessageBox.Show("win");
                count++;
                label2.Text = "number of games:" + count;
            }
            if ((button3.Text == button5.Text && button3.Text == button7.Text) && (button3.Text != "" && button5.Text != "" && button7.Text != ""))
            {
                MessageBox.Show("win");
                count++;
                label2.Text = "number of games:" + count;
            }
            if(button1.Text!="" && button2.Text != "" && button3.Text != "" && 
                button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("draw");
                count++;
                label2.Text = "number of games:" + count;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;
            label1.Text = "Player X";
            player = 1;
        }
    }
}
