using Microsoft.EntityFrameworkCore;
using System;
using UnderstandingTestingandDI.Lib.Models;

namespace UnderstandingTestingandDI.Lib.Data
{
    public class TestContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        //public DbSet<Account> Accounts { get; set; }

        private readonly string _connectionString;


        public TestContext(string connectionString)
        {
            this._connectionString = connectionString;
        }

        

        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(_connectionString);
            } 
        }


    }
}
