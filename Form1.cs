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
    }
}
