using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nurbnb.Hospedaje.Domain.Model.Checkin;
using Nurbnb.Hospedaje.Domain.Model.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Infrastructure.EF.Config
{
    internal class CheckoutConfig : IEntityTypeConfiguration<Checkout>
    {
        public void Configure(EntityTypeBuilder<Checkout> builder)
        {
            builder.ToTable("checkout");
            builder.HasKey(x => x.Id);


            builder.Property(x => x.Id)
                .HasColumnName("checkoutId");

            builder.Property(x => x.OperacionId)
                .HasColumnName("operacionId");

            builder.Property(x => x.FechaSalida)
               .HasColumnName("fecha");


            var horaConverter = new ValueConverter<CheckoutHora, string>(
                horaValue => horaValue.Value,
                hora => new CheckoutHora(hora)
            );

            builder.Property(x => x.HoraSalida)
                .HasConversion(horaConverter)
                .HasColumnName("hora");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}
