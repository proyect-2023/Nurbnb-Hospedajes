using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Application.UseCases.Checkout.Command.CrearCheckout
{
    public class CrearCheckoutCommand:IRequest<Guid>
    {
        public Guid OperacionId { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
    }
}
