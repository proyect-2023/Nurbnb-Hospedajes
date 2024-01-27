using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Domain.Model.Checkout
{
    public class Checkout:AggregateRoot
    {
        public Guid OperacionId { get; private set; }
        public DateTime FechaSalida { get; private set; }
        public CheckoutHora HoraSalida { get; private set; }

        public Checkout(Guid operacionId, DateTime fechaSalida,string hora)
        {
            Id= Guid.NewGuid();
            OperacionId= operacionId;
            FechaSalida= fechaSalida;
            HoraSalida= new CheckoutHora(hora);
        }
        public Checkout() { }
    }
}
