using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Keepr.Web.Models;

namespace Keepr.Web.Data
{
    public class KeeprContext : DbContext
    {
        public DbSet<Keep> Keeps { get; set; }
        public DbSet<Vault> Vaults { get; set; }
        public KeeprContext(DbContextOptions ctx) : base(ctx)
        {

        }
    }
}