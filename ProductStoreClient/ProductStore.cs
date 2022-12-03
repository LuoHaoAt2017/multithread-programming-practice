using ProductStoreClient.Models;
using System.Net.Http.Json;

namespace ProductStore
{
	public partial class ProductStore : Form
	{
		private readonly HttpClient client = new HttpClient()
		{
			BaseAddress = new Uri("https://localhost:7053"),
		};

		public ProductStore()
		{
			InitializeComponent();
			this.SetupLayout();
		}

		private void ProductStoreLoad(object sender, EventArgs e)
		{
			FetchProductList("");
		}

		private async void FetchProductList(object? param)
		{
			var customers = await client.GetFromJsonAsync<List<Customer>>("/api/Customer");
			if (customers == null)
			{
				return;
			}
			this.RefreshCustomersList(customers);
		}

		private void RefreshCustomersList(List<Customer> customers)
		{
			foreach (var todo in customers)
			{
				LogHelper.Log($"{todo.ContactName} - {todo.ContactTitle}");
			}
		}

		private void SetupDataGridView()
		{

		}

		private void SetupLayout()
		{

		}
	}
}