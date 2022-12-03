using System.Data;

namespace ProductStoreServer.Common
{
	public enum DefaultDB
	{
		MySql,
		SQLServer,
		Oracle,
		NULL
	}

	public class DBHelper
	{
		public static DataTable ExecuteSql(DefaultDB dbType, string sql, string conn)
		{
			switch(dbType)
			{
				case DefaultDB.SQLServer:
					DataSet ds = SqlServerHelper.Query(sql, conn);
					if(ds == null || ds.Tables == null || ds.Tables.Count == 0)
					{
						return null;
					}
					return ds.Tables[0];
				case DefaultDB.MySql:
					return null;
				case DefaultDB.Oracle:
					return null;
				default:
					return null;
			}
		}
	}
}
