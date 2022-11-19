
public class Program
{
	public static void Main()
	{
		Thread thread1 = new Thread(() => FetchProductList("food"));
		thread1.Name = "thread1";
		thread1.Start();

		Thread thread2 = new Thread(FetchProductList);
		thread2.Name = "thread2";
		thread2.Start("food");
	}

	public static void FetchProductList(object? param)
	{
		if (param != null)
		{
			Console.WriteLine((string)param);
		}
	}
}