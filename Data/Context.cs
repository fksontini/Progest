
using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Context:DbContext
    {
        public Context():base("Name=MyCnx")
        {
               
        }
        public DbSet<Project> project{ get; set; }
        public DbSet<Backlog> module { get; set; }
        public DbSet<Tasks> tasks { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //    //modelBuilder.Conventions.Add(new DateTime2Convention());
        //    //modelBuilder.Configurations.Add(new ProductConfiguration());
        //}

    }
    //public class MyFinanceContextInitialiser : DropCreateDatabaseIfModelChanges<Context>
    //{
    //    protected override void Seed(Context context)
    //    {
    //        Product p = new Product();
    //        p.Name = "def prod";
    //        p.Description = "def desc";
    //        p.fullprice = new FullPrice { Price = 15, Quantity = 17 };
    //        p.DateProd = DateTime.Now;
    //        context.product.Add(p);
    //        context.SaveChanges();

    //    }

    //}


}
