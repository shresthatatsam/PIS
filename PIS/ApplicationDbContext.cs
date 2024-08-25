
    using PIS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

    namespace bank
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


         //modelBuilder.Entity<BankDetailsViewModel>(entity =>
         //   {
         //       entity.ToTable("bankdetails");
         //       entity.HasKey(e => e.bank_id);
         //       entity.Property(e => e.bank_name).IsRequired(false);
         //       entity.Property(e => e.account_number).IsRequired(false);

         //       entity.HasOne(ug => ug.currency)
         //             .WithMany(u => u.bankdetails)
         //             .HasForeignKey(ug => ug.currency_id)
         //             .OnDelete(DeleteBehavior.Restrict)
         //             .IsRequired();

         //   });


          
           
           


            base.OnModelCreating(modelBuilder);
            }

        }
    }


