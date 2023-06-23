namespace Crosser
{
    partial class MenuScreen
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
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.leaderboardButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Impact", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.titleLabel.Location = new System.Drawing.Point(75, 307);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(394, 98);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "CROSSER 2";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Chartreuse;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.BorderSize = 3;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.startButton.Location = new System.Drawing.Point(178, 408);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(195, 66);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.OrangeRed;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 3;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.exitButton.Location = new System.Drawing.Point(178, 552);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(195, 66);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // leaderboardButton
            // 
            this.leaderboardButton.BackColor = System.Drawing.Color.Gold;
            this.leaderboardButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.leaderboardButton.FlatAppearance.BorderSize = 3;
            this.leaderboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.leaderboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaderboardButton.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.leaderboardButton.Location = new System.Drawing.Point(178, 480);
            this.leaderboardButton.Name = "leaderboardButton";
            this.leaderboardButton.Size = new System.Drawing.Size(195, 66);
            this.leaderboardButton.TabIndex = 4;
            this.leaderboardButton.Text = "View Scores";
            this.leaderboardButton.UseVisualStyleBackColor = false;
            this.leaderboardButton.Click += new System.EventHandler(this.leaderboardButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Crosser.Properties.Resources.Traffic_Light;
            this.pictureBox1.Location = new System.Drawing.Point(148, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.leaderboardButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(570, 670);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button leaderboardButton;
    }
}
