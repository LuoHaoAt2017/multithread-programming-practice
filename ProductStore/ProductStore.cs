namespace ProductStore
{
	public partial class ProductStore : Form
	{
		public ProductStore()
		{
			InitializeComponent();
		}

		private void ProductStoreLoad(object sender, EventArgs e)
		{
			this.SetupDataGridView();
			this.SetupLayout();

			Thread.CurrentThread.Name = "Main";

			Thread thread1 = new Thread(() => this.FetchProductList("food"));
			thread1.Name = "FetchProductList";
			thread1.Start();

			Thread thread2 = new Thread(this.RefreshProductList);
			thread2.Name = "RefreshProductList";
			thread2.Start();

			TestThreading();
		}

		private void FetchProductList(object param)
		{
			string category = (string)param;
			LogHelper.Log($"fetch products: {category}");
		}

		private void RefreshProductList()
		{

		}

		private void SetupDataGridView()
		{

		}

		private void SetupLayout()
		{

		}

		private void TestThreading()
		{
			for(int i = 0; i < 3; i++)
			{
				new Thread(() => LogHelper.Log($"index: {i}")).Start();
			}
		}
	}
}