using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Domain.Model.Checkin
{
    public class Checkin: AggregateRoot
    {
        public Guid OperacionId { get; private set; }
        public DateTime Fecha { get; private set; }
        public CheckinHora Hora { get; private set; }
        public CheckinInstruciones Instrucciones { get; private set; }

        public Checkin(Guid operacionId,DateTime fecha, string hora,string instrucciones)
        {
            Id=Guid.NewGuid();
            OperacionId=operacionId;
            Fecha=fecha;
            Hora= new CheckinHora(hora);
            Instrucciones= new CheckinInstruciones(instrucciones);
        }

        public Checkin() { }
    }
}
