namespace Tic_Tac_Toe
{
    partial class FrmTicTacToe_Attempt2
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
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnMultiPlayer = new System.Windows.Forms.Button();
            this.pbTicTacToeField = new System.Windows.Forms.PictureBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayer1Locked = new System.Windows.Forms.Label();
            this.lblPlayer2Locked = new System.Windows.Forms.Label();
            this.numUpDownGameAmount = new System.Windows.Forms.NumericUpDown();
            this.lblGameAmount = new System.Windows.Forms.Label();
            this.lblUpdateRoundCounter = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTicTacToeField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownGameAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSinglePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSinglePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSinglePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinglePlayer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinglePlayer.Location = new System.Drawing.Point(8, 0);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(161, 52);
            this.btnSinglePlayer.TabIndex = 0;
            this.btnSinglePlayer.Text = "Play Against A Bot";
            this.btnSinglePlayer.UseVisualStyleBackColor = false;
            this.btnSinglePlayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSinglePlayer_MouseClick);
            // 
            // btnMultiPlayer
            // 
            this.btnMultiPlayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMultiPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMultiPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMultiPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiPlayer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiPlayer.Location = new System.Drawing.Point(623, 0);
            this.btnMultiPlayer.Name = "btnMultiPlayer";
            this.btnMultiPlayer.Size = new System.Drawing.Size(161, 52);
            this.btnMultiPlayer.TabIndex = 1;
            this.btnMultiPlayer.Text = "Play Against Another Player";
            this.btnMultiPlayer.UseVisualStyleBackColor = false;
            this.btnMultiPlayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMultiPlayer_MouseClick);
            // 
            // pbTicTacToeField
            // 
            this.pbTicTacToeField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbTicTacToeField.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbTicTacToeField.Location = new System.Drawing.Point(8, 58);
            this.pbTicTacToeField.Name = "pbTicTacToeField";
            this.pbTicTacToeField.Size = new System.Drawing.Size(776, 380);
            this.pbTicTacToeField.TabIndex = 2;
            this.pbTicTacToeField.TabStop = false;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPlayer2.Location = new System.Drawing.Point(477, 32);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(140, 20);
            this.txtPlayer2.TabIndex = 3;
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPlayer1.Location = new System.Drawing.Point(477, 6);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(140, 20);
            this.txtPlayer1.TabIndex = 4;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPlayer1.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer1.Location = new System.Drawing.Point(9, 58);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(0, 13);
            this.lblPlayer1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(794, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // lblPlayer1Locked
            // 
            this.lblPlayer1Locked.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayer1Locked.AutoSize = true;
            this.lblPlayer1Locked.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPlayer1Locked.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Locked.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayer1Locked.Location = new System.Drawing.Point(43, 69);
            this.lblPlayer1Locked.Name = "lblPlayer1Locked";
            this.lblPlayer1Locked.Size = new System.Drawing.Size(70, 25);
            this.lblPlayer1Locked.TabIndex = 7;
            this.lblPlayer1Locked.Text = "label2";
            // 
            // lblPlayer2Locked
            // 
            this.lblPlayer2Locked.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayer2Locked.AutoSize = true;
            this.lblPlayer2Locked.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPlayer2Locked.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Locked.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayer2Locked.Location = new System.Drawing.Point(680, 69);
            this.lblPlayer2Locked.Name = "lblPlayer2Locked";
            this.lblPlayer2Locked.Size = new System.Drawing.Size(70, 25);
            this.lblPlayer2Locked.TabIndex = 8;
            this.lblPlayer2Locked.Text = "label3";
            // 
            // numUpDownGameAmount
            // 
            this.numUpDownGameAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numUpDownGameAmount.Location = new System.Drawing.Point(324, 32);
            this.numUpDownGameAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownGameAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownGameAmount.Name = "numUpDownGameAmount";
            this.numUpDownGameAmount.Size = new System.Drawing.Size(33, 20);
            this.numUpDownGameAmount.TabIndex = 9;
            this.numUpDownGameAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGameAmount
            // 
            this.lblGameAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGameAmount.AutoSize = true;
            this.lblGameAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameAmount.Location = new System.Drawing.Point(175, 29);
            this.lblGameAmount.Name = "lblGameAmount";
            this.lblGameAmount.Size = new System.Drawing.Size(143, 18);
            this.lblGameAmount.TabIndex = 10;
            this.lblGameAmount.Text = "How Many Rounds?";
            // 
            // lblUpdateRoundCounter
            // 
            this.lblUpdateRoundCounter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUpdateRoundCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateRoundCounter.Location = new System.Drawing.Point(174, 0);
            this.lblUpdateRoundCounter.Name = "lblUpdateRoundCounter";
            this.lblUpdateRoundCounter.Size = new System.Drawing.Size(140, 28);
            this.lblUpdateRoundCounter.TabIndex = 0;
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.Location = new System.Drawing.Point(43, 94);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(0, 25);
            this.lblPlayer1Score.TabIndex = 11;
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Score.Location = new System.Drawing.Point(680, 94);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(0, 25);
            this.lblPlayer2Score.TabIndex = 12;
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRestartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRestartGame.Location = new System.Drawing.Point(375, 6);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(96, 46);
            this.btnRestartGame.TabIndex = 13;
            this.btnRestartGame.Text = "End Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEndGame_MouseClick);
            // 
            // FrmTicTacToe_Attempt2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(793, 446);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.lblUpdateRoundCounter);
            this.Controls.Add(this.lblGameAmount);
            this.Controls.Add(this.numUpDownGameAmount);
            this.Controls.Add(this.lblPlayer2Locked);
            this.Controls.Add(this.lblPlayer1Locked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.pbTicTacToeField);
            this.Controls.Add(this.btnMultiPlayer);
            this.Controls.Add(this.btnSinglePlayer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmTicTacToe_Attempt2";
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pbTicTacToeField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownGameAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnMultiPlayer;
        private System.Windows.Forms.PictureBox pbTicTacToeField;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayer1Locked;
        private System.Windows.Forms.Label lblPlayer2Locked;
        private System.Windows.Forms.NumericUpDown numUpDownGameAmount;
        private System.Windows.Forms.Label lblGameAmount;
        private System.Windows.Forms.Label lblUpdateRoundCounter;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Button btnRestartGame;
    }
}

