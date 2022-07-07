using System;
using System.Windows.Forms;

namespace UI
{
    public partial class IntroductionForm : Form
    {
        public IntroductionForm()
        {
            InitializeComponent();
            LabelRules.Hide();
            ButtonBack.Hide();
        }

        private void ButtonRules_Click(object sender, EventArgs e)
        {
            const int k_Width = 650;
            const int k_Height = 450;
            string msg;

            this.Width = k_Width;
            this.Height = k_Height;
            ButtonStart.Hide();
            ButtonRules.Hide();
            ButtonBack.Show();
            msg = string.Format(
@"The board is positioned squarely between the players and turned 
so that a dark square is on each player's left-hand side and the 
double-corner on the right.Each player places his Checkers on the
dark squares of the three rows nearest him.The object of the game 
is to prevent the opponent from being able to move when
it is his turn to do so. This is accomplished either by capturing all 
of the opponent's. Checkers, or by blocking those that remain so that
none of them can be moved.
If neither player can accomplish this, the game is a draw.
Single Checkers, known as men, move forward only, one square
at a time in a diagonal direction, to an unoccupied square.
Men and King capture by jumping over an opposing man on a diagonally adjacent
square to the square immediately beyond,but may do so only if this square is unoccupied. 
Men and King may jump forward only, and may continue jumping as long as they encounter 
opposing Checkers with unoccupied squares immediately beyond them. Men and King may never
jump over Checkers of the same color.
A man which reaches the far side of the board,becomes a King. 
The opponent must then crown the new King by placing a Checker of the same color on top it.
Kings move forward or backward, one square at a time in a diagonal
direction to an unoccupied square.
Whenever a player is able to make a capture he must do so. When there is
more than one way to jump, a player may choose any way he wishes, not necessarily
the one which results in the capture of the greatest number of opposing units.
However, once a player chooses asequence of captures, he must make all the captures possible in
that sequence.");
            LabelRules.Text = msg;
            Animate.AnimateWindow(LabelRules.Handle, 1008, Animate.HOR_Positive);
            ButtonBack.Show();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            const int k_Width = 466;
            const int k_Height = 406;

            this.Width = k_Width;
            this.Height = k_Height;
            LabelRules.Hide();
            ButtonBack.Hide();
            Animate.AnimateWindow(ButtonStart.Handle, 1008, Animate.VER_POSITIVE);
            Animate.AnimateWindow(ButtonRules.Handle, 1008, Animate.VER_POSITIVE);
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
