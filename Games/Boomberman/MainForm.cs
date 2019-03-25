using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Boomberman
{
	public delegate void deBang(Bomb b);

	class MainForm
	{
		private readonly Label lbl;
		private readonly Panel panel;
		private readonly PictureBox[,] masPic;
		private readonly Sost[,] masSost;
		private readonly int sizeX = 31;
		private readonly int sizeY = 13;
		private readonly int boxSize = 0;
		
		private readonly Random random = new Random();
		private Man man;
		private List<Mob> listMobs;
		private deClearFire deClearFire;

		public MainForm(Panel panel, Label lbl, deClearFire deClearFire)
		{
			listMobs = new List<Mob>();
			this.deClearFire = deClearFire;
			this.lbl = lbl;
			this.panel = panel;
			masPic = new PictureBox[sizeX, sizeY];
			masSost = new Sost[sizeX, sizeY];
			panel.Controls.Clear();

			if (panel.Width / sizeX < panel.Height / sizeY)
				boxSize = panel.Width / sizeX;
			else
				boxSize = panel.Height / sizeY;

			CreatePictureBox();
			CreateMan();
			for (int q = 0; q < 5; q++)
			{
				CreateMob();
			}
			BonusClass.Prepare();
		}

		private void CreatePictureBox()
		{
			for (int i = 0; i < sizeX; i++)
			{
				for (int j = 0; j < sizeY; j++)
				{
					CreateOnePicture(new Point(i, j));
				}
			}

			ChangeSost(new Point(1, 1), Sost.пусто);
			ChangeSost(new Point(1, 2), Sost.пусто);
			ChangeSost(new Point(2, 1), Sost.пусто);
		}
		private void CreateOnePicture(Point point)
		{
			PictureBox pictureBox = new PictureBox();
			pictureBox.Location = new Point(point.X * (boxSize - 1), point.Y * (boxSize - 1));
			pictureBox.Size = new Size(boxSize, boxSize);
			pictureBox.BackColor = Color.Azure;
			pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox.BackgroundImageLayout = ImageLayout.Stretch;

			masPic[point.X, point.Y] = pictureBox;
			panel.Controls.Add(pictureBox);

			if (point.X == 0 || point.Y == 0 || point.X == (sizeX-1) || point.Y == (sizeY-1) || (point.X % 2 == 0 && point.Y % 2 == 0))
				ChangeSost(point, Sost.стена);
			else if (random.Next(5) == 0)
				ChangeSost(point, Sost.кирпич);
			else ChangeSost(point, Sost.пусто);

		}
		private void CreateMan()
		{
			int x = 1, y = 1;
			PictureBox pictureBox = new PictureBox();
			pictureBox.Image = Properties.Resources.man;
			pictureBox.Location = new Point(x * boxSize + 6, y * boxSize + 3);
			pictureBox.Size = new Size(boxSize - 6, boxSize - 6);
			pictureBox.BackgroundImage = Properties.Resources.field;
			pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			panel.Controls.Add(pictureBox);
			pictureBox.BringToFront();
			man = new Man(pictureBox, masPic, masSost, Bang, lbl);			
		}
		private void CreateMob()
		{
			int x = 0, y = 0;
			EmptyPlace(out x, out y);
			PictureBox pictureBox = new PictureBox();
			pictureBox.Image = Properties.Resources.mob;
			pictureBox.Location = new Point(x * boxSize-3, y * boxSize-7);
			pictureBox.Size = new Size(boxSize-4, boxSize-4);
			pictureBox.BackgroundImage = Properties.Resources.field;
			pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			panel.Controls.Add(pictureBox);
			pictureBox.BringToFront();
			listMobs.Add(new Mob(pictureBox, masPic, masSost, man));
		}
		private void ChangeSost(Point point, Sost sost)
		{
			switch (sost)
			{
				case Sost.кирпич: masPic[point.X, point.Y].Image = Properties.Resources.brick; break;
				case Sost.стена: masPic[point.X, point.Y].Image = Properties.Resources.wall; break;
				case Sost.пусто: masPic[point.X, point.Y].Image = Properties.Resources.field; break;
				case Sost.бомба: masPic[point.X, point.Y].Image = Properties.Resources.man; break;
				case Sost.огонь: masPic[point.X, point.Y].Image = Properties.Resources.ogon1; break;
				case Sost.огоньочаг: masPic[point.X, point.Y].Image = Properties.Resources.ogon2; break;
				case Sost.приз: masPic[point.X,point.Y].Image = Properties.Resources.prize; break;
			}

			masSost[point.X, point.Y] = sost;
		}
		private void EmptyPlace(out int x, out int y)
		{
			int loop = 0;
			do
			{
				x = random.Next(masSost.GetLength(0)/2, masSost.GetLength(0)-2);
				y = random.Next(1, masSost.GetLength(1)-2);
			} while ((masSost[x,y] != Sost.пусто) && loop++ < 100);
		}
		public void MoveMan(Arrows arrows)
		{
			man.MoveMan(arrows);
		}
		public void CreateBomb()
		{
			if (man.IsNewBomb())
			{
				ChangeSost(man.MyNowPoint(), Sost.бомба);
				man.ChangeScore("q");
			}

		}
		public void Bang(Bomb bomb)
		{
			ChangeSost(bomb.bombHere, Sost.огоньочаг);
			Flame(bomb.bombHere, Arrows.Left);
			Flame(bomb.bombHere, Arrows.Right);
			Flame(bomb.bombHere, Arrows.Up);
			Flame(bomb.bombHere, Arrows.Down);

			KickMob();
			deClearFire();
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
		private void Flame(Point bombPlace, Arrows a)
		{
			bool isNotDone = true;
			int sx = 0, sy = 0;
			int x = 0, y = 0;

			switch (a)
			{
				case Arrows.Left: sx = -1; break;
				case Arrows.Right:sx = 1; break;
				case Arrows.Up: sy = -1; break;
				case Arrows.Down: sy = 1; break;
			}

			do
			{
				x += sx;
				y += sy;
				if (Math.Abs(x) > man.lenFire || Math.Abs(y) > man.lenFire) break;
				if (IsFire(bombPlace, x, y)) ChangeSost(new Point(bombPlace.X + x, bombPlace.Y + y), Sost.огонь);
				else
					isNotDone = false;
			} while (isNotDone);
		}
		private bool IsFire(Point place, int sx, int sy)
		{
			switch (masSost[place.X + sx, place.Y + sy])
			{
				case Sost.пусто:
					return true;
				case Sost.стена:
					return false;
				case Sost.кирпич:
					if (random.Next(0, 2) % 2 == 0)
						ChangeSost(new Point(place.X + sx, place.Y + sy), Sost.приз);
					else
					ChangeSost(new Point(place.X + sx, place.Y + sy), Sost.огонь);
					return false;
				case Sost.бомба:
					foreach (var bomb in man.bombs)
					{
						if (bomb.bombHere == new Point(place.X + sx, place.Y + sy))
							bomb.Reaction();
					}
					return false;
				default:
					return true;
			}	
		}
		private void KickMob()
		{
			List<Mob> del = new List<Mob>();
			foreach (var item in listMobs)
			{
				Point point = item.MyNowPoint();
				if (masSost[point.X, point.Y] == Sost.огонь || masSost[point.X, point.Y] == Sost.огоньочаг)
				{
					del.Add(item);
				}
			}
			for (int i = 0; i < del.Count; i++)
			{
				listMobs.Remove(del[i]);
				panel.Controls.Remove(del[i].mob);
				del[i] = null;
			}
		}
		public void ClearFire()
		{
			for (int x = 0; x < masSost.GetLength(0); x++)
			{
				for (int y = 0; y < masSost.GetLength(1); y++)
				{
					if (masSost[x, y] == Sost.огонь || masSost[x, y] == Sost.огоньочаг)
						ChangeSost(new Point(x, y), Sost.пусто);
				}
			}
		}
		public bool GameOver()
		{
			Point manPoint = man.MyNowPoint();
			if (masSost[manPoint.X, manPoint.Y] == Sost.огонь || masSost[manPoint.X, manPoint.Y] == Sost.огоньочаг)
				return true;
			foreach (var mob in listMobs)
			{
				if (manPoint == mob.MyNowPoint()) return true;
			}
			return false;
		}
	}
}
