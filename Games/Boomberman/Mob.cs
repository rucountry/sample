using System;
using System.Drawing;
using System.Windows.Forms;

namespace Boomberman
{
	class Mob
	{
		public PictureBox mob { get; private set; }
		private Man man;
		private Timer timer;
		private Point destinationPoint = new Point(29, 11);
		private Point mobPlace;
		private MovingPlayer moving;
		private int step = 3;
		private int[,] fmap;
		private Sost[,] sosts;
		private int pathStep;
		private Point[] path;
		private int paths;
		private static Random random = new Random();

		public Mob(PictureBox mob, PictureBox[,] pictureBoxes, Sost[,] sosts, Man man)
		{
			this.man = man;
			this.mob = mob;
			this.sosts = sosts;
			CreateTimer();
			timer.Enabled = true;
			int offset = 3;
			fmap = new int[sosts.GetLength(0), sosts.GetLength(1)];
			moving = new MovingPlayer(mob, pictureBoxes, sosts, offset, (Prize p) => { });
			mobPlace = moving.MyNowPoint();
			destinationPoint = mobPlace;
		}
		private void CreateTimer()
		{
			timer = new Timer();
			timer.Interval = 5;
			timer.Tick += Timer_Tick;
		}
		private void Timer_Tick(object sender, EventArgs e)
		{
			if (mobPlace == destinationPoint) GetNewPlace();
			if (path == null) return;
		    if(path[0].X == 0 && path[0].Y == 0 && !FindPath()) return;
			if (pathStep > paths) return;
			if (path[pathStep] == mobPlace) pathStep++;
			else Moving(path[pathStep]);
		}
		private void Moving(Point newPlace)
		{
			int sx = 0;
			int sy = 0;
			if (mobPlace.X < newPlace.X)
				sx = (newPlace.X - mobPlace.X > step) ? step : (newPlace.X - mobPlace.X);
			else
				sx = (mobPlace.X - newPlace.X < step) ? (newPlace.X - mobPlace.X) : -step;

			if (mobPlace.Y < newPlace.Y)
				sy = (newPlace.Y - mobPlace.Y > step) ? step : (newPlace.Y - mobPlace.Y);
			else
				sy = (mobPlace.Y - newPlace.Y < step) ? (newPlace.Y - mobPlace.Y) : -step;
			moving.Move(sx, sy);
			mobPlace = moving.MyNowPoint();

			if (
				 sosts[newPlace.X, newPlace.Y] == Sost.бомба ||
				 sosts[newPlace.X, newPlace.Y] == Sost.огонь ||
				 sosts[newPlace.X, newPlace.Y] == Sost.огоньочаг
				)
			{
				GetNewPlace();
			}
		}
		public bool FindPath()
		{
			for (int x = 0; x < fmap.GetLength(0); x++)
			{
				for (int y = 0; y < fmap.GetLength(1); y++)
				{
					fmap[x, y] = 0;
				}
			}

			

			fmap[mobPlace.X, mobPlace.Y] = 1;
			bool added = false;
			bool found = false;
			int nr = 1;
			do
			{
				added = false;
				for (int x = 0; x < fmap.GetLength(0); x++)
				{
					for (int y = 0; y < fmap.GetLength(1); y++)
					{
						if (fmap[x, y] == nr)
						{
							MarkPath(x + 1, y, nr + 1);
							MarkPath(x - 1, y, nr + 1);
							MarkPath(x, y + 1, nr + 1);
							MarkPath(x, y - 1, nr + 1);
							added = true;
						}
					}
				}

				if (fmap[destinationPoint.X, destinationPoint.Y] > 0)
				{
					found = true;
					break;
				}
				else
					nr++;
			} while (added);

			if (!found) return false;

			int sx = destinationPoint.X;
			int sy = destinationPoint.Y;
			path = new Point[nr + 1];
			paths = nr;
			while (nr >= 0)
			{
				path[nr].X = sx;
				path[nr].Y = sy;
				if (IsPath(sx + 1, sy, nr)) sx++;
				else if (IsPath(sx - 1, sy, nr)) sx--;
				else if (IsPath(sx, sy + 1, nr)) sy++;
				else if (IsPath(sx, sy - 1, nr)) sy--;
				nr--;
			}
			pathStep = 0;
			return true;

		}
		private void MarkPath(int x, int y, int nr)
		{
			if (x < 0 || x >= fmap.GetLength(0)) return;
			if (y < 0 || y >= fmap.GetLength(1)) return;
			if (fmap[x, y] > 0) return;
			if (sosts[x, y] != Sost.пусто) return;
			fmap[x, y] = nr;
		}
		private bool IsPath(int x, int y, int nr)
		{
			if (x < 0 || x >= fmap.GetLength(0)) return false;
			if (y < 0 || y >= fmap.GetLength(1)) return false;
			if (fmap[x, y] == nr) return true;
			return false;
		}
		private void GetNewPlace()
		{
			destinationPoint = man.MyNowPoint();
		    if (FindPath()) return;

			int loop = 0;
			do
			{
				destinationPoint.X = random.Next(1, sosts.GetLength(0)-1);
				destinationPoint.Y = random.Next(1, sosts.GetLength(1)-1);
			} while (!FindPath() && loop++ <= 100);

			if (loop >= 100)
				destinationPoint = mobPlace;
		}
		public Point MyNowPoint()
		{
			return moving.MyNowPoint();
		}
	}
}
