namespace RockPaperScissors
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
            this.btnGo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblRobot = new System.Windows.Forms.Label();
            this.lblYou = new System.Windows.Forms.Label();
            this.rbtnRock = new System.Windows.Forms.RadioButton();
            this.rbtnPaper = new System.Windows.Forms.RadioButton();
            this.rbtnScissors = new System.Windows.Forms.RadioButton();
            this.gbxChoices = new System.Windows.Forms.GroupBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbRobot = new System.Windows.Forms.PictureBox();
            this.pbxUserWeap = new System.Windows.Forms.PictureBox();
            this.pbxRobotWeap = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.gbxChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRobot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserWeap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRobotWeap)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(102, 513);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(364, 59);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Battle!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTies);
            this.panel1.Controls.Add(this.lblLoss);
            this.panel1.Controls.Add(this.lblWins);
            this.panel1.Location = new System.Drawing.Point(870, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 100);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loss:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ties:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wins:";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Location = new System.Drawing.Point(250, 40);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(16, 17);
            this.lblTies.TabIndex = 2;
            this.lblTies.Text = "0";
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.Location = new System.Drawing.Point(250, 69);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(16, 17);
            this.lblLoss.TabIndex = 1;
            this.lblLoss.Text = "0";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(250, 13);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(16, 17);
            this.lblWins.TabIndex = 0;
            this.lblWins.Text = "0";
            // 
            // lblRobot
            // 
            this.lblRobot.AutoSize = true;
            this.lblRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRobot.Location = new System.Drawing.Point(1084, 279);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(103, 38);
            this.lblRobot.TabIndex = 5;
            this.lblRobot.Text = "label1";
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYou.Location = new System.Drawing.Point(46, 279);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(103, 38);
            this.lblYou.TabIndex = 7;
            this.lblYou.Text = "label1";
            // 
            // rbtnRock
            // 
            this.rbtnRock.AutoSize = true;
            this.rbtnRock.Location = new System.Drawing.Point(46, 21);
            this.rbtnRock.Name = "rbtnRock";
            this.rbtnRock.Size = new System.Drawing.Size(61, 21);
            this.rbtnRock.TabIndex = 8;
            this.rbtnRock.TabStop = true;
            this.rbtnRock.Text = "Rock";
            this.rbtnRock.UseVisualStyleBackColor = true;
            this.rbtnRock.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // rbtnPaper
            // 
            this.rbtnPaper.AutoSize = true;
            this.rbtnPaper.Location = new System.Drawing.Point(175, 21);
            this.rbtnPaper.Name = "rbtnPaper";
            this.rbtnPaper.Size = new System.Drawing.Size(67, 21);
            this.rbtnPaper.TabIndex = 9;
            this.rbtnPaper.TabStop = true;
            this.rbtnPaper.Text = "Paper";
            this.rbtnPaper.UseVisualStyleBackColor = true;
            this.rbtnPaper.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // rbtnScissors
            // 
            this.rbtnScissors.AutoSize = true;
            this.rbtnScissors.Location = new System.Drawing.Point(320, 21);
            this.rbtnScissors.Name = "rbtnScissors";
            this.rbtnScissors.Size = new System.Drawing.Size(82, 21);
            this.rbtnScissors.TabIndex = 10;
            this.rbtnScissors.TabStop = true;
            this.rbtnScissors.Text = "Scissors";
            this.rbtnScissors.UseVisualStyleBackColor = true;
            this.rbtnScissors.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // gbxChoices
            // 
            this.gbxChoices.Controls.Add(this.rbtnPaper);
            this.gbxChoices.Controls.Add(this.rbtnRock);
            this.gbxChoices.Controls.Add(this.rbtnScissors);
            this.gbxChoices.Location = new System.Drawing.Point(66, 434);
            this.gbxChoices.Name = "gbxChoices";
            this.gbxChoices.Size = new System.Drawing.Size(432, 61);
            this.gbxChoices.TabIndex = 11;
            this.gbxChoices.TabStop = false;
            this.gbxChoices.Text = "Weapons";
            // 
            // pbUser
            // 
            this.pbUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbUser.Image = global::RockPaperScissors.Properties.Resources.you1;
            this.pbUser.Location = new System.Drawing.Point(0, 0);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(200, 603);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUser.TabIndex = 6;
            this.pbUser.TabStop = false;
            // 
            // pbRobot
            // 
            this.pbRobot.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbRobot.Image = global::RockPaperScissors.Properties.Resources.robot1;
            this.pbRobot.Location = new System.Drawing.Point(1036, 0);
            this.pbRobot.Name = "pbRobot";
            this.pbRobot.Size = new System.Drawing.Size(200, 603);
            this.pbRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRobot.TabIndex = 3;
            this.pbRobot.TabStop = false;
            // 
            // pbxUserWeap
            // 
            this.pbxUserWeap.Image = global::RockPaperScissors.Properties.Resources.Scissors;
            this.pbxUserWeap.Location = new System.Drawing.Point(386, 204);
            this.pbxUserWeap.Name = "pbxUserWeap";
            this.pbxUserWeap.Size = new System.Drawing.Size(100, 81);
            this.pbxUserWeap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxUserWeap.TabIndex = 12;
            this.pbxUserWeap.TabStop = false;
            // 
            // pbxRobotWeap
            // 
            this.pbxRobotWeap.Image = global::RockPaperScissors.Properties.Resources.Rock;
            this.pbxRobotWeap.Location = new System.Drawing.Point(779, 196);
            this.pbxRobotWeap.Name = "pbxRobotWeap";
            this.pbxRobotWeap.Size = new System.Drawing.Size(100, 89);
            this.pbxRobotWeap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxRobotWeap.TabIndex = 13;
            this.pbxRobotWeap.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(190, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(489, 55);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "Rock Paper Scissors";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblResult);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 100);
            this.panel2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 603);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbxRobotWeap);
            this.Controls.Add(this.pbxUserWeap);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.gbxChoices);
            this.Controls.Add(this.lblYou);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.lblRobot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbRobot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxChoices.ResumeLayout(false);
            this.gbxChoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRobot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserWeap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRobotWeap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PictureBox pbRobot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Label lblLoss;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblRobot;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.RadioButton rbtnRock;
        private System.Windows.Forms.RadioButton rbtnPaper;
        private System.Windows.Forms.RadioButton rbtnScissors;
        private System.Windows.Forms.GroupBox gbxChoices;
        private System.Windows.Forms.PictureBox pbxUserWeap;
        private System.Windows.Forms.PictureBox pbxRobotWeap;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
