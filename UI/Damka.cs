using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GameLogic;


namespace UI
{
    public partial class Damka : Form
    {
        private readonly IntroductionForm r_introductionForm;
        private readonly GameSettingsForm r_GameSettingsForm;
        private readonly GameManager r_GameManager;
        private readonly CellButton[,] r_ButtonMatrix;
        private readonly Bitmap r_cursorImage;
        private PictureBox m_PictureBoxPlayer1;
        private PictureBox m_PictureBoxPlayer2;
        private bool m_isPlayerCanEat = false;
        
        public Damka()
        {
            eBoardSize boardSize;
            InitializeComponent();
            r_introductionForm = new IntroductionForm();
            Application.Run(r_introductionForm);
            r_GameSettingsForm = new GameSettingsForm();
            if (r_introductionForm.DialogResult == DialogResult.OK)
            {
                Application.Run(r_GameSettingsForm);
            }
            else
            {
                r_GameSettingsForm.DialogResult = DialogResult.None;
            }

            if (r_GameSettingsForm.DialogResult == DialogResult.OK)
            {
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.TimerComputerMove.Interval = 500;
                this.TimerComputerMove.Enabled = false;
                this.TimerComputerMove.Tick += new EventHandler(this.TimerComputerMove_Tick);
                boardSize = r_GameSettingsForm.GameSettings.BoardSize;
                r_ButtonMatrix = new CellButton[(int)boardSize, (int)boardSize];
                initializeBoardDimensions(boardSize);
                r_cursorImage = new Bitmap(Properties.Resources.cursor, 100, 150);
                r_GameManager = new GameManager((int)boardSize, (int)boardSize, r_GameSettingsForm.GameSettings.isAi, r_GameSettingsForm.GameSettings.Player1Name, r_GameSettingsForm.GameSettings.Player2Name);
                initializePlayersScorePosition();
                initializePlayersSoldierPhotoPosition();
                startGame();
            }
            else
            {
                this.Close();
            }
        }

        private void initializeBoardDimensions(eBoardSize i_BoardSize)
        {
            const int k_MultiplyBySmall = 100;
            const int k_MultiplyByMedium = 70;
            const int k_MultiplyByLarge = 60;
            int size= k_MultiplyByLarge;

            switch (i_BoardSize)
            {
                case eBoardSize.Small:
                    size = (int)eBoardSize.Small * k_MultiplyBySmall;
                    break;
                case eBoardSize.Medium:
                    size = (int)eBoardSize.Medium * k_MultiplyByMedium;
                    break;
                case eBoardSize.Large:
                    size = (int)eBoardSize.Large * k_MultiplyByLarge;
                    break;
                default:
                    break;
            }

            this.Height = this.Width= size;
        }

        private void damka_Load(object sender, EventArgs e)
        {
            const int k_FadeInFormTimerInterval = 120;
            Bitmap cursorImage;

            cursorImage = new Bitmap(Properties.Resources.cursor, 100, 150);
            Cursor = new Cursor(cursorImage.GetHicon());
            FadeInFormTimer.Interval = k_FadeInFormTimerInterval;
            FadeInFormTimer.Tick += new EventHandler(fadeInFormTimer_Tick);
        }

        private void initializePlayersScorePosition()
        {
            int width = (int)r_GameSettingsForm.GameSettings.BoardSize;
            int cellSize = this.Width / (width + 2);

            this.LablePlayer1Name.Left = cellSize * 2;
            this.LablePlayer2Name.Left = this.LablePlayer1Name.Left + (cellSize * width / 2);
        }

        private void initializePlayersSoldierPhotoPosition()
        {
            m_PictureBoxPlayer1 = new PictureBox();
            m_PictureBoxPlayer2 = new PictureBox();

            int width = (int)r_GameSettingsForm.GameSettings.BoardSize;
            int cellSize = this.Width / (width + 2);
            m_PictureBoxPlayer1.Image = Properties.Resources.BackgroundEraserPinkMan;
            m_PictureBoxPlayer2.Image = Properties.Resources.BackgroundEraserBlueMan;
            m_PictureBoxPlayer1.Left = cellSize;
            m_PictureBoxPlayer2.Left = LablePlayer1Name.Left + (cellSize * (width / 2 - 1));
            m_PictureBoxPlayer1.Width = m_PictureBoxPlayer1.Height = cellSize;
            m_PictureBoxPlayer2.Width = m_PictureBoxPlayer2.Height = cellSize;
            m_PictureBoxPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
            m_PictureBoxPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
            m_PictureBoxPlayer1.BackColor = Color.Transparent;
            m_PictureBoxPlayer2.BackColor = Color.Transparent;
            this.Controls.Add(m_PictureBoxPlayer1);
            this.Controls.Add(m_PictureBoxPlayer2);
            m_PictureBoxPlayer2.Hide();
        }

        private void initializeButtonsMatrix()
        {
            Location location;
            int cellSize;
            int width;
            int length;

            width = (int)r_GameSettingsForm.GameSettings.BoardSize;
            length = (int)r_GameSettingsForm.GameSettings.BoardSize;
            cellSize = this.Width / (width + 2);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    location = new Location((i + 1) * cellSize, (j + 1) * cellSize);
                    r_ButtonMatrix[i, j] = new CellButton(location, cellSize, i, j);
                    r_ButtonMatrix[i, j].FlatStyle = FlatStyle.Flat;
                    if ((i + 1 < width / 2) && ((j % 2 != 0 && i % 2 == 0) || (j % 2 == 0 && i % 2 != 0)))
                    {
                        r_ButtonMatrix[i, j].BackgroundImage = Properties.Resources.PinkMan;
                        r_ButtonMatrix[i, j].OriginImage = Properties.Resources.PinkMan;
                    }
                    else if ((i > (width / 2)) && ((j % 2 == 0 && i % 2 != 0) || (j % 2 != 0 && i % 2 == 0)))
                    {
                        r_ButtonMatrix[i, j].BackgroundImage = Properties.Resources.BlueMan;
                        r_ButtonMatrix[i, j].OriginImage = Properties.Resources.BlueMan;

                    }
                    else if ((i + j) % 2 == 0)
                    {
                        r_ButtonMatrix[i, j].BackgroundImage = Properties.Resources.black;
                        r_ButtonMatrix[i, j].OriginImage = Properties.Resources.black;
                        r_ButtonMatrix[i, j].Enabled = false;
                    }
                    else
                    {
                        r_ButtonMatrix[i, j].BackgroundImage = Properties.Resources.white;
                        r_ButtonMatrix[i, j].OriginImage = Properties.Resources.white;
                    }
                    r_ButtonMatrix[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    this.Controls.Add(r_ButtonMatrix[i, j]);
                    r_ButtonMatrix[i, j].Click += new EventHandler(cellButton_Click);
                    r_ButtonMatrix[i, j].Click += new EventHandler(cellButton_ClickMark);
                    r_ButtonMatrix[i, j].MouseHover += new EventHandler(cellButton_MouseHover);
                    r_ButtonMatrix[i, j].MouseLeave += new EventHandler(cellButton_MouseLeave);
                    this.Opacity = 0;
                    FadeInFormTimer.Start();
                }
            }
        }

        private void initializeFirstPlayerMoves()
        {
            r_GameManager.AddAllMovesToList(out m_isPlayerCanEat);
        }

        private void startGame()
        {
            string player1, player2;

            r_GameManager.ResetGame();
            updatePlayersSoldierPhotoPosition();
            initializeButtonsMatrix();
            initializeFirstPlayerMoves();
            player1 =
                    string.Format(
@"{0} : {1}",
r_GameSettingsForm.GameSettings.Player1Name, r_GameManager.Player1.Score);
            player2 =
                    string.Format(
@"{0} : {1}",
r_GameSettingsForm.GameSettings.Player2Name, r_GameManager.Player2.Score);
            this.LablePlayer1Name.Text = player1;
            this.LablePlayer2Name.Text = player2;
        }

        private void cellButton_ClickError(object sender, EventArgs e)
        {
            invalidMoveTextBox();
        }

        private void cellButton_Click(object sender, EventArgs e)
        {
           clickImage();
        }

        private void cellButton_ClickMark(object sender, EventArgs e)
        {
            const int k_ColIndex = 0;
            const int k_RowIndex = 1;
            const bool v_Remove = false;
            int row, col;
            CellButton clickedCellButton;

            clickedCellButton = (CellButton)sender;
            row = clickedCellButton.Row;
            col = clickedCellButton.Col;
            if (ValidatePos(clickedCellButton, k_ColIndex, k_RowIndex))
            {
                setPlayerImageClicked(clickedCellButton, row, col);
                updateValidMove(clickedCellButton);
                updateCellsForEventMove(v_Remove);
                r_ButtonMatrix[row, col].Click -= new EventHandler(cellButton_ClickMark);
                r_ButtonMatrix[row, col].Click += new EventHandler(cellButton_ClickUnmark);
            }
        }

        private void cellButton_ClickMovePlayer(object sender, EventArgs e)
        {
            CellButton clickedCellButton;
            int row, col, lastRow, lastCol;
            const int k_ColIndex = 3;
            const int k_RowIndex = 4;
            const bool k_remove = true;
            List<string> move;

            clickedCellButton = (CellButton)sender;
            row = clickedCellButton.Row;
            col = clickedCellButton.Col;
            move = r_GameManager.GetPlayerMovesList(); 
            lastCol = move[0][0] - 'A';
            lastRow = move[0][1] - 'a';
            if (ValidatePos(clickedCellButton, k_ColIndex, k_RowIndex))
            {
                updateCellsForEventMove(k_remove);
                updateEventsHandler(lastRow, lastCol);
                r_GameManager.MovePlayer(convertToMoveFormat(row, col), ref m_isPlayerCanEat);
                printBoard();
                if (!m_isPlayerCanEat)
                {
                    if (!isWinOrTie())
                    {
                        r_GameManager.UpdateTurns();
                        updatePlayersSoldierPhotoPosition();
                        r_GameManager.AddAllMovesToList(out m_isPlayerCanEat);
                        moveAi();           
                    }
                }
            }
        }

        private void cellButton_ClickUnmark(object sender, EventArgs e)
        {
            const bool k_Remove = true;
            int row, col;
            CellButton clickedCellButton;

            clickedCellButton = (CellButton)sender;
            row = clickedCellButton.Row;
            col = clickedCellButton.Col;
            setPlayerImageUnClicked(row, col);
            updateCellsForEventMove(k_Remove);
            r_GameManager.AddAllMovesToList(out m_isPlayerCanEat);
            r_ButtonMatrix[row, col].Click -= new EventHandler(cellButton_ClickUnmark);
            r_ButtonMatrix[row, col].Click += new EventHandler(cellButton_ClickMark);
        }

        private void cellButton_MouseHover(object sender, EventArgs e)
        {
            CellButton clickedCellButton = (CellButton)sender;
            clickedCellButton.FlatStyle = FlatStyle.Standard;
        }

        private void cellButton_MouseLeave(object sender, EventArgs e)
        {
            CellButton clickedCellButton = (CellButton)sender;
            clickedCellButton.FlatStyle = FlatStyle.Flat;
        }

        private static void invalidMoveTextBox()
        {
            MessageBox.Show("Invalid move! Try again.", "ERROR", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void updateErrorButtonCells(bool i_remove)
        {
            int colMark, rowMark, length, width;
            bool IsSelectedCell;
            List<string> moves;

            width = (int)r_GameSettingsForm.GameSettings.BoardSize;
            length = (int)r_GameSettingsForm.GameSettings.BoardSize;
            moves = r_GameManager.GetPlayerMovesList();
            colMark = moves[0][0] - 'A';
            rowMark = moves[0][1] - 'a';
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    IsSelectedCell = (i == rowMark && j == colMark) || moves.Contains(convertToMoveFormat(i, j));
                    if (!IsSelectedCell)
                    {
                        if (!i_remove)
                        {
                            r_ButtonMatrix[i, j].Click += new EventHandler(cellButton_ClickError);
                        }
                        else
                        {
                            r_ButtonMatrix[i, j].Click -= new EventHandler(cellButton_ClickError);
                        }
                    }
                }
            }
        }

        private void printBoard()
        {
            int length, width;

            width = (int)r_GameSettingsForm.GameSettings.BoardSize;
            length = (int)r_GameSettingsForm.GameSettings.BoardSize;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    setPlayerImageUnClicked(i, j);
                }
            }
        }

        private bool isWinOrTie()
        {
            DialogResult dialogResult;
            string playerName, msg;
            bool isGameEnd;

            isGameEnd = false;
            if (r_GameManager.IsGameOver())
            {
                if (r_GameManager.IsThereWinner())
                {
                    r_GameManager.UpdateScore();
                    playerName = r_GameManager.IsPlayer1Turn ?
                        r_GameManager.Player1.Name : r_GameManager.Player2.Name;
                    msg =
                    string.Format(
@"{0} Won!
Another Round?",
playerName);
                    dialogResult = MessageBox.Show(msg, "Damka",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    msg =
                    string.Format(
@"Tie!
Another Round?");
                    dialogResult = MessageBox.Show(msg, "Damka",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

                isGameEnd = true;
                if (dialogResult == DialogResult.Yes)
                {
                    clearButtonsMatrix();
                    startGame();
                }
                else
                {
                    this.Close();
                }
            }

            return isGameEnd;
        }

        private void moveAi()
        {
            while (r_GameManager.IsAiTurn())
            {
                r_GameManager.MovePlayer(r_GameManager.ComputerMove(), ref m_isPlayerCanEat);
                TimerComputerMove.Start();

                if (!m_isPlayerCanEat)
                {
                    if (!isWinOrTie())
                    {
                        r_GameManager.UpdateTurns();
                        r_GameManager.AddAllMovesToList(out m_isPlayerCanEat);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void updateEventsHandler(int i_Row, int i_Col)
        {
           r_ButtonMatrix[i_Row, i_Col].Click += new EventHandler(cellButton_ClickMark);
           r_ButtonMatrix[i_Row, i_Col].Click -= new EventHandler(cellButton_ClickUnmark);
        }

        private void setPlayerImageClicked(CellButton i_ClickedCellButton, int i_Row, int i_Col)
        {
            switch (r_GameManager.BoardManager.Board[i_Row, i_Col].CellObject)
            {
                case eObjectInCell.Man1:
                    i_ClickedCellButton.BackgroundImage = Properties.Resources.clickedPinkMan;
                    break;
                case eObjectInCell.Man2:
                    i_ClickedCellButton.BackgroundImage = Properties.Resources.clickedBlueMan;
                    break;
                case eObjectInCell.King1:
                    i_ClickedCellButton.BackgroundImage = Properties.Resources.clickedPinkKing;
                    break;
                case eObjectInCell.King2:
                    i_ClickedCellButton.BackgroundImage = Properties.Resources.clickedBlueKing;
                    break;
                default:
                    break;
            }
        }

        private void setPlayerImageUnClicked(int i_Row, int i_Col)
        {
            switch (r_GameManager.BoardManager.Board[i_Row, i_Col].CellObject)
            {
                case eObjectInCell.None:
                    r_ButtonMatrix[i_Row, i_Col].BackgroundImage = ((i_Row + i_Col) % 2 == 0) ?
                        Properties.Resources.black : Properties.Resources.white;
                    r_ButtonMatrix[i_Row, i_Col].OriginImage = ((i_Row + i_Col) % 2 == 0) ?
                       Properties.Resources.black : Properties.Resources.white;
                    break;
                case eObjectInCell.Man1:
                    r_ButtonMatrix[i_Row, i_Col].BackgroundImage = Properties.Resources.PinkMan;
                    r_ButtonMatrix[i_Row, i_Col].OriginImage = Properties.Resources.PinkMan;
                    break;
                case eObjectInCell.Man2:
                    r_ButtonMatrix[i_Row, i_Col].BackgroundImage = Properties.Resources.BlueMan;
                    r_ButtonMatrix[i_Row, i_Col].OriginImage = Properties.Resources.BlueMan;
                    break;
                case eObjectInCell.King1:
                    r_ButtonMatrix[i_Row, i_Col].BackgroundImage = Properties.Resources.PinkKing;
                    r_ButtonMatrix[i_Row, i_Col].OriginImage = Properties.Resources.PinkKing;
                    break;
                case eObjectInCell.King2:
                    r_ButtonMatrix[i_Row, i_Col].BackgroundImage = Properties.Resources.BlueKing;
                    r_ButtonMatrix[i_Row, i_Col].OriginImage = Properties.Resources.BlueKing;
                    break;
                default:
                    break;
            }
        }

        private bool ValidatePos(CellButton i_ClickedCellButton, int i_ColIndex, int i_RowIndex)
        {
            bool isValidPos;
            int row, col, length;
            List<string> move;

            move = r_GameManager.GetPlayerMovesList();
            isValidPos = false;
            length = move.Count;
            row = i_ClickedCellButton.Row;
            col = i_ClickedCellButton.Col;
            for (int i = 0; i < length; i++)
            {
                if (move[i][i_ColIndex] == (col + 'A') && move[i][i_RowIndex] == (row + 'a'))
                {
                    isValidPos = true;
                    break;
                }
            }

            return isValidPos;
        }
    
        private void updateCellsForEventMove(bool i_remove)
        {
            List<string> moves;
            int row, col, length;

            updateErrorButtonCells(i_remove);
            moves = r_GameManager.GetPlayerMovesList();
            length = moves.Count;
            for (int i = 0; i < length; i++)
            {
                col = moves[i][3] - 'A';
                row = moves[i][4] - 'a';
                if (!i_remove)
                {
                    r_ButtonMatrix[row, col].BackgroundImage = Properties.Resources.whitechoose;
                    r_ButtonMatrix[row, col].Click += new EventHandler(cellButton_ClickMovePlayer);
                }
                else
                {
                   r_ButtonMatrix[row, col].BackgroundImage = r_ButtonMatrix[row, col].OriginImage;
                    r_ButtonMatrix[row, col].Click -= new EventHandler(cellButton_ClickMovePlayer);
                }
            }
        }

        private void updateValidMove(CellButton i_ClickedCellButton)
        {
            const int k_FirstIndex = 0;
            const int k_SecondIndex = 1;
            int row, col, length, i;
            List<string> moves;

            i = 0;
            moves = r_GameManager.GetPlayerMovesList();
            length = moves.Count;
            row = i_ClickedCellButton.Row;
            col = i_ClickedCellButton.Col;
            while (i < length)
            {
                if (moves[i][k_FirstIndex] == (col + 'A') && moves[i][k_SecondIndex] == (row + 'a'))
                {
                    i++;
                }
                else
                {
                    moves.Remove(moves[i]);
                    length--;
                }
            }
        }

        private string convertToMoveFormat(int i_row, int i_col)
        {
            List<string> move= r_GameManager.GetPlayerMovesList();
            string moveFormat =
                    string.Format(
@"{0}{1}>{2}{3}", move[0][0], move[0][1], (char)(i_col + 'A'), (char)(i_row + 'a'));

            return moveFormat;
        }

        private void clickImage()
        {
            Bitmap cursorImage;
            const int k_SleepTime = 250;
            const int k_CursorSizeX = 100, K_cursorSizeY = 150;

            cursorImage = new Bitmap(Properties.Resources.clickedCursor, k_CursorSizeX, K_cursorSizeY);
            Cursor = new Cursor(cursorImage.GetHicon());
            System.Threading.Thread.Sleep(k_SleepTime);
            Cursor = new Cursor(r_cursorImage.GetHicon());
        }

        private void updatePlayersSoldierPhotoPosition()
        {
            if (r_GameManager.IsPlayer1Turn)
            {
                m_PictureBoxPlayer1.Show();
                m_PictureBoxPlayer2.Hide();
            }
            else
            {
                m_PictureBoxPlayer1.Hide();
                m_PictureBoxPlayer2.Show();
            }

        }

        private void TimerComputerMove_Tick(object sender, EventArgs e)
        {
            TimerComputerMove.Stop();
            printBoard();
            updatePlayersSoldierPhotoPosition();
        }

        private void clearButtonsMatrix()
        {
            int width = (int)r_GameSettingsForm.GameSettings.BoardSize;
            int length = (int)r_GameSettingsForm.GameSettings.BoardSize;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    this.Controls.Remove(r_ButtonMatrix[i, j]);
                }
            }
        }

        private void fadeInFormTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 1)
            {
                FadeInFormTimer.Stop();
            }    
            else
            {
                this.Opacity += 0.05;
            }
        }
    }
}

