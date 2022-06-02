using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        String Btnvalue = "X";
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Btn1.Text == "")
            {
                Btn1.Text = Btnvalue;
                if (Btnvalue == "X")
                {
                    Btnvalue = "O";
                }
                else
                {
                    Btnvalue = "X";
                }
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (Btn2.Text == "")
            {
                Btn2.Text = Btnvalue;
                if (Btnvalue == "X")
                {
                    Btnvalue = "O";
                }
                else
                {
                    Btnvalue = "X";
                }
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (Btn3.Text == "")
            {
                Btn3.Text = Btnvalue;
                if (Btnvalue == "X")
                {
                    Btnvalue = "O";
                }
                else
                {
                    Btnvalue = "X";
                }
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (Btn4.Text == "")
            {
                Btn4.Text = Btnvalue;
                if (Btnvalue == "X")
                {
                    Btnvalue = "O";
                }
                else
                {
                    Btnvalue = "X";
                }
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (Btn5.Text == "")
            {
                Btn5.Text = Btnvalue;
                if (Btnvalue == "X")
                {
                    Btnvalue = "O";
                }
                else
                {
                    Btnvalue = "X";
                }
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (Btn6.Text == "")
            {
                Btn6.Text = Btnvalue;
                if (Btnvalue == "X")
                {
                    Btnvalue = "O";
                }
                else
                {
                    Btnvalue = "X";
                }
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (Btn7.Text == "")
            {
                Btn7.Text = Btnvalue;
                if (Btnvalue == "X")
                {
                    Btnvalue = "O";
                }
                else
                {
                    Btnvalue = "X";
                }
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (Btn8.Text == "")
            {
                Btn8.Text = Btnvalue;
                if (Btnvalue == "X")
                {
                    Btnvalue = "O";
                }
                else
                {
                    Btnvalue = "X";
                }
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (Btn9.Text == "")
            {
                Btn9.Text = Btnvalue;
                if (Btnvalue == "X")
                {
                    Btnvalue = "O";
                }
                else
                {
                    Btnvalue = "X";
                }
            }
        }
    }
}
