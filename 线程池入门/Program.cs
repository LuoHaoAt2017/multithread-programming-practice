
// 任务并行库: TPL
// 在 .NET Framework 4.0 之前不支持 TPL。

public class Program
{
	public static void Main(string[] args)
	{
		// Console.WriteLine("Hello, World!");

		ThreadPool.QueueUserWorkItem(new WaitCallback(Go));

		ThreadPool.QueueUserWorkItem(Go, "Tomcat");

		// 后台线程的异常并不会被抛出来
		Thread thread = new Thread(Done);
		thread.IsBackground = true;
		thread.Start();

		TestThreading();
	}

	// 目标方法Go，必须接受单一一个object参数，来满足 WaitCallback 委托
	public static void Go(object? data)
	{
		try
		{
			throw new Exception("Show me the money");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			Console.WriteLine("必须在目标代码中显式处理异常，未处理的异常会令程序结束。");
		}
		
		Console.WriteLine("Hello from the thread pool! " + data);
	}

	public static void Done()
	{
		throw new Exception("Who is your dady");
	}

	private static void TestThreading()
	{
		for (int i = 0; i < 3; i++)
		{
			new Thread(() => Console.WriteLine($"index: {i}")).Start();
		}
	}
}