using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class GameSettingsForm : Form
    {
        private readonly GameSettings r_GameSettings = new GameSettings();

        public GameSettingsForm()
        {
            InitializeComponent();
            this.TimerError.Interval = 500;
            this.TimerError.Tick += new EventHandler(this.TimerError_Tick);
        }

        public GameSettings GameSettings
        {
            get
            {
                return r_GameSettings;
            }
        }

        private void SmallBoardSize_CheckedChanged(object sender, EventArgs e)
        {
            r_GameSettings.BoardSize = eBoardSize.Small;
        }

        private void MiddleBoardSize_CheckedChanged(object sender, EventArgs e)
        {
            r_GameSettings.BoardSize = eBoardSize.Medium;
        }

        private void BigBoardSize_CheckedChanged(object sender, EventArgs e)
        {
            r_GameSettings.BoardSize = eBoardSize.Large;
        }

        private void CheckBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPlayer2.Enabled = !TextBoxPlayer2.Enabled;
            r_GameSettings.isAi = !r_GameSettings.isAi;
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            if (r_GameSettings.Player1Name == null || r_GameSettings.Player1Name.Length == 0 ||
                r_GameSettings.Player2Name.Length == 0)
            {
                buttonDone.BackColor = Color.Red;
                buttonDone.ForeColor = Color.Red;
                TimerError.Start();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void TextBoxPlayer1_TextChanged(object sender, EventArgs e)
        {
            r_GameSettings.Player1Name = TextBoxPlayer1.Text;
        }

        private void TextBoxPlayer2_TextChanged(object sender, EventArgs e)
        {
            r_GameSettings.Player2Name = TextBoxPlayer2.Text;
        }

        private void GameSettingsForm_Load(object sender, EventArgs e)
        {
            Animate.AnimateWindow(this.Handle, 1008, Animate.CENTER);
        }

        private void TimerError_Tick(object sender, EventArgs e)
        {
            if (buttonDone.BackColor == Color.Red)
            {
                TimerError.Stop();
                buttonDone.BackColor = Color.White;
                buttonDone.ForeColor = Color.Black;
            }
        }
    }
}