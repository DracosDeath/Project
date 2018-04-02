namespace AT1._6
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
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCubeRT = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(9, 32);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(150, 20);
            this.txtDisplay.TabIndex = 38;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(165, 172);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(47, 64);
            this.btnEquals.TabIndex = 37;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(165, 137);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(47, 29);
            this.btnMultiply.TabIndex = 36;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(165, 102);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(47, 29);
            this.btnDivide.TabIndex = 35;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(165, 67);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(47, 29);
            this.btnMinus.TabIndex = 34;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(165, 32);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(47, 29);
            this.btnPlus.TabIndex = 33;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(218, 32);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(58, 29);
            this.btnSqrt.TabIndex = 32;
            this.btnSqrt.Text = "SQRT";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 185);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(46, 29);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(113, 185);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(46, 29);
            this.btnDot.TabIndex = 30;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(61, 185);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(46, 29);
            this.btnZero.TabIndex = 29;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(113, 150);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(46, 29);
            this.btnNine.TabIndex = 28;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(61, 150);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(46, 29);
            this.btnEight.TabIndex = 27;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(9, 150);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(46, 29);
            this.btnSeven.TabIndex = 26;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(113, 115);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(46, 29);
            this.btnSix.TabIndex = 25;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(61, 115);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(46, 29);
            this.btnFive.TabIndex = 24;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(9, 115);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(46, 29);
            this.btnFour.TabIndex = 23;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(113, 80);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(46, 29);
            this.btnThree.TabIndex = 22;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(61, 80);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(46, 29);
            this.btnTwo.TabIndex = 21;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(9, 80);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(46, 29);
            this.btnOne.TabIndex = 20;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCubeRT
            // 
            this.btnCubeRT.Location = new System.Drawing.Point(218, 67);
            this.btnCubeRT.Name = "btnCubeRT";
            this.btnCubeRT.Size = new System.Drawing.Size(58, 29);
            this.btnCubeRT.TabIndex = 40;
            this.btnCubeRT.Text = "CubeRT";
            this.btnCubeRT.UseVisualStyleBackColor = true;
            this.btnCubeRT.Click += new System.EventHandler(this.btnCubeRT_Click);
            // 
            // btnInv
            // 
            this.btnInv.Location = new System.Drawing.Point(218, 102);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(58, 29);
            this.btnInv.TabIndex = 41;
            this.btnInv.Text = "Inv";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(218, 137);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(58, 29);
            this.btnTan.TabIndex = 42;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(218, 172);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(58, 29);
            this.btnSin.TabIndex = 43;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(218, 207);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(58, 29);
            this.btnCos.TabIndex = 44;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 244);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnInv);
            this.Controls.Add(this.btnCubeRT);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnCubeRT;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
    }
}

