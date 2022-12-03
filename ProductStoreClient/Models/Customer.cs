
namespace ProductStoreClient.Models
{
	public record class Customer(
		string CustomerId = "", 
		string CompanyName = "", 
		string ContactName = "", 
		string ContactTitle = "", 
		string Address = "", 
		string City = "", 
		string Region = "",
		string PostalCode = "",
		string Country = "",
		string Phone = "",
		string Fax = ""
	);
}
