using System;
using Microsoft.EntityFrameworkCore;
using small_api.Models;

namespace small_api.Data
{
	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions<DbContext> options) : base(options)
		{
		}

		DbSet<Website> websites { get; set; } = null!;
	}
}

