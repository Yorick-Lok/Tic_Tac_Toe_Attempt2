using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class FrmTicTacToe_Attempt2 : Form
    {
        private string player1Name;
        private string player2Name;

        private string[,] board = new string[3, 3];
        private bool isPlayer1Turn = true;
        private bool gameStarted = false;
        private bool gameOver = false;
        private (int row, int col)[] winningCells = null;

        bool singlePlayerMode = false;
        private bool player1Starts = true;

        private int amountOfGames = 1;
        private int currentGame = 1;

        private int player1Score = 0;
        private int player2Score = 0;

        private Random rand = new Random();

        public FrmTicTacToe_Attempt2()
        {
            InitializeComponent();

            SetupPlaceholders();

            lblPlayer1Locked.ForeColor = Color.Red;
            lblPlayer1Score.ForeColor = Color.Red;

            lblPlayer2Locked.ForeColor = Color.Blue;
            lblPlayer2Score.ForeColor = Color.Blue;

            lblPlayer1Locked.Hide();
            lblPlayer1Score.Hide();

            lblPlayer2Locked.Hide();
            lblPlayer2Score.Hide();

            pbTicTacToeField.Paint += pbTicTacToeField_Paint;
            pbTicTacToeField.MouseClick += pbTicTacToeField_MouseClick;
        }

        private void SetupPlaceholders()
        {
            txtPlayer1.Text = "Enter Player 1 Name";
            txtPlayer2.Text = "Enter Player 2 Name";

            txtPlayer1.ForeColor = Color.Gray;
            txtPlayer2.ForeColor = Color.Gray;

            txtPlayer1.Enter += RemovePlaceholder;
            txtPlayer1.Leave += ShowPlaceholder;

            txtPlayer2.Enter += RemovePlaceholder;
            txtPlayer2.Leave += ShowPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb != null && tb.ForeColor == Color.Gray)
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void ShowPlaceholder(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb != null && string.IsNullOrWhiteSpace(tb.Text))
            {
                if (tb.Name == "txtPlayer1")
                    tb.Text = "Enter Player 1 Name";
                else
                    tb.Text = "Enter Player 2 Name";

                tb.ForeColor = Color.Gray;
            }
        }

        private void CheckPlayerNames(bool isSinglePlayer = false)
        {
            if (isSinglePlayer)
            {
                player1Name = "You";
                player2Name = "Bot";
            }
            else
            {
                player1Name = string.IsNullOrWhiteSpace(txtPlayer1.Text) || txtPlayer1.Text == "Enter Player 1 Name"
                    ? "Player 1"
                    : txtPlayer1.Text;

                player2Name = string.IsNullOrWhiteSpace(txtPlayer2.Text) || txtPlayer2.Text == "Enter Player 2 Name"
                    ? "Player 2"
                    : txtPlayer2.Text;
            }

            lblPlayer1Locked.Text = player1Name;
            lblPlayer2Locked.Text = player2Name;

            lblPlayer1Locked.Show();
            lblPlayer2Locked.Show();

            lblPlayer1Score.Show();
            lblPlayer2Score.Show();
        }

        private void btnSinglePlayer_MouseClick(object sender, MouseEventArgs e)
        {
            if (gameStarted && !gameOver) return;

            singlePlayerMode = true;

            StartGame(true);
        }

        private void btnMultiPlayer_MouseClick(object sender, MouseEventArgs e)
        {
            if (gameStarted && !gameOver) return;

            singlePlayerMode = false;

            StartGame(false);
        }

        private void StartGame(bool single)
        {
            CheckPlayerNames(single);

            amountOfGames = (int)numUpDownGameAmount.Value;

            currentGame = 1;
            player1Score = 0;
            player2Score = 0;

            ResetBoard();

            lblPlayer1Score.Text = $"Score: {player1Score}";
            lblPlayer2Score.Text = $"Score: {player2Score}";

            gameStarted = true;

            numUpDownGameAmount.Hide();
            lblGameAmount.Hide();
            lblUpdateRoundCounter.Show();

            UpdateRoundCounter();

            pbTicTacToeField.Invalidate();

            // Trigger bot move if bot starts first
            if (singlePlayerMode && !isPlayer1Turn)
                StartBotTurn();
        }

        private void ResetBoard()
        {
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    board[r, c] = null;

            isPlayer1Turn = player1Starts;

            winningCells = null;
            gameOver = false;
        }

        private void pbTicTacToeField_MouseClick(object sender, MouseEventArgs e)
        {
            if (!gameStarted || gameOver) return;

            if (singlePlayerMode && !isPlayer1Turn) return;

            int size = 330;
            int cell = size / 3;

            int startX = (pbTicTacToeField.Width - size) / 2;
            int startY = (pbTicTacToeField.Height - size) / 2;

            int col = (e.X - startX) / cell;
            int row = (e.Y - startY) / cell;

            if (row < 0 || row > 2 || col < 0 || col > 2) return;
            if (!string.IsNullOrEmpty(board[row, col])) return;

            board[row, col] = isPlayer1Turn ? "X" : "O";

            isPlayer1Turn = !isPlayer1Turn;

            pbTicTacToeField.Invalidate();

            HandleWinner();

            if (!gameOver && singlePlayerMode && !isPlayer1Turn)
                StartBotTurn();
        }

        private async void StartBotTurn()
        {
            await Task.Delay(200); // slight visual delay

            if (!gameOver && !isPlayer1Turn)
                BotMove();
        }

        private void BotMove()
        {
            int row = -1;
            int col = -1;

            if (TryCompleteLine("O", out row, out col) ||
                TryCompleteLine("X", out row, out col))
            {
                // row, col set by TryCompleteLine
            }
            else if (string.IsNullOrEmpty(board[1, 1]) && rand.Next(100) < 60)
            {
                // 70% chance to take center
                row = 1;
                col = 1;
            }
            else
            {
                int[][] corners =
                {
                new[]{0,0},
                new[]{0,2},
                new[]{2,0},
                new[]{2,2}
            };

                var available = new List<int[]>();

                foreach (var c in corners)
                    if (string.IsNullOrEmpty(board[c[0], c[1]]))
                        available.Add(c);

                if (available.Count > 0)
                {
                    var choice = available[rand.Next(available.Count)];
                    row = choice[0];
                    col = choice[1];
                }
                else
                {
                    do
                    {
                        row = rand.Next(3);
                        col = rand.Next(3);
                    }
                    while (!string.IsNullOrEmpty(board[row, col]));
                }
            }

            board[row, col] = "O";

            isPlayer1Turn = true;

            pbTicTacToeField.Invalidate();

            HandleWinner();
        }

        private void HandleWinner()
        {
            string winner = CheckWinner();

            if (winner == null) return;

            gameOver = true;

            pbTicTacToeField.Invalidate();

            if (winner == "Tie")
            {
                MessageBox.Show("It's a Tie", "Game Over");
            }
            else
            {
                if (winner == "X")
                    player1Score++;
                else
                    player2Score++;

                lblPlayer1Score.Text = $"Score: {player1Score}";
                lblPlayer2Score.Text = $"Score: {player2Score}";

                string name = winner == "X" ? player1Name : player2Name;

                MessageBox.Show($"Winner: {name}!", "Game Over");
            }

            NextGame();
        }

        private bool TryCompleteLine(string symbol, out int row, out int col)
        {
            row = -1;
            col = -1;

            for (int r = 0; r < 3; r++)
            {
                int count = 0;
                int empty = -1;

                for (int c = 0; c < 3; c++)
                {
                    if (board[r, c] == symbol) count++;
                    else if (string.IsNullOrEmpty(board[r, c])) empty = c;
                }

                if (count == 2 && empty != -1)
                {
                    row = r;
                    col = empty;
                    return true;
                }
            }

            for (int c = 0; c < 3; c++)
            {
                int count = 0;
                int empty = -1;

                for (int r = 0; r < 3; r++)
                {
                    if (board[r, c] == symbol) count++;
                    else if (string.IsNullOrEmpty(board[r, c])) empty = r;
                }

                if (count == 2 && empty != -1)
                {
                    row = empty;
                    col = c;
                    return true;
                }
            }

            int diagCount = 0;
            int emptyDiag = -1;

            for (int i = 0; i < 3; i++)
            {
                if (board[i, i] == symbol) diagCount++;
                else if (string.IsNullOrEmpty(board[i, i])) emptyDiag = i;
            }

            if (diagCount == 2 && emptyDiag != -1)
            {
                row = emptyDiag;
                col = emptyDiag;
                return true;
            }

            diagCount = 0;
            emptyDiag = -1;

            for (int i = 0; i < 3; i++)
            {
                int c = 2 - i;

                if (board[i, c] == symbol) diagCount++;
                else if (string.IsNullOrEmpty(board[i, c])) emptyDiag = i;
            }

            if (diagCount == 2 && emptyDiag != -1)
            {
                row = emptyDiag;
                col = 2 - emptyDiag;
                return true;
            }

            return false;
        }

        private void NextGame()
        {
            currentGame++;

            if (currentGame > amountOfGames)
            {
                string finalWinner;

                if (player1Score > player2Score)
                    finalWinner = player1Name;
                else if (player2Score > player1Score)
                    finalWinner = player2Name;
                else
                    finalWinner = "No One (Tie)";

                MessageBox.Show($"Match Over!\nWinner: {finalWinner}", "Final Result");

                gameStarted = false;

                numUpDownGameAmount.Show();
                lblGameAmount.Show();
                lblUpdateRoundCounter.Hide();
                return;
            }

            // Alternate starting player
            player1Starts = !player1Starts;

            ResetBoard();

            UpdateRoundCounter();
            pbTicTacToeField.Invalidate();

            // Bot only moves if it starts
            if (singlePlayerMode && !isPlayer1Turn)
                StartBotTurn();
        }

        private void UpdateRoundCounter()
        {
            lblUpdateRoundCounter.Text = $"Round: {currentGame}/{amountOfGames}";
        }

        private void pbTicTacToeField_Paint(object sender, PaintEventArgs e)
        {
            if (!gameStarted) return;

            Graphics g = e.Graphics;

            int size = 330;
            int cell = size / 3;

            int startX = (pbTicTacToeField.Width - size) / 2;
            int startY = (pbTicTacToeField.Height - size) / 2;

            Pen gridPen = new Pen(Color.Black, 10);

            for (int i = 1; i <= 2; i++)
            {
                int y = startY + cell * i;
                g.DrawLine(gridPen, startX, y, startX + size, y);

                int x = startX + cell * i;
                g.DrawLine(gridPen, x, startY, x, startY + size);
            }

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    string value = board[row, col];

                    if (string.IsNullOrEmpty(value)) continue;

                    int x = startX + col * cell + cell / 2;
                    int y = startY + row * cell + cell / 2;

                    if (value == "X")
                    {
                        Pen pen = new Pen(Color.Red, 5);
                        int offset = cell / 4;

                        g.DrawLine(pen, x - offset, y - offset, x + offset, y + offset);
                        g.DrawLine(pen, x + offset, y - offset, x - offset, y + offset);
                    }
                    else
                    {
                        Pen pen = new Pen(Color.Blue, 5);
                        int radius = cell / 4;

                        g.DrawEllipse(pen, x - radius, y - radius, radius * 2, radius * 2);
                    }
                }
            }

            if (winningCells != null)
            {
                Pen winPen = new Pen(Color.Green, 8);

                var first = winningCells[0];
                var last = winningCells[2];

                int x1 = startX + first.col * cell + cell / 2;
                int y1 = startY + first.row * cell + cell / 2;

                int x2 = startX + last.col * cell + cell / 2;
                int y2 = startY + last.row * cell + cell / 2;

                g.DrawLine(winPen, x1, y1, x2, y2);
            }
        }

        private string CheckWinner()
        {
            winningCells = null;

            // Rows
            for (int row = 0; row < 3; row++)
            {
                if (!string.IsNullOrEmpty(board[row, 0]) &&
                    board[row, 0] == board[row, 1] &&
                    board[row, 1] == board[row, 2])
                {
                    winningCells = new[] { (row, 0), (row, 1), (row, 2) };
                    return board[row, 0];
                }
            }

            // Columns
            for (int col = 0; col < 3; col++)
            {
                if (!string.IsNullOrEmpty(board[0, col]) &&
                    board[0, col] == board[1, col] &&
                    board[1, col] == board[2, col])
                {
                    winningCells = new[] { (0, col), (1, col), (2, col) };
                    return board[0, col];
                }
            }

            // Diagonals
            if (!string.IsNullOrEmpty(board[0, 2]) &&
                board[0, 2] == board[1, 1] &&
                board[1, 1] == board[2, 0])
            {
                winningCells = new[] { (0, 2), (1, 1), (2, 0) };
                return board[0, 2];
            }

            if (!string.IsNullOrEmpty(board[0, 0]) &&
                board[0, 0] == board[1, 1] &&
                board[1, 1] == board[2, 2])
            {
                winningCells = new[] { (0, 0), (1, 1), (2, 2) };
                return board[0, 0];
            }

            // Tie
            bool tie = true;
            foreach (string cell in board)
            {
                if (string.IsNullOrEmpty(cell))
                {
                    tie = false;
                    break;
                }
            }

            if (tie)
                return "Tie";

            return null;
        }

        private void EndEntireGame()
        {
            gameStarted = false;
            gameOver = false;

            player1Score = 0;
            player2Score = 0;

            currentGame = 1;
            player1Starts = true;

            lblPlayer1Score.Text = "";
            lblPlayer2Score.Text = "";
            lblPlayer1Locked.Hide();
            lblPlayer2Locked.Hide();

            lblUpdateRoundCounter.Hide();

            numUpDownGameAmount.Show();
            lblGameAmount.Show();

            ResetBoard();
            pbTicTacToeField.Invalidate();

        }

        private void btnEndGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (!gameStarted) return;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to end the game?",
                "End Game",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            EndEntireGame();
        }
    }
}
