namespace FastReader
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
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.RESET = new System.Windows.Forms.Button();
            this.NUMS = new System.Windows.Forms.Label();
            this.PauseButton = new System.Windows.Forms.Button();
            this.SpeedSlowButton = new System.Windows.Forms.Button();
            this.SpeedFastButton = new System.Windows.Forms.Button();
            this.GoBack10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.BackColor = System.Drawing.SystemColors.Window;
            this.DisplayLabel.Location = new System.Drawing.Point(12, 18);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(232, 40);
            this.DisplayLabel.TabIndex = 0;
            this.DisplayLabel.Click += new System.EventHandler(this.DisplayLabel_Click);
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(15, 161);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(110, 74);
            this.RESET.TabIndex = 2;
            this.RESET.Text = "Reset";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // NUMS
            // 
            this.NUMS.BackColor = System.Drawing.SystemColors.Window;
            this.NUMS.Location = new System.Drawing.Point(265, 18);
            this.NUMS.Name = "NUMS";
            this.NUMS.Size = new System.Drawing.Size(113, 217);
            this.NUMS.TabIndex = 4;
            this.NUMS.Click += new System.EventHandler(this.NUMS_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(131, 69);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(113, 86);
            this.PauseButton.TabIndex = 5;
            this.PauseButton.Text = "Pause/ Resume";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // SpeedSlowButton
            // 
            this.SpeedSlowButton.Location = new System.Drawing.Point(15, 69);
            this.SpeedSlowButton.Name = "SpeedSlowButton";
            this.SpeedSlowButton.Size = new System.Drawing.Size(110, 40);
            this.SpeedSlowButton.TabIndex = 7;
            this.SpeedSlowButton.Text = "Start (500)";
            this.SpeedSlowButton.UseVisualStyleBackColor = true;
            this.SpeedSlowButton.Click += new System.EventHandler(this.SpeedSlowButton_Click);
            // 
            // SpeedFastButton
            // 
            this.SpeedFastButton.Location = new System.Drawing.Point(15, 115);
            this.SpeedFastButton.Name = "SpeedFastButton";
            this.SpeedFastButton.Size = new System.Drawing.Size(110, 40);
            this.SpeedFastButton.TabIndex = 8;
            this.SpeedFastButton.Text = "Start (100)";
            this.SpeedFastButton.UseVisualStyleBackColor = true;
            this.SpeedFastButton.Click += new System.EventHandler(this.SpeedFastButton_Click);
            // 
            // GoBack10
            // 
            this.GoBack10.Location = new System.Drawing.Point(131, 161);
            this.GoBack10.Name = "GoBack10";
            this.GoBack10.Size = new System.Drawing.Size(113, 32);
            this.GoBack10.TabIndex = 9;
            this.GoBack10.Text = "Go back 10 words";
            this.GoBack10.UseVisualStyleBackColor = true;
            this.GoBack10.Click += new System.EventHandler(this.GoBack10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(392, 244);
            this.Controls.Add(this.GoBack10);
            this.Controls.Add(this.SpeedFastButton);
            this.Controls.Add(this.SpeedSlowButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.NUMS);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.DisplayLabel);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.Label NUMS;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button SpeedSlowButton;
        private System.Windows.Forms.Button SpeedFastButton;
        private System.Windows.Forms.Button GoBack10;
    }
}

