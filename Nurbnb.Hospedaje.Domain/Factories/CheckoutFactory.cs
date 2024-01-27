using Nurbnb.Hospedaje.Domain.Model.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Domain.Factories
{
    public class CheckoutFactory : ICheckoutFactory
    {
        public Checkout CrearCheckout(Guid operacionId, DateTime fechaSalida, string hora)
        {
            return new Checkout(operacionId, fechaSalida, hora);
        }
    }
}
