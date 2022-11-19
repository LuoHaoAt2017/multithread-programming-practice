
public class Program
{
	public static void Main()
	{
		

		Task<string> task = Task.Factory.StartNew<string>(() => Download("http://www.gkarch.com"));

		task.Wait();

		Console.WriteLine(task.Result);

		Console.WriteLine("Hello, World!");
	}

	public static string Download(string url)
	{
		Thread.Sleep(1000);
		return url;
	}
}