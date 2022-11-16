namespace ProductStore
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			FileInfo info = new FileInfo("log4net.config");
			log4net.Config.XmlConfigurator.Configure(info);
			ApplicationConfiguration.Initialize();
			Application.Run(new ProductStore());
		}
	}
}