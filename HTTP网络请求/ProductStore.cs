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
	}
}