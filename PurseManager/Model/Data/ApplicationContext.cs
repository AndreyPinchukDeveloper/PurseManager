using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurseManager.Model.Data
{
    public class ApplicationContext:DbContext
    {
        public DbSet<OperationModel> OperationModel { get; set; }
        public DbSet<UserMoneyModel> UserMoneyModel { get; set; }
        public DbSet<ExpenseCategoryModel> ExpenseCategoryModel { get; set; }
        public DbSet<IncomeCategoryModel> IncomeCategoryModel { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();//if data base doesn't exist, this method create it
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PuseMangerDB;Trusted_Connection = true;");
        }
    }
}
