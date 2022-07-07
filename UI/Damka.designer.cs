
namespace UI
{
    partial class Damka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Damka));
            this.LablePlayer1Name = new System.Windows.Forms.Label();
            this.LablePlayer2Name = new System.Windows.Forms.Label();
            this.TimerComputerMove = new System.Windows.Forms.Timer(this.components);
            this.FadeInFormTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LablePlayer1Name
            // 
            this.LablePlayer1Name.AutoSize = true;
            this.LablePlayer1Name.BackColor = System.Drawing.Color.Transparent;
            this.LablePlayer1Name.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LablePlayer1Name.Location = new System.Drawing.Point(44, 29);
            this.LablePlayer1Name.Name = "LablePlayer1Name";
            this.LablePlayer1Name.Size = new System.Drawing.Size(144, 23);
            this.LablePlayer1Name.TabIndex = 0;
            this.LablePlayer1Name.Text = "Player1 Name";
            // 
            // LablePlayer2Name
            // 
            this.LablePlayer2Name.AutoSize = true;
            this.LablePlayer2Name.BackColor = System.Drawing.Color.Transparent;
            this.LablePlayer2Name.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LablePlayer2Name.Location = new System.Drawing.Point(251, 29);
            this.LablePlayer2Name.Name = "LablePlayer2Name";
            this.LablePlayer2Name.Size = new System.Drawing.Size(145, 23);
            this.LablePlayer2Name.TabIndex = 1;
            this.LablePlayer2Name.Text = "Player2 Name";
            // 
            // TimerComputerMove
            // 
            this.TimerComputerMove.Tick += new System.EventHandler(this.TimerComputerMove_Tick);
            // 
            // FadeInFormTimer
            // 
            this.FadeInFormTimer.Tick += new System.EventHandler(this.fadeInFormTimer_Tick);
            // 
            // Damka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(425, 355);
            this.Controls.Add(this.LablePlayer2Name);
            this.Controls.Add(this.LablePlayer1Name);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Damka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Damka";
            this.Load += new System.EventHandler(this.damka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LablePlayer1Name;
        private System.Windows.Forms.Label LablePlayer2Name;
        private System.Windows.Forms.Timer TimerComputerMove;
        private System.Windows.Forms.Timer FadeInFormTimer;
    }
}