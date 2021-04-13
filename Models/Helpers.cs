using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;



namespace BYUArchaeologyEgypt.Models
{
	public class Helpers
	{
		public static string GetRDSConnectionString()
		{
			return "Data Source=aa1ckyqrn1p3p3s.cmtvlmyxbvpy.us-east-1.rds.amazonaws.com;Initial Catalog=burialdb;User ID=admin;Password=intex123;";
		}
	}
}