using System.Diagnostics.Eventing.Reader;
using System.Globalization;

namespace Bai6
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnBackspace = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.BtnOneOver = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnPercentage = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnSqrt = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnPoint = new System.Windows.Forms.Button();
            this.BtnMPlus = new System.Windows.Forms.Button();
            this.BtnMR = new System.Windows.Forms.Button();
            this.BtnMC = new System.Windows.Forms.Button();
            this.BtnMS = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(377, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnBackspace
            // 
            this.BtnBackspace.ForeColor = System.Drawing.Color.Red;
            this.BtnBackspace.Location = new System.Drawing.Point(85, 104);
            this.BtnBackspace.Name = "BtnBackspace";
            this.BtnBackspace.Size = new System.Drawing.Size(96, 48);
            this.BtnBackspace.TabIndex = 2;
            this.BtnBackspace.Text = "Backspace";
            this.BtnBackspace.UseVisualStyleBackColor = true;
            this.BtnBackspace.Click += new System.EventHandler(this.ButtonBackspaceClick);
            // 
            // BtnCE
            // 
            this.BtnCE.ForeColor = System.Drawing.Color.Red;
            this.BtnCE.Location = new System.Drawing.Point(187, 104);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(96, 48);
            this.BtnCE.TabIndex = 3;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            this.BtnCE.Click += new System.EventHandler(this.ButtonCEClick);
            // 
            // BtnC
            // 
            this.BtnC.ForeColor = System.Drawing.Color.Red;
            this.BtnC.Location = new System.Drawing.Point(293, 104);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(96, 48);
            this.BtnC.TabIndex = 4;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.ButtonCClick);
            // 
            // Btn1
            // 
            this.Btn1.ForeColor = System.Drawing.Color.Blue;
            this.Btn1.Location = new System.Drawing.Point(85, 274);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(56, 52);
            this.Btn1.TabIndex = 5;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // Btn7
            // 
            this.Btn7.ForeColor = System.Drawing.Color.Blue;
            this.Btn7.Location = new System.Drawing.Point(85, 158);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(56, 52);
            this.Btn7.TabIndex = 8;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // Btn4
            // 
            this.Btn4.ForeColor = System.Drawing.Color.Blue;
            this.Btn4.Location = new System.Drawing.Point(85, 216);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(56, 52);
            this.Btn4.TabIndex = 13;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // Btn0
            // 
            this.Btn0.ForeColor = System.Drawing.Color.Blue;
            this.Btn0.Location = new System.Drawing.Point(85, 332);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(56, 52);
            this.Btn0.TabIndex = 14;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // Btn9
            // 
            this.Btn9.ForeColor = System.Drawing.Color.Blue;
            this.Btn9.Location = new System.Drawing.Point(209, 158);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(56, 52);
            this.Btn9.TabIndex = 6;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // Btn8
            // 
            this.Btn8.ForeColor = System.Drawing.Color.Blue;
            this.Btn8.Location = new System.Drawing.Point(147, 158);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(56, 52);
            this.Btn8.TabIndex = 7;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(209, 216);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(56, 52);
            this.Btn6.TabIndex = 9;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // Btn5
            // 
            this.Btn5.ForeColor = System.Drawing.Color.Blue;
            this.Btn5.Location = new System.Drawing.Point(147, 216);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(56, 52);
            this.Btn5.TabIndex = 10;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // Btn3
            // 
            this.Btn3.ForeColor = System.Drawing.Color.Blue;
            this.Btn3.Location = new System.Drawing.Point(209, 274);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(56, 52);
            this.Btn3.TabIndex = 11;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // Btn2
            // 
            this.Btn2.ForeColor = System.Drawing.Color.Blue;
            this.Btn2.Location = new System.Drawing.Point(147, 274);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(56, 52);
            this.Btn2.TabIndex = 12;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.ForeColor = System.Drawing.Color.Red;
            this.BtnSubtract.Location = new System.Drawing.Point(271, 274);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(56, 52);
            this.BtnSubtract.TabIndex = 20;
            this.BtnSubtract.Text = "-";
            this.BtnSubtract.UseVisualStyleBackColor = true;
            this.BtnSubtract.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // BtnOneOver
            // 
            this.BtnOneOver.ForeColor = System.Drawing.Color.Blue;
            this.BtnOneOver.Location = new System.Drawing.Point(333, 274);
            this.BtnOneOver.Name = "BtnOneOver";
            this.BtnOneOver.Size = new System.Drawing.Size(56, 52);
            this.BtnOneOver.TabIndex = 19;
            this.BtnOneOver.Text = "1/x";
            this.BtnOneOver.UseVisualStyleBackColor = true;
            this.BtnOneOver.Click += new System.EventHandler(this.OneOverButtonClick);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.ForeColor = System.Drawing.Color.Red;
            this.BtnMultiply.Location = new System.Drawing.Point(271, 216);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(56, 52);
            this.BtnMultiply.TabIndex = 18;
            this.BtnMultiply.Text = "*";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // BtnPercentage
            // 
            this.BtnPercentage.ForeColor = System.Drawing.Color.Blue;
            this.BtnPercentage.Location = new System.Drawing.Point(333, 216);
            this.BtnPercentage.Name = "BtnPercentage";
            this.BtnPercentage.Size = new System.Drawing.Size(56, 52);
            this.BtnPercentage.TabIndex = 17;
            this.BtnPercentage.Text = "%";
            this.BtnPercentage.UseVisualStyleBackColor = true;
            this.BtnPercentage.Click += new System.EventHandler(this.BtnPercentage_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.ForeColor = System.Drawing.Color.Red;
            this.BtnDivide.Location = new System.Drawing.Point(271, 158);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(56, 52);
            this.BtnDivide.TabIndex = 16;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // BtnSqrt
            // 
            this.BtnSqrt.ForeColor = System.Drawing.Color.Blue;
            this.BtnSqrt.Location = new System.Drawing.Point(333, 158);
            this.BtnSqrt.Name = "BtnSqrt";
            this.BtnSqrt.Size = new System.Drawing.Size(56, 52);
            this.BtnSqrt.TabIndex = 15;
            this.BtnSqrt.Text = "sqrt";
            this.BtnSqrt.UseVisualStyleBackColor = true;
            this.BtnSqrt.Click += new System.EventHandler(this.SqrtButtonClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.ForeColor = System.Drawing.Color.Red;
            this.BtnAdd.Location = new System.Drawing.Point(271, 332);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(56, 52);
            this.BtnAdd.TabIndex = 24;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // BtnEqual
            // 
            this.BtnEqual.ForeColor = System.Drawing.Color.Red;
            this.BtnEqual.Location = new System.Drawing.Point(333, 332);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(56, 52);
            this.BtnEqual.TabIndex = 23;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = true;
            this.BtnEqual.Click += new System.EventHandler(this.EqualButtonClick);
            // 
            // BtnMinus
            // 
            this.BtnMinus.ForeColor = System.Drawing.Color.Blue;
            this.BtnMinus.Location = new System.Drawing.Point(147, 332);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(56, 52);
            this.BtnMinus.TabIndex = 22;
            this.BtnMinus.Text = "+/-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.ButtonMinusClick);
            // 
            // BtnPoint
            // 
            this.BtnPoint.ForeColor = System.Drawing.Color.Blue;
            this.BtnPoint.Location = new System.Drawing.Point(209, 332);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(56, 52);
            this.BtnPoint.TabIndex = 21;
            this.BtnPoint.Text = ".";
            this.BtnPoint.UseVisualStyleBackColor = true;
            this.BtnPoint.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // BtnMPlus
            // 
            this.BtnMPlus.ForeColor = System.Drawing.Color.Red;
            this.BtnMPlus.Location = new System.Drawing.Point(12, 331);
            this.BtnMPlus.Name = "BtnMPlus";
            this.BtnMPlus.Size = new System.Drawing.Size(56, 52);
            this.BtnMPlus.TabIndex = 28;
            this.BtnMPlus.Text = "M+";
            this.BtnMPlus.UseVisualStyleBackColor = true;
            this.BtnMPlus.Click += new System.EventHandler(this.BtnMPlus_Click);
            // 
            // BtnMR
            // 
            this.BtnMR.ForeColor = System.Drawing.Color.Red;
            this.BtnMR.Location = new System.Drawing.Point(12, 215);
            this.BtnMR.Name = "BtnMR";
            this.BtnMR.Size = new System.Drawing.Size(56, 52);
            this.BtnMR.TabIndex = 27;
            this.BtnMR.Text = "MR";
            this.BtnMR.UseVisualStyleBackColor = true;
            this.BtnMR.Click += new System.EventHandler(this.BtnMR_Click);
            // 
            // BtnMC
            // 
            this.BtnMC.ForeColor = System.Drawing.Color.Red;
            this.BtnMC.Location = new System.Drawing.Point(12, 157);
            this.BtnMC.Name = "BtnMC";
            this.BtnMC.Size = new System.Drawing.Size(56, 52);
            this.BtnMC.TabIndex = 26;
            this.BtnMC.Text = "MC";
            this.BtnMC.UseVisualStyleBackColor = true;
            this.BtnMC.Click += new System.EventHandler(this.BtnMC_Click);
            // 
            // BtnMS
            // 
            this.BtnMS.ForeColor = System.Drawing.Color.Red;
            this.BtnMS.Location = new System.Drawing.Point(12, 273);
            this.BtnMS.Name = "BtnMS";
            this.BtnMS.Size = new System.Drawing.Size(56, 52);
            this.BtnMS.TabIndex = 25;
            this.BtnMS.Text = "MS";
            this.BtnMS.UseVisualStyleBackColor = true;
            this.BtnMS.Click += new System.EventHandler(this.BtnMS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 404);
            this.Controls.Add(this.BtnMPlus);
            this.Controls.Add(this.BtnMR);
            this.Controls.Add(this.BtnMC);
            this.Controls.Add(this.BtnMS);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnPoint);
            this.Controls.Add(this.BtnSubtract);
            this.Controls.Add(this.BtnOneOver);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnPercentage);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnSqrt);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnBackspace);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TextBox textBox1;
        private Button BtnBackspace;
        private Button BtnCE;
        private Button BtnC;
        private Button Btn1;
        private Button Btn7;
        private Button Btn4;
        private Button Btn0;
        private Button Btn9;
        private Button Btn8;
        private Button Btn6;
        private Button Btn5;
        private Button Btn3;
        private Button Btn2;
        private Button BtnSubtract;
        private Button BtnOneOver;
        private Button BtnMultiply;
        private Button button17;
        private Button BtnDivide;
        private Button BtnSqrt;
        private Button BtnAdd;
        private Button BtnEqual;
        private Button BtnMinus;
        private Button BtnPoint;
        private Button BtnMPlus;
        private Button BtnMR;
        private Button BtnMC;
        private Button BtnMS;
        private double Val1 = 0;
        private double Val2 = 0;
        private string Operator = "";
        private Button BtnPercentage;
    }
}