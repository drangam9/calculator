using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // These functions control how the textbox modifies based on what button is clicked.
        private void Btn1_Click(object sender, EventArgs e)
        {
            TextBox.Text += 1; 
        }
       
        private void Btn00_Click(object sender, EventArgs e)
        {
            if(TextBox.Text != "0")
                TextBox.Text += "00";
        }
            
        private void Btn0_Click(object sender, EventArgs e)
        {
            if(TextBox.Text != "0")
                TextBox.Text += 0;
        }
        private void BtnDot_Click(object sender, EventArgs e)
        {
            if(!TextBox.Text.Contains("."))
                TextBox.Text += '.';
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TextBox.Text += 2;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TextBox.Text += 3;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TextBox.Text += 4;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TextBox.Text += 5;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TextBox.Text += 6;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TextBox.Text += 7;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TextBox.Text += 8;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TextBox.Text += 9;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
        }

        // Check if the keys entered in the textbox are something other than numbers.

        private bool nonNumberEntered = false;
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
       
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }

            // Treat any SHIFT + [key] combination as a non-number. 
            
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }

            // Allow for a single decimal character to be added (for float numbers).
            if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod && !TextBox.Text.Contains(".") )
                nonNumberEntered = false ;
            
        }

        // If the key pressed is not a number, don't write it in the text box.
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }
    }
}