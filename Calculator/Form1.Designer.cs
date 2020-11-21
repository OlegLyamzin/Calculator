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
            this.buttonNumber1 = new System.Windows.Forms.Button();
            this.buttonNumber2 = new System.Windows.Forms.Button();
            this.buttonNumber3 = new System.Windows.Forms.Button();
            this.buttonNumber4 = new System.Windows.Forms.Button();
            this.buttonNumber5 = new System.Windows.Forms.Button();
            this.buttonNumber6 = new System.Windows.Forms.Button();
            this.buttonNumber7 = new System.Windows.Forms.Button();
            this.buttonNumber8 = new System.Windows.Forms.Button();
            this.buttonNumber9 = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxCurrentOperand = new System.Windows.Forms.TextBox();
            this.labelSecondOperand = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonNumber0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNumber1
            // 
            this.buttonNumber1.Location = new System.Drawing.Point(5, 47);
            this.buttonNumber1.Name = "buttonNumber1";
            this.buttonNumber1.Size = new System.Drawing.Size(28, 26);
            this.buttonNumber1.TabIndex = 0;
            this.buttonNumber1.Text = "1";
            this.buttonNumber1.UseVisualStyleBackColor = true;
            this.buttonNumber1.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNumber2
            // 
            this.buttonNumber2.Location = new System.Drawing.Point(39, 47);
            this.buttonNumber2.Name = "buttonNumber2";
            this.buttonNumber2.Size = new System.Drawing.Size(28, 26);
            this.buttonNumber2.TabIndex = 0;
            this.buttonNumber2.Text = "2";
            this.buttonNumber2.UseVisualStyleBackColor = true;
            this.buttonNumber2.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNumber3
            // 
            this.buttonNumber3.Location = new System.Drawing.Point(73, 47);
            this.buttonNumber3.Name = "buttonNumber3";
            this.buttonNumber3.Size = new System.Drawing.Size(28, 26);
            this.buttonNumber3.TabIndex = 0;
            this.buttonNumber3.Text = "3";
            this.buttonNumber3.UseVisualStyleBackColor = true;
            this.buttonNumber3.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNumber4
            // 
            this.buttonNumber4.Location = new System.Drawing.Point(5, 79);
            this.buttonNumber4.Name = "buttonNumber4";
            this.buttonNumber4.Size = new System.Drawing.Size(28, 26);
            this.buttonNumber4.TabIndex = 0;
            this.buttonNumber4.Text = "4";
            this.buttonNumber4.UseVisualStyleBackColor = true;
            this.buttonNumber4.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNumber5
            // 
            this.buttonNumber5.Location = new System.Drawing.Point(39, 79);
            this.buttonNumber5.Name = "buttonNumber5";
            this.buttonNumber5.Size = new System.Drawing.Size(28, 26);
            this.buttonNumber5.TabIndex = 0;
            this.buttonNumber5.Text = "5";
            this.buttonNumber5.UseVisualStyleBackColor = true;
            this.buttonNumber5.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNumber6
            // 
            this.buttonNumber6.Location = new System.Drawing.Point(73, 79);
            this.buttonNumber6.Name = "buttonNumber6";
            this.buttonNumber6.Size = new System.Drawing.Size(28, 26);
            this.buttonNumber6.TabIndex = 0;
            this.buttonNumber6.Text = "6";
            this.buttonNumber6.UseVisualStyleBackColor = true;
            this.buttonNumber6.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNumber7
            // 
            this.buttonNumber7.Location = new System.Drawing.Point(5, 111);
            this.buttonNumber7.Name = "buttonNumber7";
            this.buttonNumber7.Size = new System.Drawing.Size(28, 26);
            this.buttonNumber7.TabIndex = 0;
            this.buttonNumber7.Text = "7";
            this.buttonNumber7.UseVisualStyleBackColor = true;
            this.buttonNumber7.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNumber8
            // 
            this.buttonNumber8.Location = new System.Drawing.Point(39, 111);
            this.buttonNumber8.Name = "buttonNumber8";
            this.buttonNumber8.Size = new System.Drawing.Size(28, 26);
            this.buttonNumber8.TabIndex = 0;
            this.buttonNumber8.Text = "8";
            this.buttonNumber8.UseVisualStyleBackColor = true;
            this.buttonNumber8.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNumber9
            // 
            this.buttonNumber9.Location = new System.Drawing.Point(73, 111);
            this.buttonNumber9.Name = "buttonNumber9";
            this.buttonNumber9.Size = new System.Drawing.Size(28, 26);
            this.buttonNumber9.TabIndex = 0;
            this.buttonNumber9.Text = "9";
            this.buttonNumber9.UseVisualStyleBackColor = true;
            this.buttonNumber9.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(107, 47);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(28, 26);
            this.buttonSum.TabIndex = 0;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.Location = new System.Drawing.Point(107, 79);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(28, 26);
            this.buttonSubtraction.TabIndex = 0;
            this.buttonSubtraction.Text = "-";
            this.buttonSubtraction.UseVisualStyleBackColor = true;
            this.buttonSubtraction.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(107, 111);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(28, 26);
            this.buttonDivision.TabIndex = 0;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Location = new System.Drawing.Point(107, 143);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(28, 26);
            this.buttonMultiplication.TabIndex = 0;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(73, 143);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(28, 26);
            this.buttonResult.TabIndex = 0;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(5, 143);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(28, 26);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxCurrentOperand
            // 
            this.textBoxCurrentOperand.Location = new System.Drawing.Point(5, 18);
            this.textBoxCurrentOperand.Name = "textBoxCurrentOperand";
            this.textBoxCurrentOperand.ReadOnly = true;
            this.textBoxCurrentOperand.Size = new System.Drawing.Size(129, 23);
            this.textBoxCurrentOperand.TabIndex = 1;
            this.textBoxCurrentOperand.Text = "0";
            this.textBoxCurrentOperand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelSecondOperand
            // 
            this.labelSecondOperand.Location = new System.Drawing.Point(5, 0);
            this.labelSecondOperand.Name = "labelSecondOperand";
            this.labelSecondOperand.Size = new System.Drawing.Size(129, 15);
            this.labelSecondOperand.TabIndex = 2;
            this.labelSecondOperand.Text = "0";
            this.labelSecondOperand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSecondOperand.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(5, 176);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 3;
            // 
            // buttonNumber0
            // 
            this.buttonNumber0.Location = new System.Drawing.Point(39, 143);
            this.buttonNumber0.Name = "buttonNumber0";
            this.buttonNumber0.Size = new System.Drawing.Size(28, 26);
            this.buttonNumber0.TabIndex = 0;
            this.buttonNumber0.Text = "0";
            this.buttonNumber0.UseVisualStyleBackColor = true;
            this.buttonNumber0.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 207);
            this.Controls.Add(this.buttonNumber0);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelSecondOperand);
            this.Controls.Add(this.textBoxCurrentOperand);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonSubtraction);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonNumber9);
            this.Controls.Add(this.buttonNumber8);
            this.Controls.Add(this.buttonNumber7);
            this.Controls.Add(this.buttonNumber6);
            this.Controls.Add(this.buttonNumber5);
            this.Controls.Add(this.buttonNumber4);
            this.Controls.Add(this.buttonNumber3);
            this.Controls.Add(this.buttonNumber2);
            this.Controls.Add(this.buttonNumber1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNumber1;
        private System.Windows.Forms.Button buttonNumber2;
        private System.Windows.Forms.Button buttonNumber3;
        private System.Windows.Forms.Button buttonNumber4;
        private System.Windows.Forms.Button buttonNumber5;
        private System.Windows.Forms.Button buttonNumber6;
        private System.Windows.Forms.Button buttonNumber7;
        private System.Windows.Forms.Button buttonNumber8;
        private System.Windows.Forms.Button buttonNumber9;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonSubtraction;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxCurrentOperand;
        private System.Windows.Forms.Label labelSecondOperand;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonNumber0;
    }
}

