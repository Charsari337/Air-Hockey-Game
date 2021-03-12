
namespace Air_Hockey_Game
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
            this.player1scorelabel = new System.Windows.Forms.Label();
            this.player2scorelabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // player1scorelabel
            // 
            this.player1scorelabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1scorelabel.ForeColor = System.Drawing.Color.Black;
            this.player1scorelabel.Location = new System.Drawing.Point(1, 9);
            this.player1scorelabel.Name = "player1scorelabel";
            this.player1scorelabel.Size = new System.Drawing.Size(38, 23);
            this.player1scorelabel.TabIndex = 0;
            this.player1scorelabel.Text = "0";
            this.player1scorelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player2scorelabel
            // 
            this.player2scorelabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2scorelabel.ForeColor = System.Drawing.Color.Black;
            this.player2scorelabel.Location = new System.Drawing.Point(1, 568);
            this.player2scorelabel.Name = "player2scorelabel";
            this.player2scorelabel.Size = new System.Drawing.Size(38, 23);
            this.player2scorelabel.TabIndex = 1;
            this.player2scorelabel.Text = "0";
            this.player2scorelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.winLabel.Location = new System.Drawing.Point(165, 257);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(210, 32);
            this.winLabel.TabIndex = 2;
            this.winLabel.Text = "Player1 Wins!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 600);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.player2scorelabel);
            this.Controls.Add(this.player1scorelabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label player1scorelabel;
        private System.Windows.Forms.Label player2scorelabel;
        private System.Windows.Forms.Label winLabel;
    }
}

