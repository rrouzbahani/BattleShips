namespace BattleShips
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
            this.pbxBattleShip = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnResumeGame = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblBattleShip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattleShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxBattleShip
            // 
            this.pbxBattleShip.Image = global::BattleShips.Properties.Resources.image;
            this.pbxBattleShip.Location = new System.Drawing.Point(203, 73);
            this.pbxBattleShip.Name = "pbxBattleShip";
            this.pbxBattleShip.Size = new System.Drawing.Size(234, 237);
            this.pbxBattleShip.TabIndex = 11;
            this.pbxBattleShip.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnHelp.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(19, 330);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(105, 63);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnStats.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.Location = new System.Drawing.Point(19, 247);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(105, 63);
            this.btnStats.TabIndex = 9;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = false;
            // 
            // btnResumeGame
            // 
            this.btnResumeGame.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnResumeGame.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumeGame.Location = new System.Drawing.Point(19, 163);
            this.btnResumeGame.Name = "btnResumeGame";
            this.btnResumeGame.Size = new System.Drawing.Size(105, 63);
            this.btnResumeGame.TabIndex = 8;
            this.btnResumeGame.Text = "Resume";
            this.btnResumeGame.UseVisualStyleBackColor = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNewGame.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewGame.Location = new System.Drawing.Point(19, 82);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(105, 63);
            this.btnNewGame.TabIndex = 7;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            // 
            // lblBattleShip
            // 
            this.lblBattleShip.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattleShip.Location = new System.Drawing.Point(50, 8);
            this.lblBattleShip.Name = "lblBattleShip";
            this.lblBattleShip.Size = new System.Drawing.Size(353, 62);
            this.lblBattleShip.TabIndex = 6;
            this.lblBattleShip.Text = "BattleShip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 408);
            this.Controls.Add(this.pbxBattleShip);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnResumeGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblBattleShip);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattleShip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox pbxBattleShip;
        internal System.Windows.Forms.Button btnHelp;
        internal System.Windows.Forms.Button btnStats;
        internal System.Windows.Forms.Button btnResumeGame;
        internal System.Windows.Forms.Button btnNewGame;
        internal System.Windows.Forms.Label lblBattleShip;
    }
}

