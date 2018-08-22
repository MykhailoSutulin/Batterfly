using DataModels.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataStorage
{
    public class BatContext : DbContext
	{
		public BatContext(DbContextOptions<BatContext> options)

		   : base(options) { }
		public BatContext() { }

		public DbSet<Person> Persons { get; set; }
	}
}
