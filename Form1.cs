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
    public partial class Frm1 : Form
    {
        String Btnvalue = "X";
        int counter = 0;
        System.Media.SoundPlayer _BGM = new System.Media.SoundPlayer();
        public Frm1()
        {
            InitializeComponent();

            _BGM.SoundLocation = "Anime lofi.wav";

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
                        MessageBox.Show("WINNER IS " + Btn1.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                    // Horizontal Pattern
                }
                else if (Btn1.Text == Btn4.Text)
                {
                    if (Btn4.Text == Btn7.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn1.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                    // Diagonal Pattern
                }
                else if (Btn1.Text == Btn5.Text)
                {
                    if (Btn5.Text == Btn9.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn1.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("IT'S A DRAW");
                    Btn1.Text = "";
                    Btn2.Text = "";
                    Btn3.Text = "";
                    Btn4.Text = "";
                    Btn5.Text = "";
                    Btn6.Text = "";
                    Btn7.Text = "";
                    Btn8.Text = "";
                    Btn9.Text = "";
                    counter = 0;
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
                        MessageBox.Show("WINNER IS " + Btn2.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                }
                // Horizontal Pattern
                else if (Btn2.Text == Btn5.Text)
                {
                    if (Btn5.Text == Btn8.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn2.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("IT'S A DRAW");
                    Btn1.Text = "";
                    Btn2.Text = "";
                    Btn3.Text = "";
                    Btn4.Text = "";
                    Btn5.Text = "";
                    Btn6.Text = "";
                    Btn7.Text = "";
                    Btn8.Text = "";
                    Btn9.Text = "";
                    counter = 0;
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
                        MessageBox.Show("WINNER IS " + Btn3.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                } // Horizontal Pattern
                else if (Btn3.Text == Btn6.Text)
                {
                    if (Btn6.Text == Btn9.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn3.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                } // Diagonal Pattern
                else if (Btn3.Text == Btn5.Text)
                {
                    if (Btn5.Text == Btn7.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn3.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("IT'S A DRAW");
                    Btn1.Text = "";
                    Btn2.Text = "";
                    Btn3.Text = "";
                    Btn4.Text = "";
                    Btn5.Text = "";
                    Btn6.Text = "";
                    Btn7.Text = "";
                    Btn8.Text = "";
                    Btn9.Text = "";
                    counter = 0;
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
                        MessageBox.Show("WINNER IS " + Btn4.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                } // Horizontal Pattern
                else if (Btn4.Text == Btn7.Text)
                {
                    if (Btn7.Text == Btn1.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn4.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("IT'S A DRAW");
                    Btn1.Text = "";
                    Btn2.Text = "";
                    Btn3.Text = "";
                    Btn4.Text = "";
                    Btn5.Text = "";
                    Btn6.Text = "";
                    Btn7.Text = "";
                    Btn8.Text = "";
                    Btn9.Text = "";
                    counter = 0;
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
                        MessageBox.Show("WINNER IS " + Btn5.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                } // Horizontal Pattern
                else if (Btn5.Text == Btn8.Text)
                {
                    if (Btn8.Text == Btn2.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn5.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                } // Diagonal Pattern
                else if (Btn5.Text == Btn9.Text)
                {
                    if (Btn9.Text == Btn1.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn5.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                } // Diagonal Pattern 2
                else if (Btn5.Text == Btn3.Text)
                {
                    if (Btn3.Text == Btn7.Text)
                    {

                        MessageBox.Show("WINNER IS " + Btn5.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("IT'S A DRAW");
                    Btn1.Text = "";
                    Btn2.Text = "";
                    Btn3.Text = "";
                    Btn4.Text = "";
                    Btn5.Text = "";
                    Btn6.Text = "";
                    Btn7.Text = "";
                    Btn8.Text = "";
                    Btn9.Text = "";
                    counter = 0;
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
                        MessageBox.Show("WINNER IS " + Btn6.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                } // Horizontal Pattern
                else if (Btn6.Text == Btn9.Text)
                {
                    if (Btn9.Text == Btn3.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn6.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("IT'S A DRAW");
                    Btn1.Text = "";
                    Btn2.Text = "";
                    Btn3.Text = "";
                    Btn4.Text = "";
                    Btn5.Text = "";
                    Btn6.Text = "";
                    Btn7.Text = "";
                    Btn8.Text = "";
                    Btn9.Text = "";
                    counter = 0;
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
                        MessageBox.Show("WINNER IS " + Btn7.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                } // Horizontal Pattern
                else if (Btn7.Text == Btn4.Text)
                {
                    if (Btn4.Text == Btn1.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn7.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                } // Diagonal Pattern
                else if (Btn7.Text == Btn5.Text)
                {
                    if (Btn5.Text == Btn3.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn7.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("IT'S A DRAW");
                    Btn1.Text = "";
                    Btn2.Text = "";
                    Btn3.Text = "";
                    Btn4.Text = "";
                    Btn5.Text = "";
                    Btn6.Text = "";
                    Btn7.Text = "";
                    Btn8.Text = "";
                    Btn9.Text = "";
                    counter = 0;
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
                // Vertical Pattern
                if (Btn8.Text == Btn9.Text)
                {
                    if (Btn9.Text == Btn7.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn8.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                } // Horizontal Pattern
                else if (Btn8.Text == Btn5.Text)
                {
                    if (Btn5.Text == Btn2.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn8.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("IT'S A DRAW");
                    Btn1.Text = "";
                    Btn2.Text = "";
                    Btn3.Text = "";
                    Btn4.Text = "";
                    Btn5.Text = "";
                    Btn6.Text = "";
                    Btn7.Text = "";
                    Btn8.Text = "";
                    Btn9.Text = "";
                    counter = 0;
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
                // Vertical Pattern
                if (Btn9.Text == Btn8.Text)
                {
                    if (Btn8.Text == Btn7.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn9.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                } // Horizontal Pattern
                else if (Btn9.Text == Btn6.Text)
                {
                    if (Btn6.Text == Btn3.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn9.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                } // Diagonal Pattern
                else if (Btn9.Text == Btn5.Text)
                {
                    if (Btn5.Text == Btn1.Text)
                    {
                        MessageBox.Show("WINNER IS " + Btn9.Text);
                        Btn1.Text = "";
                        Btn2.Text = "";
                        Btn3.Text = "";
                        Btn4.Text = "";
                        Btn5.Text = "";
                        Btn6.Text = "";
                        Btn7.Text = "";
                        Btn8.Text = "";
                        Btn9.Text = "";
                        counter = 0;
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("IT'S A DRAW");
                    Btn1.Text = "";
                    Btn2.Text = "";
                    Btn3.Text = "";
                    Btn4.Text = "";
                    Btn5.Text = "";
                    Btn6.Text = "";
                    Btn7.Text = "";
                    Btn8.Text = "";
                    Btn9.Text = "";
                    counter = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This TicTacToe was made by Jose Alver H. Estacion", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
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

        private void sndbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sndbtn.Checked)
            {
                sndbtn.Text = "Off Music";
                _BGM.Play();
            }
            else
            {
                sndbtn.Text = "On Music";
                _BGM.Stop();
            }
        }
    }
}


