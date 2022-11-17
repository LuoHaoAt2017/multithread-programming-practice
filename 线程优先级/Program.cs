
public class Program
{
	public static void Main()
	{
		List<Thread> threads = new List<Thread>();

		List<ThreadPriority> priorityList = new List<ThreadPriority>() { 
			ThreadPriority.Lowest, 
			ThreadPriority.BelowNormal, 
			ThreadPriority.Normal,
			ThreadPriority.AboveNormal,
			ThreadPriority.Highest
		};

		for(int i = 0; i < priorityList.Count; i++)
		{
			int index = i;
			Thread thread = new Thread(() =>
			{
				Thread.Sleep(1000);
				Console.WriteLine($"Thread-{index}");
			});
			thread.Priority = priorityList[index];
			threads.Add(thread);
		}

		for(int i = 0; i < threads.Count; i++)
		{
			Thread thread = threads[i];
			thread.Start();
		}
		
		Console.WriteLine("优先级高的线程一定先执行，然后才会轮到优先级低的线程执行。这种认识是错误的。");
		Console.WriteLine("优先级高的线程相较于优先级低的线程有较大的概率优先执行，是概率层面。");
	}
}