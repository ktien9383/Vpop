using Vpop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Vpop.Data
{
    public class OrderDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Order> Orders { get; set; }
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {
        }

    }
}
