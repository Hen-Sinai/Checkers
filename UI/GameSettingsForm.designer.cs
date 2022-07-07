
namespace UI
{
    partial class GameSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSettingsForm));
            this.LableBoardSize = new System.Windows.Forms.Label();
            this.RadioButtonSmallBoardSize = new System.Windows.Forms.RadioButton();
            this.RadioButtonMiddleBoardSize = new System.Windows.Forms.RadioButton();
            this.RadioButtonBigBoardSize = new System.Windows.Forms.RadioButton();
            this.LabelPlayer = new System.Windows.Forms.Label();
            this.LabelPlayer1 = new System.Windows.Forms.Label();
            this.TextBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.TextBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.CheckBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.TimerError = new System.Windows.Forms.Timer(this.components);
            this.ImagePlayer1 = new System.Windows.Forms.PictureBox();
            this.ImagePlayer2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // LableBoardSize
            // 
            this.LableBoardSize.AutoSize = true;
            this.LableBoardSize.BackColor = System.Drawing.Color.Transparent;
            this.LableBoardSize.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableBoardSize.Location = new System.Drawing.Point(8, 22);
            this.LableBoardSize.Name = "LableBoardSize";
            this.LableBoardSize.Size = new System.Drawing.Size(112, 23);
            this.LableBoardSize.TabIndex = 0;
            this.LableBoardSize.Text = "Boad Size:";
            // 
            // RadioButtonSmallBoardSize
            // 
            this.RadioButtonSmallBoardSize.AutoSize = true;
            this.RadioButtonSmallBoardSize.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonSmallBoardSize.Checked = true;
            this.RadioButtonSmallBoardSize.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonSmallBoardSize.Location = new System.Drawing.Point(15, 61);
            this.RadioButtonSmallBoardSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonSmallBoardSize.Name = "RadioButtonSmallBoardSize";
            this.RadioButtonSmallBoardSize.Size = new System.Drawing.Size(74, 25);
            this.RadioButtonSmallBoardSize.TabIndex = 1;
            this.RadioButtonSmallBoardSize.TabStop = true;
            this.RadioButtonSmallBoardSize.Text = "6 x 6";
            this.RadioButtonSmallBoardSize.UseVisualStyleBackColor = false;
            this.RadioButtonSmallBoardSize.CheckedChanged += new System.EventHandler(this.SmallBoardSize_CheckedChanged);
            // 
            // RadioButtonMiddleBoardSize
            // 
            this.RadioButtonMiddleBoardSize.AutoSize = true;
            this.RadioButtonMiddleBoardSize.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonMiddleBoardSize.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMiddleBoardSize.Location = new System.Drawing.Point(90, 61);
            this.RadioButtonMiddleBoardSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonMiddleBoardSize.Name = "RadioButtonMiddleBoardSize";
            this.RadioButtonMiddleBoardSize.Size = new System.Drawing.Size(74, 25);
            this.RadioButtonMiddleBoardSize.TabIndex = 2;
            this.RadioButtonMiddleBoardSize.Text = "8 x 8";
            this.RadioButtonMiddleBoardSize.UseVisualStyleBackColor = false;
            this.RadioButtonMiddleBoardSize.CheckedChanged += new System.EventHandler(this.MiddleBoardSize_CheckedChanged);
            // 
            // RadioButtonBigBoardSize
            // 
            this.RadioButtonBigBoardSize.AutoSize = true;
            this.RadioButtonBigBoardSize.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonBigBoardSize.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonBigBoardSize.Location = new System.Drawing.Point(172, 61);
            this.RadioButtonBigBoardSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonBigBoardSize.Name = "RadioButtonBigBoardSize";
            this.RadioButtonBigBoardSize.Size = new System.Drawing.Size(96, 25);
            this.RadioButtonBigBoardSize.TabIndex = 3;
            this.RadioButtonBigBoardSize.Text = "10 x 10";
            this.RadioButtonBigBoardSize.UseVisualStyleBackColor = false;
            this.RadioButtonBigBoardSize.CheckedChanged += new System.EventHandler(this.BigBoardSize_CheckedChanged);
            // 
            // LabelPlayer
            // 
            this.LabelPlayer.AutoSize = true;
            this.LabelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.LabelPlayer.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlayer.Location = new System.Drawing.Point(11, 119);
            this.LabelPlayer.Name = "LabelPlayer";
            this.LabelPlayer.Size = new System.Drawing.Size(92, 23);
            this.LabelPlayer.TabIndex = 4;
            this.LabelPlayer.Text = "Players:";
            // 
            // LabelPlayer1
            // 
            this.LabelPlayer1.AutoSize = true;
            this.LabelPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.LabelPlayer1.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlayer1.Location = new System.Drawing.Point(86, 157);
            this.LabelPlayer1.Name = "LabelPlayer1";
            this.LabelPlayer1.Size = new System.Drawing.Size(95, 21);
            this.LabelPlayer1.TabIndex = 5;
            this.LabelPlayer1.Text = "Player1: ";
            // 
            // TextBoxPlayer1
            // 
            this.TextBoxPlayer1.Location = new System.Drawing.Point(217, 158);
            this.TextBoxPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxPlayer1.Name = "TextBoxPlayer1";
            this.TextBoxPlayer1.Size = new System.Drawing.Size(111, 22);
            this.TextBoxPlayer1.TabIndex = 7;
            this.TextBoxPlayer1.TextChanged += new System.EventHandler(this.TextBoxPlayer1_TextChanged);
            // 
            // TextBoxPlayer2
            // 
            this.TextBoxPlayer2.Enabled = false;
            this.TextBoxPlayer2.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPlayer2.Location = new System.Drawing.Point(217, 201);
            this.TextBoxPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxPlayer2.Name = "TextBoxPlayer2";
            this.TextBoxPlayer2.Size = new System.Drawing.Size(111, 25);
            this.TextBoxPlayer2.TabIndex = 8;
            this.TextBoxPlayer2.Text = "[Computer]";
            this.TextBoxPlayer2.TextChanged += new System.EventHandler(this.TextBoxPlayer2_TextChanged);
            // 
            // CheckBoxPlayer2
            // 
            this.CheckBoxPlayer2.AutoSize = true;
            this.CheckBoxPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxPlayer2.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxPlayer2.Location = new System.Drawing.Point(90, 202);
            this.CheckBoxPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxPlayer2.Name = "CheckBoxPlayer2";
            this.CheckBoxPlayer2.Size = new System.Drawing.Size(117, 25);
            this.CheckBoxPlayer2.TabIndex = 9;
            this.CheckBoxPlayer2.Text = "Playre 2:";
            this.CheckBoxPlayer2.UseVisualStyleBackColor = false;
            this.CheckBoxPlayer2.CheckedChanged += new System.EventHandler(this.CheckBoxPlayer2_CheckedChanged);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Transparent;
            this.buttonDone.BackgroundImage = global::UI.Properties.Resources.white;
            this.buttonDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDone.Location = new System.Drawing.Point(296, 240);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(92, 34);
            this.buttonDone.TabIndex = 10;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.ButtonDone_Click);
            // 
            // TimerError
            // 
            this.TimerError.Interval = 10;
            this.TimerError.Tick += new System.EventHandler(this.TimerError_Tick);
            // 
            // ImagePlayer1
            // 
            this.ImagePlayer1.BackColor = System.Drawing.Color.Transparent;
            this.ImagePlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagePlayer1.Image = global::UI.Properties.Resources.BackgroundEraserPinkMan;
            this.ImagePlayer1.Location = new System.Drawing.Point(44, 143);
            this.ImagePlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.ImagePlayer1.Name = "ImagePlayer1";
            this.ImagePlayer1.Size = new System.Drawing.Size(58, 49);
            this.ImagePlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePlayer1.TabIndex = 20;
            this.ImagePlayer1.TabStop = false;
            // 
            // ImagePlayer2
            // 
            this.ImagePlayer2.BackColor = System.Drawing.Color.Transparent;
            this.ImagePlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagePlayer2.Image = global::UI.Properties.Resources.BackgroundEraserBlueMan;
            this.ImagePlayer2.Location = new System.Drawing.Point(44, 187);
            this.ImagePlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.ImagePlayer2.Name = "ImagePlayer2";
            this.ImagePlayer2.Size = new System.Drawing.Size(58, 49);
            this.ImagePlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePlayer2.TabIndex = 21;
            this.ImagePlayer2.TabStop = false;
            // 
            // GameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(426, 298);
            this.Controls.Add(this.CheckBoxPlayer2);
            this.Controls.Add(this.LabelPlayer1);
            this.Controls.Add(this.ImagePlayer2);
            this.Controls.Add(this.ImagePlayer1);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.TextBoxPlayer2);
            this.Controls.Add(this.TextBoxPlayer1);
            this.Controls.Add(this.LabelPlayer);
            this.Controls.Add(this.RadioButtonBigBoardSize);
            this.Controls.Add(this.RadioButtonMiddleBoardSize);
            this.Controls.Add(this.RadioButtonSmallBoardSize);
            this.Controls.Add(this.LableBoardSize);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.GameSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LableBoardSize;
        private System.Windows.Forms.RadioButton RadioButtonSmallBoardSize;
        private System.Windows.Forms.RadioButton RadioButtonMiddleBoardSize;
        private System.Windows.Forms.RadioButton RadioButtonBigBoardSize;
        private System.Windows.Forms.Label LabelPlayer;
        private System.Windows.Forms.Label LabelPlayer1;
        private System.Windows.Forms.TextBox TextBoxPlayer1;
        private System.Windows.Forms.TextBox TextBoxPlayer2;
        private System.Windows.Forms.CheckBox CheckBoxPlayer2;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Timer TimerError;
        private System.Windows.Forms.PictureBox ImagePlayer1;
        private System.Windows.Forms.PictureBox ImagePlayer2;
    }
}