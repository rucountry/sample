using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Boomberman
{
	public delegate void deAddBonus(Prize p);
	class Man
	{
		private readonly PictureBox man;
		public int step { get; private set; }
		private readonly MovingPlayer moving;
		public int maxcountbomb { get; private set; }
		public List<Bomb> bombs { get; private set; }
		private Sost[,] sosts;
		private PictureBox[,] pictureBoxes;
		private deBang deBang;
		public int lenFire { get; private set; }
		private Label lbl;
		public Man(PictureBox man, PictureBox[,] pictureBoxes, Sost[,] sosts, deBang deBang, Label label)
		{
			maxcountbomb = 10;
			this.lbl = label;
			this.deBang = deBang;
			this.man = man;
			this.sosts = sosts;
			this.pictureBoxes = pictureBoxes;
			step = 5;
			lenFire = 3;
			int offset = 3;
			bombs = new List<Bomb>();
			moving = new MovingPlayer(man, pictureBoxes, sosts, offset, AddBonus);
			lbl.Text = $"Бомб осталось= {maxcountbomb}, Сила огня = {lenFire}, Скорость = {step}";
		}

		public void MoveMan(Arrows arrows)
		{
			if (man == null) return;

			switch (arrows)
			{
				case Arrows.Left: moving.Move(-step, 0); break;
				case Arrows.Right: moving.Move(step, 0); break;
				case Arrows.Up: moving.Move(0, -step); break;
				case Arrows.Down: moving.Move(0, step); break;
			}
		}
		public Point MyNowPoint()
		{
			return moving.MyNowPoint();
		}
		public bool IsNewBomb()
		{
			Point point = MyNowPoint();
			if (bombs.Count < maxcountbomb && sosts[point.X, point.Y] == Sost.пусто)
			{
				bombs.Add(new Bomb(pictureBoxes, point, deBang));
				return true;
			}
			return false;
		}
		private void AddBonus(Prize p)
		{
			switch (p)
			{
				case Prize.бомба_плюс:
					maxcountbomb++; break;
				case Prize.бомба_минус:
					maxcountbomb = maxcountbomb == 1 ? 1 : maxcountbomb--; break;
				case Prize.огонь_плюс:
					lenFire++; break;
				case Prize.огонь_минус:
					lenFire = lenFire == 3 ? 3 : lenFire--; break;
				case Prize.бег_плюс: break;
				case Prize.бег_минус: break;
				default:break;

			}
			ChangeScore(p.ToString());

		}
		public void ChangeScore(string priz)
		{
			if (lbl == null) return;
			lbl.Text = $"Бомб осталось= {maxcountbomb - bombs.Count}, Сила огня = {lenFire}, Скорость = {step}, Приз = {priz}";
		}
	}
}
