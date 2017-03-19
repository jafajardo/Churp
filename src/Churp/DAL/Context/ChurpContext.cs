using Churp.DAL.DataModel;
using Microsoft.EntityFrameworkCore;

namespace Churp.DAL.Context
{
    public class ChurpContext : DbContext
    {
        public ChurpContext(DbContextOptions<ChurpContext> options) : base(options)
        { }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationTimeUnit> NotificationTimeUnits { get; set; }
        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RemovePluralizingTableNameConvention();
        }
    }
}
