namespace ShimAdder
{
    partial class Form1
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
            this.enterButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.enterTB = new System.Windows.Forms.TextBox();
            this.totalWeightTB = new System.Windows.Forms.TextBox();
            this.runningTotalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.avgShimWeightTB = new System.Windows.Forms.TextBox();
            this.stdDShimWeightTB = new System.Windows.Forms.TextBox();
            this.MShimeWeightTB = new System.Windows.Forms.TextBox();
            this.mShimWeightTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalInputsTB = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WLeftTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WLTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(160, 464);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(158, 78);
            this.enterButton.TabIndex = 0;
            this.enterButton.TabStop = false;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(35, 559);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(158, 78);
            this.undoButton.TabIndex = 1;
            this.undoButton.TabStop = false;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(281, 557);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(158, 78);
            this.clearbutton.TabIndex = 2;
            this.clearbutton.TabStop = false;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // enterTB
            // 
            this.enterTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.enterTB.Location = new System.Drawing.Point(151, 394);
            this.enterTB.Name = "enterTB";
            this.enterTB.Size = new System.Drawing.Size(180, 64);
            this.enterTB.TabIndex = 3;
            this.enterTB.Text = "0";
            this.enterTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalWeightTB
            // 
            this.totalWeightTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.totalWeightTB.Location = new System.Drawing.Point(93, 190);
            this.totalWeightTB.Name = "totalWeightTB";
            this.totalWeightTB.ReadOnly = true;
            this.totalWeightTB.Size = new System.Drawing.Size(294, 158);
            this.totalWeightTB.TabIndex = 4;
            this.totalWeightTB.TabStop = false;
            this.totalWeightTB.Text = "0";
            this.totalWeightTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // runningTotalLabel
            // 
            this.runningTotalLabel.AutoSize = true;
            this.runningTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.runningTotalLabel.Location = new System.Drawing.Point(22, 65);
            this.runningTotalLabel.Name = "runningTotalLabel";
            this.runningTotalLabel.Size = new System.Drawing.Size(446, 76);
            this.runningTotalLabel.TabIndex = 5;
            this.runningTotalLabel.Text = "Running Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(654, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Average Shim Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(654, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "Std Dev of Shim Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(654, 603);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max Shim Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(654, 712);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 46);
            this.label4.TabIndex = 9;
            this.label4.Text = "Min Shim Weight";
            // 
            // avgShimWeightTB
            // 
            this.avgShimWeightTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.avgShimWeightTB.Location = new System.Drawing.Point(515, 381);
            this.avgShimWeightTB.MaxLength = 5;
            this.avgShimWeightTB.Name = "avgShimWeightTB";
            this.avgShimWeightTB.ReadOnly = true;
            this.avgShimWeightTB.Size = new System.Drawing.Size(118, 64);
            this.avgShimWeightTB.TabIndex = 10;
            this.avgShimWeightTB.TabStop = false;
            this.avgShimWeightTB.Text = "0";
            this.avgShimWeightTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // stdDShimWeightTB
            // 
            this.stdDShimWeightTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.stdDShimWeightTB.Location = new System.Drawing.Point(515, 481);
            this.stdDShimWeightTB.MaxLength = 5;
            this.stdDShimWeightTB.Name = "stdDShimWeightTB";
            this.stdDShimWeightTB.ReadOnly = true;
            this.stdDShimWeightTB.Size = new System.Drawing.Size(118, 64);
            this.stdDShimWeightTB.TabIndex = 11;
            this.stdDShimWeightTB.TabStop = false;
            this.stdDShimWeightTB.Text = "0";
            this.stdDShimWeightTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MShimeWeightTB
            // 
            this.MShimeWeightTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MShimeWeightTB.Location = new System.Drawing.Point(515, 590);
            this.MShimeWeightTB.Name = "MShimeWeightTB";
            this.MShimeWeightTB.ReadOnly = true;
            this.MShimeWeightTB.Size = new System.Drawing.Size(118, 64);
            this.MShimeWeightTB.TabIndex = 12;
            this.MShimeWeightTB.TabStop = false;
            this.MShimeWeightTB.Text = "0";
            this.MShimeWeightTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mShimWeightTB
            // 
            this.mShimWeightTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.mShimWeightTB.Location = new System.Drawing.Point(515, 699);
            this.mShimWeightTB.Name = "mShimWeightTB";
            this.mShimWeightTB.ReadOnly = true;
            this.mShimWeightTB.Size = new System.Drawing.Size(118, 64);
            this.mShimWeightTB.TabIndex = 13;
            this.mShimWeightTB.TabStop = false;
            this.mShimWeightTB.Text = "0";
            this.mShimWeightTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(654, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 46);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Inputs";
            // 
            // totalInputsTB
            // 
            this.totalInputsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.totalInputsTB.Location = new System.Drawing.Point(515, 278);
            this.totalInputsTB.Name = "totalInputsTB";
            this.totalInputsTB.ReadOnly = true;
            this.totalInputsTB.Size = new System.Drawing.Size(118, 64);
            this.totalInputsTB.TabIndex = 15;
            this.totalInputsTB.TabStop = false;
            this.totalInputsTB.Text = "0";
            this.totalInputsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 52);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.openToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(111, 48);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(104, 48);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // WLeftTB
            // 
            this.WLeftTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.WLeftTB.Location = new System.Drawing.Point(515, 180);
            this.WLeftTB.Name = "WLeftTB";
            this.WLeftTB.ReadOnly = true;
            this.WLeftTB.Size = new System.Drawing.Size(118, 64);
            this.WLeftTB.TabIndex = 18;
            this.WLeftTB.TabStop = false;
            this.WLeftTB.Text = "0";
            this.WLeftTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(654, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 46);
            this.label6.TabIndex = 17;
            this.label6.Text = "Weight until Limt";
            // 
            // WLTB
            // 
            this.WLTB.AcceptsTab = true;
            this.WLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.WLTB.Location = new System.Drawing.Point(184, 654);
            this.WLTB.Name = "WLTB";
            this.WLTB.Size = new System.Drawing.Size(118, 102);
            this.WLTB.TabIndex = 2;
            this.WLTB.TabStop = false;
            this.WLTB.Text = "5";
            this.WLTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(134, 771);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 46);
            this.label7.TabIndex = 21;
            this.label7.Text = "Weight limit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 868);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WLTB);
            this.Controls.Add(this.WLeftTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalInputsTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mShimWeightTB);
            this.Controls.Add(this.MShimeWeightTB);
            this.Controls.Add(this.stdDShimWeightTB);
            this.Controls.Add(this.avgShimWeightTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runningTotalLabel);
            this.Controls.Add(this.totalWeightTB);
            this.Controls.Add(this.enterTB);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Shim Adder V0.02";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.TextBox enterTB;
        private System.Windows.Forms.TextBox totalWeightTB;
        private System.Windows.Forms.Label runningTotalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox avgShimWeightTB;
        private System.Windows.Forms.TextBox stdDShimWeightTB;
        private System.Windows.Forms.TextBox MShimeWeightTB;
        private System.Windows.Forms.TextBox mShimWeightTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalInputsTB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox WLeftTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox WLTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

