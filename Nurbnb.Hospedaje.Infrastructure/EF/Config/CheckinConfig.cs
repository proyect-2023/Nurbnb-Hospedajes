using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nurbnb.Hospedaje.Domain.Model.Checkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Infrastructure.EF.Config
{
    internal class CheckinConfig : IEntityTypeConfiguration<Checkin>
    {
        public void Configure(EntityTypeBuilder<Checkin> builder)
        {
            builder.ToTable("checkin");
            builder.HasKey(x => x.Id);


            builder.Property(x => x.Id)
                .HasColumnName("checkinId");

            builder.Property(x => x.OperacionId)
                .HasColumnName("operacionId");

            builder.Property(x => x.Fecha)
               .HasColumnName("fecha");

           
            var horaConverter = new ValueConverter<CheckinHora, string>(
                horaValue => horaValue.Value.ToString(),
                hora => new CheckinHora(hora)
            );

  

            builder.Property(x => x.Hora)
                .HasConversion(horaConverter)
                .HasColumnName("hora");



            var instruccionesConverter = new ValueConverter<CheckinInstruciones, string>(
                instruccionValue => instruccionValue.Value,
                instruccion => new CheckinInstruciones(instruccion)
            );

            builder.Property(x => x.Instrucciones)
                .HasConversion(instruccionesConverter)
                .HasColumnName("instrucciones");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}
