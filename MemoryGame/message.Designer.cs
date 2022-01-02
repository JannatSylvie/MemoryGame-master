namespace MemoryGame
{
	partial class message
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
			this.label1 = new System.Windows.Forms.Label();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonPlayAgain = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "GAME OVER";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.Thistle;
			this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExit.Location = new System.Drawing.Point(151, 66);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(94, 30);
			this.buttonExit.TabIndex = 1;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonPlayAgain
			// 
			this.buttonPlayAgain.BackColor = System.Drawing.Color.Thistle;
			this.buttonPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPlayAgain.Location = new System.Drawing.Point(12, 66);
			this.buttonPlayAgain.Name = "buttonPlayAgain";
			this.buttonPlayAgain.Size = new System.Drawing.Size(94, 30);
			this.buttonPlayAgain.TabIndex = 2;
			this.buttonPlayAgain.Text = "Play again!";
			this.buttonPlayAgain.UseVisualStyleBackColor = false;
			this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
			// 
			// message
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Pink;
			this.ClientSize = new System.Drawing.Size(257, 108);
			this.Controls.Add(this.buttonPlayAgain);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "message";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GAME OVER";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonPlayAgain;
	}
}