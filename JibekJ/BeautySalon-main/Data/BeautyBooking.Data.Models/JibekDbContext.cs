using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyBooking.Data.Models
{
	public class JibekDbContext : DbContext
	{
		private readonly String _connectionString = "Data Source=DESKTOP-B7J13O2\\SQLEXPRESS;Initial Catalog=BeautyBooking;User ID=sa;Password=2022; MultipleActiveResultSets=true;";
		public DbSet<Tovar> Tovars { get; set; }
		
	}
}
