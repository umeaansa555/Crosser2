namespace Crosser
{
    partial class ScoreScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.leaderboardLabel = new System.Windows.Forms.Label();
            this.submitNameLabel = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Impact", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Gold;
            this.titleLabel.Location = new System.Drawing.Point(42, 81);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(475, 98);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Scoreboard:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leaderboardLabel
            // 
            this.leaderboardLabel.BackColor = System.Drawing.Color.Transparent;
            this.leaderboardLabel.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardLabel.ForeColor = System.Drawing.Color.White;
            this.leaderboardLabel.Location = new System.Drawing.Point(55, 272);
            this.leaderboardLabel.Name = "leaderboardLabel";
            this.leaderboardLabel.Size = new System.Drawing.Size(466, 215);
            this.leaderboardLabel.TabIndex = 8;
            this.leaderboardLabel.Text = "Name / Score";
            this.leaderboardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // submitNameLabel
            // 
            this.submitNameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitNameLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitNameLabel.Location = new System.Drawing.Point(29, 200);
            this.submitNameLabel.Name = "submitNameLabel";
            this.submitNameLabel.Size = new System.Drawing.Size(295, 32);
            this.submitNameLabel.TabIndex = 7;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.submitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(354, 199);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(180, 32);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit Score";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.leaderboardLabel);
            this.Controls.Add(this.submitNameLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "ScoreScreen";
            this.Size = new System.Drawing.Size(570, 670);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label leaderboardLabel;
        private System.Windows.Forms.TextBox submitNameLabel;
        private System.Windows.Forms.Button submitButton;
    }
}
