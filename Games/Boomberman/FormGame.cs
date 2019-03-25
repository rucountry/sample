using System;
using System.Windows.Forms;

namespace Boomberman
{
	public delegate void deClearFire();
	public partial class FormGame : Form
	{
		private MainForm mainForm;
		public FormGame()
		{
			InitializeComponent();
			NewGame();
		}

		private void NewGame()
		{
			mainForm = new MainForm(panelGame, labelGame,
				() => 
				{
					timerClearFire.Interval = 500;
					timerClearFire.Enabled = true;
				});
			timerGameOver.Enabled = true;
		}
		
		private void aboutGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Bomberman", "О игре");
		}

		private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Rasim_suleimanov@mail.ru", "О авторе");
		}

		private void FormGame_KeyDown(object sender, KeyEventArgs e)
		{
			if (timerGameOver.Enabled)
			switch (e.KeyCode)
			{
				case Keys.Left: mainForm.MoveMan(Arrows.Left);break;
				case Keys.Right: mainForm.MoveMan(Arrows.Right);break;
				case Keys.Up: mainForm.MoveMan(Arrows.Up);break;
				case Keys.Down:mainForm.MoveMan(Arrows.Down);break;
				case Keys.Space: mainForm.CreateBomb();break;
			}
		}

		private void timerClearFire_Tick(object sender, EventArgs e)
		{
			mainForm.ClearFire();
			timerClearFire.Enabled = false;
		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewGame();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void timerGameOver_Tick(object sender, EventArgs e)
		{
			if (mainForm.GameOver())
			{
				timerGameOver.Enabled = false;
				DialogResult dr = MessageBox.Show("Хотите начать новую игру?", "Конец игры", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
					NewGame();
				else if (dr == DialogResult.No)
					this.Close();
			}
		}
	}
}
