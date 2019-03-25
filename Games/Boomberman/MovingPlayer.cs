using System.Drawing;
using System.Windows.Forms;

namespace Boomberman
{
	class MovingPlayer
	{
		private readonly PictureBox player;
		private readonly PictureBox[,] pictureBox;
		private readonly Sost[,] sosts;
		private readonly int offset;
		private deAddBonus addBonus;
		public MovingPlayer(PictureBox player, PictureBox[,] pictureBox, Sost[,] sosts, int offset, deAddBonus debonus)
		{
			this.player = player;
			this.pictureBox = pictureBox;
			this.sosts = sosts;
			this.offset = offset;
			addBonus = debonus;
		}

		public void Move(int x, int y)
		{
			if (IsEmpty(ref x, ref y))
				player.Location = new Point(player.Location.X + x, player.Location.Y + y);
			Point p = MyNowPoint();
			if (sosts[p.X, p.Y] == Sost.приз)
			{
				addBonus(BonusClass.GetBonus());
				sosts[p.X, p.Y] = Sost.пусто;
				pictureBox[p.X, p.Y].Image = Properties.Resources.field;
			}
		}
		private bool IsEmpty(ref int x, ref int y)
		{
			Point point = MyNowPoint();

			if (point.X >= pictureBox.GetLength(0)-1) return false;
			if (point.Y >= pictureBox.GetLength(1)-1) return false;

			int manRight = player.Location.X + player.Size.Width;
			int manLeft = player.Location.X;
			int manDown = player.Location.Y + player.Size.Height;
			int manUp = player.Location.Y;

			int rightWallLeft = pictureBox[point.X + 1, point.Y].Location.X;
			int leftWallRight = pictureBox[point.X - 1, point.Y].Location.X + pictureBox[point.X - 1, point.Y].Size.Width;
			int downWallUp = pictureBox[point.X, point.Y + 1].Location.Y;
			int upWallDown = pictureBox[point.X, point.Y - 1].Location.Y + pictureBox[point.X, point.Y - 1].Size.Height;

			int rightUpWallDown = pictureBox[point.X + 1, point.Y - 1].Location.Y + pictureBox[point.X + 1, point.Y - 1].Size.Height;
			int rightDownWallUp = pictureBox[point.X + 1, point.Y + 1].Location.Y;
			int leftUpWallDown = pictureBox[point.X - 1, point.Y - 1].Location.Y + pictureBox[point.X - 1, point.Y - 1].Size.Height;
			int leftDownWallUp = pictureBox[point.X - 1, point.Y + 1].Location.Y;

			int rightUpWallLeft = pictureBox[point.X + 1, point.Y - 1].Location.X;
			int rightDownWallLeft = pictureBox[point.X + 1, point.Y + 1].Location.X;
			int leftUpWallRight = pictureBox[point.X - 1, point.Y - 1].Location.X + pictureBox[point.X - 1, point.Y - 1].Size.Width;
			int leftDownWallRight = pictureBox[point.X - 1, point.Y + 1].Location.X + pictureBox[point.X - 1, point.Y + 1].Size.Width;


			if (x > 0 && (sosts[point.X + 1, point.Y] == Sost.пусто 
				|| sosts[point.X + 1, point.Y] == Sost.огонь 
				|| sosts[point.X + 1, point.Y] == Sost.огоньочаг
				|| sosts[point.X + 1, point.Y] == Sost.приз
				))
			{
				if (manUp < rightUpWallDown)
				{
					if (rightUpWallDown - manUp > offset)
						y = offset;
					else
						y = rightUpWallDown - manUp;
				}
				if (manDown > rightDownWallUp)
				{
					if (rightDownWallUp - manDown < -offset)
						y = -offset;
					else
						y = rightDownWallUp - manDown;
				}
				return true;
			}
			if (x < 0 && (sosts[point.X - 1, point.Y] == Sost.пусто 
				|| sosts[point.X - 1, point.Y] == Sost.огонь 
				|| sosts[point.X - 1, point.Y] == Sost.огоньочаг
				|| sosts[point.X - 1, point.Y] == Sost.приз
				))
			{
				if (manUp < leftUpWallDown)
					if (leftUpWallDown - manUp > offset)
						y = offset;
					else
						y = leftUpWallDown - manUp;
				if (manDown > leftDownWallUp)
					if (leftDownWallUp - manDown < -offset)
						y = -offset;
					else
						y = leftDownWallUp - manDown;
				return true;
			}
			if (y > 0 && (sosts[point.X, point.Y + 1] == Sost.пусто 
				|| sosts[point.X, point.Y + 1] == Sost.огонь 
				|| sosts[point.X, point.Y + 1] == Sost.огоньочаг
				|| sosts[point.X, point.Y + 1] == Sost.приз
				))
			{
				if (manRight > rightDownWallLeft)
					if (rightDownWallLeft - manRight < -offset)
						x = -offset;
					else
						x = rightDownWallLeft - manRight;
				if (manLeft < leftDownWallRight)
					if (leftDownWallRight - manLeft > offset)
						x = offset;
					else
						x = leftDownWallRight - manLeft;
				return true;
			}
			if (y < 0 && (sosts[point.X, point.Y - 1] == Sost.пусто 
				|| sosts[point.X, point.Y - 1] == Sost.огонь 
				|| sosts[point.X, point.Y - 1] == Sost.огоньочаг
				|| sosts[point.X, point.Y - 1] == Sost.приз
				))
			{
				if (manRight > rightUpWallLeft)
					if (rightUpWallLeft - manRight < -offset)
						x = -offset;
					else
						x = offset;
				x = rightUpWallLeft - manRight;
				if (manLeft < leftUpWallRight)
					if (leftUpWallRight - manLeft > offset)
						x = offset;
					else
						x = leftUpWallRight - manLeft;
				return true;
			}



			if (x > 0 && manRight + x > rightWallLeft)
				x = rightWallLeft - manRight;
			if (x < 0 && manLeft + x < leftWallRight)
				x = leftWallRight - manLeft;
			if (y > 0 && manDown + y > downWallUp)
				y = downWallUp - manDown;
			if (y < 0 && manUp + y < upWallDown)
				y = upWallDown - manUp;

			return true;
		}
		public Point MyNowPoint()
		{
			Point point = new Point
			{
				X = player.Location.X + player.Size.Width / 2,
				Y = player.Location.Y + player.Size.Height / 2
			};

			for (int x = 0; x < pictureBox.GetLength(0); x++)
			{
				for (int y = 0; y < pictureBox.GetLength(1); y++)
				{
					if (pictureBox[x, y].Location.X < point.X &&
						pictureBox[x, y].Location.Y < point.Y &&
						pictureBox[x, y].Location.X + pictureBox[x, y].Size.Width > point.X &&
						pictureBox[x, y].Location.Y + pictureBox[x, y].Size.Height > point.Y
						)
						return new Point(x, y);
				}
			}
			
			return point;
		}
	}
}
