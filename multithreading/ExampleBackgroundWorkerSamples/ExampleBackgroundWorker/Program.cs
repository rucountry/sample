using System;
using System.ComponentModel;
using System.Threading;

namespace ExampleBackgroundWorker
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter sample");
			string sample = Console.ReadLine();
			switch (sample)
			{
				case "1": Sample1(); break;
				case "2": Sample2(); break;
			}
		}

		static void Sample1()
		{
			var bw = new BackgroundWorker();

			bw.DoWork += (o, e) =>
			{
				Console.WriteLine($"{DateTime.Now.TimeOfDay} starting long running task");
				Thread.Sleep(10);
				Console.WriteLine($"{DateTime.Now.TimeOfDay} finish long running task");
			};

			bw.RunWorkerCompleted += (o, e) =>
			{
				if (e.Cancelled)
					Console.WriteLine($"{DateTime.Now.TimeOfDay} long running task cancelled");
				else if (e.Error != null)
				{
					Console.WriteLine($"{DateTime.Now.TimeOfDay} long running task failed. Error {e.Error}");
				}
				else
					Console.WriteLine($"{DateTime.Now.TimeOfDay} long running finished successfully");
			};

			bw.RunWorkerAsync();
			Console.ReadLine();
		}

		static void Sample2()
		{
			var bw = new BackgroundWorker();

			bw.DoWork += (o, e) =>
			{
				Console.WriteLine($"{DateTime.Now.TimeOfDay} starting long running task");

				for (int i = 0; i < 10; i++)
				{
					Thread.Sleep(TimeSpan.FromSeconds(2));
					bw.ReportProgress((i + 1) * 10);
					if (bw.CancellationPending)
					{
						Console.WriteLine($"{DateTime.Now.TimeOfDay} Task cancelled");
						break;
					}
				}

				Console.WriteLine($"{DateTime.Now.TimeOfDay} finish long running task");
			};

			bw.ProgressChanged += (o, e) =>
			{
				Console.WriteLine($"{DateTime.Now.TimeOfDay} Progress changed. Percentage: {e.ProgressPercentage}");
			};
			bw.RunWorkerCompleted += (o, e) =>
			{
				if (e.Cancelled)
					Console.WriteLine($"{DateTime.Now.TimeOfDay} long running task cancelled");
				else if (e.Error != null)
				{
					Console.WriteLine($"{DateTime.Now.TimeOfDay} long running task failed. Error {e.Error}");
				}
				else
					Console.WriteLine($"{DateTime.Now.TimeOfDay} long running finished successfully");
			};

			bw.WorkerReportsProgress = true; 
			bw.WorkerSupportsCancellation = true;

			bw.RunWorkerAsync();
			Console.ReadLine();

			if (bw.IsBusy)
				bw.CancelAsync();
			Console.ReadLine();
		}
	}
}
