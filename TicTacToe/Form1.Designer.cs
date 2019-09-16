namespace TicTacToe
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
            this.label1 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.cell02 = new System.Windows.Forms.Button();
            this.cell01 = new System.Windows.Forms.Button();
            this.cell20 = new System.Windows.Forms.Button();
            this.cell21 = new System.Windows.Forms.Button();
            this.cell11 = new System.Windows.Forms.Button();
            this.cell22 = new System.Windows.Forms.Button();
            this.cell10 = new System.Windows.Forms.Button();
            this.cell00 = new System.Windows.Forms.Button();
            this.cell12 = new System.Windows.Forms.Button();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gameModeComputer = new System.Windows.Forms.RadioButton();
            this.gameMode2P = new System.Windows.Forms.RadioButton();
            this.boardPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(209, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 46);
            this.label1.TabIndex = 9;
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(509, 73);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(116, 44);
            this.reset_btn.TabIndex = 12;
            this.reset_btn.TabStop = false;
            this.reset_btn.Text = "RESET";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // cell02
            // 
            this.cell02.AccessibleName = "cell";
            this.cell02.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cell02.Font = new System.Drawing.Font("Courier New", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell02.ForeColor = System.Drawing.Color.Black;
            this.cell02.Location = new System.Drawing.Point(-3, 220);
            this.cell02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cell02.Name = "cell02";
            this.cell02.Size = new System.Drawing.Size(139, 103);
            this.cell02.TabIndex = 6;
            this.cell02.TabStop = false;
            this.cell02.Text = " ";
            this.cell02.UseVisualStyleBackColor = false;
            this.cell02.Click += new System.EventHandler(this.Cell_click);
            // 
            // cell01
            // 
            this.cell01.AccessibleName = "cell";
            this.cell01.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cell01.Font = new System.Drawing.Font("Courier New", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell01.ForeColor = System.Drawing.Color.Black;
            this.cell01.Location = new System.Drawing.Point(-3, 111);
            this.cell01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cell01.Name = "cell01";
            this.cell01.Size = new System.Drawing.Size(139, 103);
            this.cell01.TabIndex = 3;
            this.cell01.TabStop = false;
            this.cell01.Text = " ";
            this.cell01.UseVisualStyleBackColor = false;
            this.cell01.Click += new System.EventHandler(this.Cell_click);
            // 
            // cell20
            // 
            this.cell20.AccessibleName = "cell";
            this.cell20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cell20.Font = new System.Drawing.Font("Courier New", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell20.ForeColor = System.Drawing.Color.Black;
            this.cell20.Location = new System.Drawing.Point(285, 1);
            this.cell20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cell20.Name = "cell20";
            this.cell20.Size = new System.Drawing.Size(139, 103);
            this.cell20.TabIndex = 2;
            this.cell20.TabStop = false;
            this.cell20.Text = " ";
            this.cell20.UseVisualStyleBackColor = false;
            this.cell20.Click += new System.EventHandler(this.Cell_click);
            // 
            // cell21
            // 
            this.cell21.AccessibleName = "cell";
            this.cell21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cell21.Font = new System.Drawing.Font("Courier New", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell21.ForeColor = System.Drawing.Color.Black;
            this.cell21.Location = new System.Drawing.Point(285, 112);
            this.cell21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cell21.Name = "cell21";
            this.cell21.Size = new System.Drawing.Size(139, 102);
            this.cell21.TabIndex = 5;
            this.cell21.TabStop = false;
            this.cell21.Text = " ";
            this.cell21.UseVisualStyleBackColor = false;
            this.cell21.Click += new System.EventHandler(this.Cell_click);
            // 
            // cell11
            // 
            this.cell11.AccessibleName = "cell";
            this.cell11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cell11.Font = new System.Drawing.Font("Courier New", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell11.ForeColor = System.Drawing.Color.Black;
            this.cell11.Location = new System.Drawing.Point(141, 112);
            this.cell11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cell11.Name = "cell11";
            this.cell11.Size = new System.Drawing.Size(139, 103);
            this.cell11.TabIndex = 10;
            this.cell11.TabStop = false;
            this.cell11.Text = " ";
            this.cell11.UseVisualStyleBackColor = false;
            this.cell11.Click += new System.EventHandler(this.Cell_click);
            // 
            // cell22
            // 
            this.cell22.AccessibleName = "cell";
            this.cell22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cell22.Font = new System.Drawing.Font("Courier New", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell22.ForeColor = System.Drawing.Color.Black;
            this.cell22.Location = new System.Drawing.Point(285, 220);
            this.cell22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cell22.Name = "cell22";
            this.cell22.Size = new System.Drawing.Size(139, 103);
            this.cell22.TabIndex = 7;
            this.cell22.TabStop = false;
            this.cell22.Text = " ";
            this.cell22.UseVisualStyleBackColor = false;
            this.cell22.Click += new System.EventHandler(this.Cell_click);
            // 
            // cell10
            // 
            this.cell10.AccessibleName = "cell";
            this.cell10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cell10.Font = new System.Drawing.Font("Courier New", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell10.ForeColor = System.Drawing.Color.Black;
            this.cell10.Location = new System.Drawing.Point(141, 1);
            this.cell10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cell10.Name = "cell10";
            this.cell10.Size = new System.Drawing.Size(139, 103);
            this.cell10.TabIndex = 1;
            this.cell10.TabStop = false;
            this.cell10.Text = " ";
            this.cell10.UseVisualStyleBackColor = false;
            this.cell10.Click += new System.EventHandler(this.Cell_click);
            // 
            // cell00
            // 
            this.cell00.AccessibleName = "cell";
            this.cell00.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cell00.Font = new System.Drawing.Font("Courier New", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell00.ForeColor = System.Drawing.Color.Black;
            this.cell00.Location = new System.Drawing.Point(-3, 1);
            this.cell00.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cell00.Name = "cell00";
            this.cell00.Size = new System.Drawing.Size(139, 103);
            this.cell00.TabIndex = 0;
            this.cell00.TabStop = false;
            this.cell00.UseVisualStyleBackColor = false;
            this.cell00.Click += new System.EventHandler(this.Cell_click);
            // 
            // cell12
            // 
            this.cell12.AccessibleName = "cell";
            this.cell12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cell12.Font = new System.Drawing.Font("Courier New", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cell12.ForeColor = System.Drawing.Color.Black;
            this.cell12.Location = new System.Drawing.Point(141, 220);
            this.cell12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cell12.Name = "cell12";
            this.cell12.Size = new System.Drawing.Size(139, 103);
            this.cell12.TabIndex = 11;
            this.cell12.TabStop = false;
            this.cell12.Text = " ";
            this.cell12.UseVisualStyleBackColor = false;
            this.cell12.Click += new System.EventHandler(this.Cell_click);
            // 
            // boardPanel
            // 
            this.boardPanel.Controls.Add(this.cell22);
            this.boardPanel.Controls.Add(this.cell10);
            this.boardPanel.Controls.Add(this.cell12);
            this.boardPanel.Controls.Add(this.cell02);
            this.boardPanel.Controls.Add(this.cell21);
            this.boardPanel.Controls.Add(this.cell20);
            this.boardPanel.Controls.Add(this.cell01);
            this.boardPanel.Controls.Add(this.cell11);
            this.boardPanel.Controls.Add(this.cell00);
            this.boardPanel.Location = new System.Drawing.Point(201, 171);
            this.boardPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(427, 322);
            this.boardPanel.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gameMode2P);
            this.groupBox1.Controls.Add(this.gameModeComputer);
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(25, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 103);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // gameModeComputer
            // 
            this.gameModeComputer.AutoSize = true;
            this.gameModeComputer.ForeColor = System.Drawing.Color.Snow;
            this.gameModeComputer.Location = new System.Drawing.Point(7, 22);
            this.gameModeComputer.Name = "gameModeComputer";
            this.gameModeComputer.Size = new System.Drawing.Size(141, 21);
            this.gameModeComputer.TabIndex = 0;
            this.gameModeComputer.TabStop = true;
            this.gameModeComputer.Text = "Play vs. computer";
            this.gameModeComputer.UseVisualStyleBackColor = true;
            this.gameModeComputer.CheckedChanged += new System.EventHandler(this.GameModeComputer_CheckedChanged);
            // 
            // gameMode2P
            // 
            this.gameMode2P.AutoSize = true;
            this.gameMode2P.ForeColor = System.Drawing.Color.Snow;
            this.gameMode2P.Location = new System.Drawing.Point(7, 49);
            this.gameMode2P.Name = "gameMode2P";
            this.gameMode2P.Size = new System.Drawing.Size(85, 21);
            this.gameMode2P.TabIndex = 1;
            this.gameMode2P.TabStop = true;
            this.gameMode2P.Text = "2- player";
            this.gameMode2P.UseVisualStyleBackColor = true;
            this.gameMode2P.CheckedChanged += new System.EventHandler(this.GameMode2P_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(961, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.boardPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button cell02;
        private System.Windows.Forms.Button cell01;
        private System.Windows.Forms.Button cell20;
        private System.Windows.Forms.Button cell21;
        private System.Windows.Forms.Button cell11;
        private System.Windows.Forms.Button cell22;
        private System.Windows.Forms.Button cell10;
        private System.Windows.Forms.Button cell00;
        private System.Windows.Forms.Button cell12;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton gameMode2P;
        private System.Windows.Forms.RadioButton gameModeComputer;
    }
}

