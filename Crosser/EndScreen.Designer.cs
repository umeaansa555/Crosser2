﻿namespace Crosser
{
    partial class EndScreen
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
            this.exitButton = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.crashBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.crashBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.OrangeRed;
            this.exitButton.FlatAppearance.BorderSize = 3;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.exitButton.Location = new System.Drawing.Point(137, 360);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(289, 46);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit Game";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // endLabel
            // 
            this.endLabel.Font = new System.Drawing.Font("Impact", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.endLabel.Location = new System.Drawing.Point(58, 115);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(442, 98);
            this.endLabel.TabIndex = 3;
            this.endLabel.Text = "COLLISION!!!";
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Chartreuse;
            this.playButton.FlatAppearance.BorderSize = 3;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.playButton.Location = new System.Drawing.Point(137, 236);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(289, 46);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play again";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Gold;
            this.menuButton.FlatAppearance.BorderSize = 3;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.menuButton.Location = new System.Drawing.Point(137, 299);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(289, 46);
            this.menuButton.TabIndex = 7;
            this.menuButton.Text = "Return to menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // crashBox
            // 
            this.crashBox.Image = global::Crosser.Properties.Resources.car_crash_clipart;
            this.crashBox.Location = new System.Drawing.Point(87, 432);
            this.crashBox.Name = "crashBox";
            this.crashBox.Size = new System.Drawing.Size(379, 201);
            this.crashBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.crashBox.TabIndex = 9;
            this.crashBox.TabStop = false;
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.crashBox);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.endLabel);
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(570, 670);
            ((System.ComponentModel.ISupportInitialize)(this.crashBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.PictureBox crashBox;
    }
}
