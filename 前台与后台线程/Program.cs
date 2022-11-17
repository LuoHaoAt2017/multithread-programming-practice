// See https://aka.ms/new-console-template for more information

public class Foreground_Background_Thread
{
	static void Main(string[] args)
	{
		// 显式创建的线程都是前台线程
		Thread foregroundThread = new Thread(() =>
		{
			Console.WriteLine("等待6秒钟......");
			Thread.Sleep(6000);
			Console.WriteLine("Hello, 前台线程!");
		});
		foregroundThread.IsBackground = false;
		foregroundThread.Start();

		Thread backgroundThread1 = new Thread(() =>
		{
			Console.WriteLine("等待3秒钟......");
			Thread.Sleep(3000);
			Console.WriteLine("Hello, 后台线程!");
		});
		backgroundThread1.IsBackground = true;
		backgroundThread1.Start();

		Thread backgroundThread2 = new Thread(() =>
		{
			try
			{
				Console.WriteLine("等待9秒钟......");
				Thread.Sleep(9000);
				Console.WriteLine("这段语句不会执行，因为前台线程已经退出!");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.WriteLine("垃圾回收，定时器清理");
			}
		});
		backgroundThread2.IsBackground = true;
		backgroundThread2.Start();

		// 在退出程序时可以显式地等待这些后台线程结束。
		// 等待后台线程backgroundThread2的清理工作完成后，前台线程才会结束。
		backgroundThread2.Join();

		// 程序无法正常退出的一个很有可能的原因就是仍有前台线程存在。必须小心避免会使线程无法结束的 bug。
		// 在任一种情况下，都应指定一个超时时间，从而可以放弃由于某种原因而无法正常结束的线程。
	}
}