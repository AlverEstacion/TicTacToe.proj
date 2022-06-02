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
                // Vertical Pattern
                if (Btn1.Text == Btn2.Text)
                {
                    if (Btn2.Text == Btn3.Text)
                    {
                        MessageBox.Show("You win " + Btn1.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }     
                    // Horizontal Pattern
                }
                else if (Btn1.Text == Btn4.Text)
                {
                    if (Btn4.Text == Btn7.Text)
                    {
                        MessageBox.Show("You win " + Btn1.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
                    // Diagonal Pattern
                }
                else if (Btn1.Text == Btn5.Text)
                {
                    if (Btn5.Text == Btn9.Text)
                    {
                        MessageBox.Show("You win " + Btn1.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
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
                // Vertical Line Pattern
                if (Btn2.Text == Btn3.Text)
                {
                    if (Btn3.Text == Btn1.Text)
                    {
                        MessageBox.Show("You win " + Btn2.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
                }
                // Horizontal Pattern
                else if (Btn2.Text == Btn5.Text)
                {
                    if (Btn5.Text == Btn8.Text)
                    {
                        MessageBox.Show("You win " + Btn2.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
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
                // Vertical Pattern
                if (Btn3.Text == Btn2.Text)
                {
                    if (Btn2.Text == Btn1.Text)
                    {
                        MessageBox.Show("You win " + Btn3.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
                } // Horizontal Pattern
                else if (Btn3.Text == Btn6.Text)
                {
                    if (Btn6.Text == Btn9.Text)
                    {
                        MessageBox.Show("You win " + Btn3.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
                } // Diagonal Pattern
                else if (Btn3.Text == Btn5.Text)
                {
                    if (Btn5.Text == Btn7.Text)
                    {
                        MessageBox.Show("You win " + Btn3.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
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
                // Vertical Pattern
                if (Btn4.Text == Btn5.Text)
                {
                    if (Btn5.Text == Btn6.Text)
                    {
                        MessageBox.Show("You win " + Btn4.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
                } // Horizontal Pattern
                else if (Btn4.Text == Btn7.Text)
                {
                    if (Btn7.Text == Btn1.Text)
                    {
                        MessageBox.Show("You win " + Btn4.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
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
                // Vertical Pattern
                if (Btn5.Text == Btn6.Text)
                {
                    if (Btn6.Text == Btn4.Text)
                    {
                        MessageBox.Show("You win " + Btn5.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
                } // Horizontal Pattern
                else if (Btn5.Text == Btn8.Text)
                {
                    if (Btn8.Text == Btn2.Text)
                    {
                        MessageBox.Show("You win " + Btn5.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
                } // Diagonal Pattern
                else if (Btn5.Text == Btn9.Text)
                {
                    if (Btn9.Text == Btn1.Text)
                    {
                        MessageBox.Show("You win " + Btn5.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
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
                // Vertical Pattern
                if (Btn6.Text == Btn5.Text)
                {
                    if (Btn5.Text == Btn4.Text)
                    {
                        MessageBox.Show("You win " + Btn6.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
                } // Horizontal Pattern
                else if (Btn6.Text == Btn9.Text)
                {
                    if (Btn9.Text == Btn3.Text)
                    {
                        MessageBox.Show("You win " + Btn6.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
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
                // Vertical Pattern
                if (Btn7.Text == Btn8.Text)
                {
                    if (Btn8.Text == Btn9.Text)
                    {
                        MessageBox.Show("You win " + Btn7.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
                } // Horizontal Pattern
                else if (Btn7.Text == Btn4.Text)
                {
                    if (Btn4.Text == Btn1.Text)
                    {
                        MessageBox.Show("You win " + Btn7.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
                } // Diagonal Pattern
                else if (Btn7.Text == Btn5.Text)
                {
                    if (Btn5.Text == Btn3.Text)
                    {
                        MessageBox.Show("You win " + Btn7.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
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
                if (Btn8.Text == Btn9.Text)
                {
                    if (Btn9.Text == Btn7.Text)
                    {
                        MessageBox.Show("You win " + Btn1.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
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
                if (Btn9.Text == Btn8.Text)
                {
                    if (Btn8.Text == Btn7.Text)
                    {
                        MessageBox.Show("You win " + Btn1.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This TicTacToe was made by Jose Alver H. Estacion");
        }
    }
}


