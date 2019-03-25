using Boomberman.Properties;
using System.Drawing;
using System.Windows.Forms;


namespace Boomberman
{
	public class Bomb
	{
		Timer timer;
		PictureBox[,] pictureBoxes;
		public Point bombHere { get; private set; }
		int KolSec = 4;
		private deBang deBang;
		public Bomb(PictureBox[,] pictureBox, Point point, deBang deBang)
		{
			this.bombHere = point;
			this.pictureBoxes = pictureBox;
			this.deBang = deBang;
			CreateTimer();
			timer.Enabled = true;
		}
		private void CreateTimer()
		{
			timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += Timer_Tick;
		}

		private void Timer_Tick(object sender, System.EventArgs e)
		{
			if (KolSec <= 1)
			{
				timer.Enabled = false;
				deBang(this);
				return;
			}
			else
				WriteTimer(--KolSec);
		}

		private void WriteTimer(int k)
		{
			pictureBoxes[bombHere.X, bombHere.Y].Image = Resources.man;
			pictureBoxes[bombHere.X, bombHere.Y].Refresh();
			using (Graphics gr = pictureBoxes[bombHere.X, bombHere.Y].CreateGraphics())
			{
				PointF pointF = new PointF(
					pictureBoxes[bombHere.X, bombHere.Y].Size.Width / 4 - 4,
					pictureBoxes[bombHere.X, bombHere.Y].Size.Height / 3 + 1
					);

				gr.DrawString(
					k.ToString(),
					new Font(new FontFamily("Arial"), 8, FontStyle.Italic),
					Brushes.Red,
					pointF);
			}
		}
		public void Reaction()
		{
			KolSec = 0;
		}
	}
}
