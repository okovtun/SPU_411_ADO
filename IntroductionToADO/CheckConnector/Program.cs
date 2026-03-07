using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckConnector
{
	class Program
	{
		static void Main(string[] args)
		{
			//string connection_string = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Movies_SPU_411;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			string connection_string = "";
			Connector.Connector connector = new Connector.Connector(connection_string);
		}
	}
}
