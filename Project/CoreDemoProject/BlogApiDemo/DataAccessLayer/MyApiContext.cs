using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class MyApiContext:DbContext
    {

       
        public MyApiContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConStr_1_stepLocal = "Data Source=STHQ0121-08;Initial Catalog=MyAppDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;";
            string ConStr_2_2MyComp = "Data Source=(localdb)\\ProjectModels;Initial Catalog=MyApiDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;";



            optionsBuilder.UseSqlServer(ConStr_2_2MyComp);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
