using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


namespace XoXo.Models
{
    public class AppDbContext:IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

       
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Employee> Employees { get; set; }


        


   




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // تكوين الكيانات الأخرى الخاصة بك
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, Name = "computer" },
                new Category() { CategoryId = 2, Name = "mobile" },
                new Category() { CategoryId = 3, Name = "machin" }
            );


            //modelBuilder.Entity<IdentityRole>().HasData(
            //    new IdentityRole()
            //    {
            //        Id=Guid.NewGuid().ToString(),
            //        Name="Admin",
            //        NormalizedName="admin",
            //        ConcurrencyStamp= Guid.NewGuid().ToString()

            //    },

            //    new IdentityRole()
            //    {
            //        Id = Guid.NewGuid().ToString(),
            //        Name="User",
            //        NormalizedName="user",
            //        ConcurrencyStamp= Guid.NewGuid().ToString()
            //    }
            //    );

          
        }


    }
}
