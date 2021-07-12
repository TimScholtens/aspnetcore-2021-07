using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Controllers
{
	public class VroegahController
	{
		public void Doe()
		{

			//         mysql_connect()
			//         $query = ...
			//             $result = mysql_query($query) or trigger_error(mysql_error());
			//         while($row = mysql_fetch_assoc($result)) {

			//}


			// ADO.NET


			// plain old classes (2001)
			using (var connection = new SqlConnection("Data Source=.; Initial Catalog..."))
			{
				connection.Open();

				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandType = System.Data.CommandType.Text;
					command.CommandText = "SELECT * FROM Klant;"; // SQL injection
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							var name = reader["Name"].ToString();
							var leeftijd = Convert.ToInt32(reader["Leeftijd"]);

						}
					}
				}
			}

			// datasets/datatables (2004)


			// Endeavour? => softwareontwikkelstraat van Info Support


			// LINQ to SQL (2008)

			// LINQ to Entities => Entity Framework (2009/2010) (.NET Framework)
			// - database first
			// - model first
			// - code first

			// Entity Framework Core (2016)
			// - code first

			// 60.000 records in de database pompen
		}
	}
}
