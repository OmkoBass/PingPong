namespace Ping_Pong
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.P1 = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.BotScore = new System.Windows.Forms.Label();
            this.Bot1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // P1
            // 
            this.P1.AutoSize = true;
            this.P1.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1.Location = new System.Drawing.Point(12, 473);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(82, 25);
            this.P1.TabIndex = 0;
            this.P1.Text = "Player:";
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScore.Location = new System.Drawing.Point(82, 473);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(22, 25);
            this.PlayerScore.TabIndex = 1;
            this.PlayerScore.Text = "0";
            // 
            // BotScore
            // 
            this.BotScore.AutoSize = true;
            this.BotScore.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotScore.Location = new System.Drawing.Point(768, 473);
            this.BotScore.Name = "BotScore";
            this.BotScore.Size = new System.Drawing.Size(22, 25);
            this.BotScore.TabIndex = 3;
            this.BotScore.Text = "0";
            // 
            // Bot1
            // 
            this.Bot1.AutoSize = true;
            this.Bot1.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bot1.Location = new System.Drawing.Point(720, 473);
            this.Bot1.Name = "Bot1";
            this.Bot1.Size = new System.Drawing.Size(42, 25);
            this.Bot1.TabIndex = 2;
            this.Bot1.Text = "Bot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 526);
            this.Controls.Add(this.BotScore);
            this.Controls.Add(this.Bot1);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.P1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Ping Pong";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.Label Bot1;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label BotScore;
    }
}

