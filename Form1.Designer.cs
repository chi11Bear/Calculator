//Darren Joyner
//CSCI 363
//Assignment 1

namespace csci363DJoynerCalculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.resultBox = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.equationBox = new System.Windows.Forms.TextBox();
            this.Ans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(28, 90);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(447, 122);
            this.resultBox.TabIndex = 0;
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(28, 252);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 67);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(124, 252);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 67);
            this.eight.TabIndex = 2;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(217, 252);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(75, 67);
            this.nine.TabIndex = 3;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(28, 325);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 67);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Four_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(124, 325);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 67);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Five_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(217, 325);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 67);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Six_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(309, 325);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 67);
            this.multiply.TabIndex = 8;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(28, 398);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 67);
            this.one.TabIndex = 9;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.One_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(124, 398);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 67);
            this.two.TabIndex = 10;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Two_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(217, 398);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 67);
            this.three.TabIndex = 11;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Three_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(309, 398);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 67);
            this.add.TabIndex = 12;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(28, 471);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(75, 67);
            this.zero.TabIndex = 13;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(124, 471);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(75, 67);
            this.dot.TabIndex = 14;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(400, 325);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 67);
            this.divide.TabIndex = 17;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(400, 398);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 67);
            this.minus.TabIndex = 18;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.ForestGreen;
            this.equal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(309, 471);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(166, 67);
            this.equal.TabIndex = 19;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.OrangeRed;
            this.clear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(309, 252);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(166, 67);
            this.clear.TabIndex = 20;
            this.clear.Text = "c";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // equationBox
            // 
            this.equationBox.Location = new System.Drawing.Point(28, 44);
            this.equationBox.Multiline = true;
            this.equationBox.Name = "equationBox";
            this.equationBox.Size = new System.Drawing.Size(447, 40);
            this.equationBox.TabIndex = 21;
            // 
            // Ans
            // 
            this.Ans.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ans.Location = new System.Drawing.Point(217, 471);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(75, 67);
            this.Ans.TabIndex = 22;
            this.Ans.Text = "Ans";
            this.Ans.UseVisualStyleBackColor = true;
            this.Ans.Click += new System.EventHandler(this.Ans_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(505, 569);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.equationBox);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.add);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.resultBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox equationBox;
        private System.Windows.Forms.Button Ans;

        string userInput = string.Empty;
        string firstOperand = string.Empty;
        string secondOperand = string.Empty;
        string equation = string.Empty;
        char operation;
        double result = 0.00;
        double savedAns = 0.00;
        bool equalclicked = false; 
    }
}

