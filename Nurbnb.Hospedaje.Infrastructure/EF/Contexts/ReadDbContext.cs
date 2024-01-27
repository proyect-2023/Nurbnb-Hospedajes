using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nurbnb.Hospedaje.Infrastructure.EF.ReadModel;

namespace Nurbnb.Hospedaje.Infrastructure.EF.Contexts
{
    internal class ReadDbContext: DbContext
    {
        public virtual DbSet<CheckinReadModel> Checkin { get; set; }
        public virtual DbSet<CheckoutReadModel> Checkout { get; set; }
        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
