using System;
using DataImport.Models;
namespace DataImport.Models
{
    public class RootObject
	{
		public string _embedded { get; set; }
		public PageInfo page { get; set; }
	}
}
