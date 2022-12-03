using System.Data;
using System.Data.SqlClient;

namespace ProductStoreServer.Common
{
	public class SqlServerHelper
	{

		public static DataSet Query(string sql, string conn)
		{
			using (SqlConnection connection = new SqlConnection(conn))
			{
				DataSet ds = new DataSet();
				try
				{
					connection.Open();
					SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
					adapter.Fill(ds);
				}
				catch(SqlException ex)
				{
					LogHelper.Error(ex.Message);
				}
				finally
				{
					connection.Close();
				}
				return ds;
			}
		}
	}
}
