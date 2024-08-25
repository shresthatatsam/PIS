
    using PIS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

    namespace PIS
{
        public class ApplicationDbContext : DbContext
        {
            private readonly IConfiguration _configuration;

            public ApplicationDbContext(IConfiguration configuration)
            {
                _configuration = configuration;
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            }




        public DbSet<UserInformationViewModel> UserInformations { get; set; }

        //second slide




        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {


            modelBuilder.Entity<UserInformationViewModel>(entity =>
               {
                   entity.ToTable("userDetails");
                   entity.HasKey(e => e.user_id);
                   entity.Property(e => e.user_name).IsRequired(true);
                   entity.Property(e => e.password).IsRequired(true);
                   entity.Property(e => e.is_active).HasDefaultValue(true);
                   entity.Property(e => e.created_date).IsRequired(false);


               });

            base.OnModelCreating(modelBuilder);
            }

        }
    }


