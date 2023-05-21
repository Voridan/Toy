namespace Toy
{
    partial class Game
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
            this.content = new System.Windows.Forms.TextBox();
            this.showPlayers = new System.Windows.Forms.Button();
            this.startGame = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.BestLabel = new System.Windows.Forms.Label();
            this.bestScore = new System.Windows.Forms.Label();
            this.scoreInfo = new System.Windows.Forms.GroupBox();
            this.stopGame = new System.Windows.Forms.Button();
            this.scoreInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Enabled = false;
            this.content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.content.Location = new System.Drawing.Point(18, 33);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.content.Size = new System.Drawing.Size(768, 309);
            this.content.TabIndex = 0;
            // 
            // showPlayers
            // 
            this.showPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPlayers.Location = new System.Drawing.Point(150, 394);
            this.showPlayers.Name = "showPlayers";
            this.showPlayers.Size = new System.Drawing.Size(232, 59);
            this.showPlayers.TabIndex = 1;
            this.showPlayers.Text = "список гравців";
            this.showPlayers.UseVisualStyleBackColor = true;
            this.showPlayers.Click += new System.EventHandler(this.showPlayers_Click);
            // 
            // startGame
            // 
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGame.Location = new System.Drawing.Point(435, 394);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(232, 59);
            this.startGame.TabIndex = 2;
            this.startGame.Text = "Почати";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score.Location = new System.Drawing.Point(107, 28);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(20, 22);
            this.score.TabIndex = 3;
            this.score.Text = "0";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(6, 28);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(95, 22);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Результат";
            // 
            // BestLabel
            // 
            this.BestLabel.AutoSize = true;
            this.BestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BestLabel.Location = new System.Drawing.Point(6, 75);
            this.BestLabel.Name = "BestLabel";
            this.BestLabel.Size = new System.Drawing.Size(161, 22);
            this.BestLabel.TabIndex = 5;
            this.BestLabel.Text = "Найкраща спроба";
            // 
            // bestScore
            // 
            this.bestScore.AutoSize = true;
            this.bestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bestScore.Location = new System.Drawing.Point(173, 75);
            this.bestScore.Name = "bestScore";
            this.bestScore.Size = new System.Drawing.Size(20, 22);
            this.bestScore.TabIndex = 6;
            this.bestScore.Text = "0";
            // 
            // scoreInfo
            // 
            this.scoreInfo.Controls.Add(this.scoreLabel);
            this.scoreInfo.Controls.Add(this.score);
            this.scoreInfo.Controls.Add(this.bestScore);
            this.scoreInfo.Controls.Add(this.BestLabel);
            this.scoreInfo.Location = new System.Drawing.Point(12, 3);
            this.scoreInfo.Name = "scoreInfo";
            this.scoreInfo.Size = new System.Drawing.Size(204, 109);
            this.scoreInfo.TabIndex = 7;
            this.scoreInfo.TabStop = false;
            this.scoreInfo.Text = "Очки";
            this.scoreInfo.Visible = false;
            // 
            // stopGame
            // 
            this.stopGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopGame.Location = new System.Drawing.Point(295, 445);
            this.stopGame.Name = "stopGame";
            this.stopGame.Size = new System.Drawing.Size(232, 48);
            this.stopGame.TabIndex = 8;
            this.stopGame.Text = "вийти";
            this.stopGame.UseVisualStyleBackColor = true;
            this.stopGame.Visible = false;
            this.stopGame.Click += new System.EventHandler(this.stopGame_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 505);
            this.Controls.Add(this.stopGame);
            this.Controls.Add(this.scoreInfo);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.showPlayers);
            this.Controls.Add(this.content);
            this.Name = "Game";
            this.Text = "Гра";
            this.Load += new System.EventHandler(this.Game_Load_1);
            this.scoreInfo.ResumeLayout(false);
            this.scoreInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Button showPlayers;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label BestLabel;
        private System.Windows.Forms.Label bestScore;
        private System.Windows.Forms.GroupBox scoreInfo;
        private System.Windows.Forms.Button stopGame;
    }
}

