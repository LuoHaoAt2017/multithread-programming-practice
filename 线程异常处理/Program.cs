
public class Program
{
	public static void Main(string[] args)
	{
		try
		{
			Thread thread = new Thread(Done);
			thread.Name = "child thread";
			thread.Start();
		}
		catch
		{
			Console.WriteLine($"无法捕获到Done内部的异常");
		}
		finally
		{
			Console.WriteLine($"当线程开始运行后，其创建代码所在的try / catch / finally块与该线程不再有任何关系");
		}
	}

	public static void Done()
	{
		try
		{
			Thread.Sleep(1000);
			throw new Exception($"当前线程的名字：{Thread.CurrentThread.Name}");
		}
		catch(Exception ex)
		{
			Console.WriteLine($"捕获到异常: {ex.Message}");
		}
		finally
		{
			Console.WriteLine("在生产环境的程序中，所有线程的入口方法处都应该有一个异常处理器。");
		}

	}
}