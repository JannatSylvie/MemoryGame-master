namespace MemoryGame
{
	partial class congrats
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
			this.buttonExit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonPlayAgain = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.Thistle;
			this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExit.Location = new System.Drawing.Point(168, 66);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(94, 30);
			this.buttonExit.TabIndex = 5;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(269, 33);
			this.label2.TabIndex = 4;
			this.label2.Text = "CONGRATULATIONS!";
			// 
			// buttonPlayAgain
			// 
			this.buttonPlayAgain.BackColor = System.Drawing.Color.Thistle;
			this.buttonPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPlayAgain.Location = new System.Drawing.Point(12, 66);
			this.buttonPlayAgain.Name = "buttonPlayAgain";
			this.buttonPlayAgain.Size = new System.Drawing.Size(94, 30);
			this.buttonPlayAgain.TabIndex = 6;
			this.buttonPlayAgain.Text = "Play again!";
			this.buttonPlayAgain.UseVisualStyleBackColor = false;
			this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
			// 
			// congrats
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Pink;
			this.ClientSize = new System.Drawing.Size(274, 108);
			this.Controls.Add(this.buttonPlayAgain);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.label2);
			this.ForeColor = System.Drawing.Color.PaleVioletRed;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "congrats";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "congrats";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonPlayAgain;
	}
}