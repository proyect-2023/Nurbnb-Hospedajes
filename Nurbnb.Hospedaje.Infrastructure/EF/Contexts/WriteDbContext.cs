using Microsoft.EntityFrameworkCore;
using Nurbnb.Hospedaje.Domain.Model.Checkin;
using Nurbnb.Hospedaje.Domain.Model.Checkout;
using Nurbnb.Hospedaje.Infrastructure.EF.Config;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Infrastructure.EF.Contexts
{
    internal class WriteDbContext: DbContext
    {
        public virtual DbSet<Checkin> Checkin { set; get; }
        public virtual DbSet<Checkout> Checkout { set; get; }
        

        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var checkinConfig = new CheckinConfig();
            modelBuilder.ApplyConfiguration<Checkin>(checkinConfig);

            var checkoutConfig = new CheckoutConfig();
            modelBuilder.ApplyConfiguration<Checkout>(checkoutConfig);


            modelBuilder.Ignore<DomainEvent>();

        }
    }
}
