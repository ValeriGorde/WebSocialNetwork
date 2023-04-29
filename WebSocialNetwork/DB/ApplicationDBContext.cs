using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebSocialNetwork.Configs;
using WebSocialNetwork.Models;
using WebSocialNetwork.Views;

namespace WebSocialNetwork.DB
{
    public class ApplicationDBContext: IdentityDbContext<User>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration<Friend>(new FriendConfiguration());
            builder.ApplyConfiguration(new MessageConfiguration());
        }
    }
}
