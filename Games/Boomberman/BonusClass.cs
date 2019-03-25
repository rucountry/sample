using System;
using System.Collections.Generic;

namespace Boomberman
{
	public enum Prize
	{
		пусто,
		бомба_плюс,
		бомба_минус,
		огонь_плюс,
		огонь_минус,
		бег_плюс,
		бег_минус
	}
	public static class BonusClass
	{
		private static Dictionary<Prize, int> percent;
		private static List<Prize> listBonus;
		private static Random rand = new Random();
		private static int kolBonus = 7;
		public static void Prepare()
		{
			PreparePercent();
			PrepareBonus();
		}
		private static void PreparePercent()
		{
			percent = new Dictionary<Prize, int>();
			percent.Add(Prize.бомба_плюс, 90);
			percent.Add(Prize.бомба_минус, 30);
			percent.Add(Prize.огонь_плюс, 60);
			percent.Add(Prize.огонь_минус, 20);
			percent.Add(Prize.бег_плюс, 60);
			percent.Add(Prize.бег_минус, 20);


		}
		private static void PrepareBonus()
		{
			listBonus = new List<Prize>();
			int sum = 0;
			foreach (var item in percent.Values)
			{
				sum += item;
			}
			do
			{
				int nomBonus = rand.Next(0, sum);
				int tBonus = 0;
				foreach (Prize prize in percent.Keys)
				{
					tBonus += percent[prize];
					if (nomBonus < tBonus)
					{
						listBonus.Add(prize);
						break;
					}
				}
			} while (listBonus.Count < kolBonus);
		}
		public static Prize GetBonus()
		{
			if (listBonus.Count == 0) return Prize.пусто;
			Prize prize = listBonus[0];
			listBonus.Remove(prize);
			return prize;
		}
	}
}
