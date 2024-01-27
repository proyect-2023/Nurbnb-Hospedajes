using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Application.UseCases.Checkin.Command.CrearCheckin
{
    public class CrearCheckinCommand:IRequest<Guid>
    {
        public Guid OperacionId { get;  set; }
        public DateTime Fecha { get;  set; }
        public string Hora { get;  set; }
        public string Instrucciones { get;  set; }
    }
}
