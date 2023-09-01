using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurantEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-DH0KVAT\\SQLEXPRESS;initial catalog=ApiDb;integrated security=true");
        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Guest> Guests { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<SendMessage> SendMessages { get; set; }
        public DbSet<MessageCategory> MessageCategories { get; set; }

    }
}
