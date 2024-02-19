using EntityLayer.Concretes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class MyAppDbContext : IdentityDbContext<AppUser,AppRole,int>
    {
        //public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options)
        //{
        //}
        public MyAppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConStr_1_stepLocal = "Data Source=STHQ0121-08;Initial Catalog=MyAppDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;";
            string ConStr_2_2MyComp = "Data Source=(localdb)\\ProjectModels;Initial Catalog=MyAppDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;";



            optionsBuilder.UseSqlServer(ConStr_2_2MyComp);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Message2>()
                .HasOne(x => x.Sender)
                .WithMany(x => x.WriterSender)
                .HasForeignKey(x => x.SenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(x => x.Receiver)
                .WithMany(x => x.WriterReceiver)
                .HasForeignKey(x => x.ReceiverId)
                .OnDelete(DeleteBehavior.ClientSetNull) ;


            base.OnModelCreating(modelBuilder);
        }


        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<NewLetter> NewLetters { get; set; }
        public DbSet<BlogRayting> BlogRaytings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Message2> Message2s { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
