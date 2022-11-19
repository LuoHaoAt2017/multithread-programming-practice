

public class Program
{
	public static void Main()
	{
		Func<string, int> method = Calculate;
		// .net和.net core平台都有这个问题，一查原来是更新后推荐使用(TAP)新的异步编程来实现，原来的BeginInvoke()不再支持了
		method.BeginInvoke("Hello", Callback, method);
	}

	public static int Calculate(string strs)
	{
		return strs.Length;
	}

	public static void Callback(IAsyncResult cookie)
	{
		if (cookie != null)
		{
			var target = (Func<string, int>)cookie.AsyncState;
			int result = target.EndInvoke(cookie);
			Console.WriteLine($"result = {result}");
		}
	}
}