using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
	public partial class congrats : Form
	{
		public congrats()
		{
			InitializeComponent();
		}

		
		private void buttonPlayAgain_Click(object sender, EventArgs e)
		{
			MemoryGame mg = new MemoryGame();
			mg.Show();
			this.Hide();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();

		}
	}
}
