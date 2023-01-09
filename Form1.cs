using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

namespace Calculator
{
    
    public partial class Form1 : Form
    {
        [DllImport("user32")] private static extern bool HideCaret(IntPtr hWnd);
        [DllImport("user32")] private static extern bool ShowCaret(IntPtr hWnd);
        public Form1()
        {
            InitializeComponent();
            this.TextBox.GotFocus += new System.EventHandler(TextBox_GotFocus);
        }
        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            HideCaret(this.TextBox.Handle);
        }
        // These functions control how the textbox modifies based on what button is clicked.
        private bool operationDone = false;
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
            TextBox.Focus();
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            TextBox.Focus();
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

            // After pressing equal, remove the whole text when pressing backspace instead of one character at a time.

            if (operationDone && e.KeyCode == Keys.Back) 
            {
                TextBox.Text = string.Empty;
                
            }
        }

        // If the key pressed is not a number, don't write it in the text box, unless it's an operation symbol (+, -, *, /, =).
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
                switch (e.KeyChar)
                {
                    case '+':
                        BtnAdd_Click(sender, e);
                        break;
                    case '-':
                        BtnSubtract_Click(sender, e);
                        break;
                    case '*':
                        BtnMultiply_Click(sender, e);
                        break;
                    case '/':
                        BtnDivide_Click(sender, e);
                        break;
                    case '=':
                        BtnEquals_Click(sender, e);
                        break;
                }
                if(e.KeyChar == (char)13)
                    BtnEquals_Click(sender, e);
            }
            
        }
        private float num1 = 0;
        private float num2 = 0;

        private int operation = 0;
        private int nrOfOperations = 0;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                nrOfOperations++;
                
                if (nrOfOperations == 1)
                    num1 = Single.Parse(TextBox.Text);
                else
                {
                    num2 = Single.Parse(TextBox.Text);
                    num1 += num2;
                }

                TextBox.Clear();
                TextBox.Focus();

                operation = 1;
            }
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                nrOfOperations++;

                if (nrOfOperations == 1)
                    num1 = Single.Parse(TextBox.Text);
                else
                {
                    num2 = Single.Parse(TextBox.Text);
                    num1 -= num2;
                }

                TextBox.Clear();
                TextBox.Focus();

                operation = 2;
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                nrOfOperations++;

                if (nrOfOperations == 1)
                    num1 = Single.Parse(TextBox.Text);
                else
                {
                    num2 = Single.Parse(TextBox.Text);
                    num1 *= num2;
                }

                TextBox.Clear();
                TextBox.Focus();

                operation = 3;
            }
        }
        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                nrOfOperations++;

                if (nrOfOperations == 1)
                    num1 = Single.Parse(TextBox.Text);
                else
                {
                    num2 = Single.Parse(TextBox.Text);
                    if (num2 != 0)
                        num1 /= num2;
                    else TextBox.Text = "Error.";
                }

                TextBox.Clear();
                TextBox.Focus();

                operation = 4;
            }
        }
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if(TextBox.Text.Length != 0)
                num2 = Single.Parse(TextBox.Text);
            
            switch (operation) {
                case 1:
                    num1 += num2;
                    TextBox.Text = $"{num1}";
                    num1 = 0;
                    break;  
                case 2:
                    num1 -= num2;
                    TextBox.Text = $"{num1}";
                    num1 = 0;
                    break;
                case 3:
                    num1 *= num2;
                    TextBox.Text = $"{num1}";
                    num1 = 1;
                    break;
                case 4:
                    if (num2 == 0) TextBox.Text = "Error";
                    else
                    {
                        num1 /= num2;
                        TextBox.Text = $"{num1}";
                        num2 = 1;
                    }
                        break;
            }

            TextBox.SelectionStart = TextBox.Text.Length;
            TextBox.SelectionLength = 0;

            nrOfOperations= 0;
            operationDone = true;
        }

        
    }

}