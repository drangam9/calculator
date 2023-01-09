namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn00 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox.Location = new System.Drawing.Point(11, 31);
            this.TextBox.Margin = new System.Windows.Forms.Padding(1);
            this.TextBox.MaxLength = 16;
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(382, 81);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
    
            this.TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn1.Location = new System.Drawing.Point(10, 340);
            this.Btn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(90, 60);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn2.Location = new System.Drawing.Point(109, 340);
            this.Btn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(90, 60);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn3.Location = new System.Drawing.Point(206, 340);
            this.Btn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(90, 60);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn5.Location = new System.Drawing.Point(109, 272);
            this.Btn5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(90, 60);
            this.Btn5.TabIndex = 5;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn6.Location = new System.Drawing.Point(206, 272);
            this.Btn6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(90, 60);
            this.Btn6.TabIndex = 6;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn7.Location = new System.Drawing.Point(10, 204);
            this.Btn7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(90, 60);
            this.Btn7.TabIndex = 7;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn8.Location = new System.Drawing.Point(109, 204);
            this.Btn8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(90, 60);
            this.Btn8.TabIndex = 8;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn9.Location = new System.Drawing.Point(206, 204);
            this.Btn9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(90, 60);
            this.Btn9.TabIndex = 9;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn00
            // 
            this.Btn00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.Btn00.FlatAppearance.BorderSize = 0;
            this.Btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn00.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn00.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn00.Location = new System.Drawing.Point(10, 408);
            this.Btn00.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn00.Name = "Btn00";
            this.Btn00.Size = new System.Drawing.Size(90, 60);
            this.Btn00.TabIndex = 10;
            this.Btn00.Text = "00";
            this.Btn00.UseVisualStyleBackColor = false;
            this.Btn00.Click += new System.EventHandler(this.Btn00_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn0.Location = new System.Drawing.Point(109, 408);
            this.Btn0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(90, 60);
            this.Btn0.TabIndex = 11;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.BtnDot.FlatAppearance.BorderSize = 0;
            this.BtnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDot.Location = new System.Drawing.Point(206, 408);
            this.BtnDot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(90, 60);
            this.BtnDot.TabIndex = 12;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = false;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnDivide.FlatAppearance.BorderSize = 0;
            this.BtnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDivide.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDivide.Location = new System.Drawing.Point(303, 136);
            this.BtnDivide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(90, 60);
            this.BtnDivide.TabIndex = 13;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = false;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnMultiply.FlatAppearance.BorderSize = 0;
            this.BtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMultiply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMultiply.Location = new System.Drawing.Point(303, 204);
            this.BtnMultiply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(90, 60);
            this.BtnMultiply.TabIndex = 14;
            this.BtnMultiply.Text = "*";
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnSubtract.FlatAppearance.BorderSize = 0;
            this.BtnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubtract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSubtract.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSubtract.Location = new System.Drawing.Point(303, 272);
            this.BtnSubtract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(90, 60);
            this.BtnSubtract.TabIndex = 15;
            this.BtnSubtract.Text = "-";
            this.BtnSubtract.UseVisualStyleBackColor = false;
            this.BtnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdd.Location = new System.Drawing.Point(303, 340);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAdd.Size = new System.Drawing.Size(90, 60);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn4.Location = new System.Drawing.Point(10, 272);
            this.Btn4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(90, 60);
            this.Btn4.TabIndex = 17;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnCE.FlatAppearance.BorderSize = 0;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCE.Location = new System.Drawing.Point(11, 136);
            this.BtnCE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(187, 60);
            this.BtnCE.TabIndex = 18;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClear.Location = new System.Drawing.Point(206, 136);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(90, 60);
            this.BtnClear.TabIndex = 20;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnEquals.FlatAppearance.BorderSize = 0;
            this.BtnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEquals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEquals.Location = new System.Drawing.Point(303, 408);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(90, 60);
            this.BtnEquals.TabIndex = 21;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(402, 483);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnSubtract);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn00);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBox;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button BtnCE;
        private Button Btn5;
        private Button Btn6;
        private Button Btn7;
        private Button Btn8;
        private Button Btn9;
        private Button Btn00;
        private Button Btn0;
        private Button BtnDot;
        private Button BtnDivide;
        private Button BtnMultiply;
        private Button BtnSubtract;
        private Button BtnAdd;
        private Button Btn4;
        private Button BtnClear;
        private Button BtnEquals;
    }
}