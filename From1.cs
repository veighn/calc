using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Test_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c; // The variable 'c' will hold the result of the calculations.

                if (radioButton1.Checked)
                {
                    c = a + b;
                    label4.Text = "Add = " + c.ToString(); // Add first and second number.
                }
                else if (radioButton2.Checked)
                {
                    c = a - b;
                    label4.Text = "Subtract = " + c.ToString(); // Subtract second from first number.
                }
                else if (radioButton3.Checked)
                {
                    c = a * b;
                    label4.Text = "Multiply = " + c.ToString(); // Multiply first and second number.
                }
                else if (radioButton4.Checked)
                {
                    if (b != 0) // Check for division by zero.
                    {
                        c = a / b;
                        label4.Text = "Divide = " + c.ToString(); // Divide first by second number.
                    }
                    else
                    {
                        label4.Text = "DIVIDE BY ZERO ERROR"; // Handle division by zero error.
                    }
                }
                else if (radioButton5.Checked)
                {
                    if (b != 0) // Check for division by zero.
                    {
                        c = a % b;
                        label4.Text = "Mod = " + c.ToString(); // Mod first number and second number.
                    }
                    else
                    {
                        label4.Text = "MODULO BY ZERO ERROR"; // Handle modulo by zero error.
                    }
                }
                else
                {
                    label4.Text = "Please select an operation."; // Prompt the user to select an operation.
                }
            }
            catch (FormatException)
            {
                label4.Text = "Invalid input. Please enter valid numbers."; // Handle invalid input format.
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";// Clears TextBox1
            textBox2.Text = "";// Clears TextBox2
            label4.Text = "";// Clears Label4

        }

       

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;// Changes BackColor to black
            button1.ForeColor = Color.White;// Changes ForeColor to White
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;// Changes ForeColor to White
            button1.ForeColor = Color.Black;// Changes BackColor to black
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;// Changes BackColor to black
            button2.ForeColor = Color.White;// Changes ForeColor to White
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;// Changes BackColor to black
            button2.ForeColor = Color.White;// Changes ForeColor to White
        }

    
        
    }
}
