using Nurbnb.Hospedaje.Domain.Model.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Domain.Factories
{
    public interface ICheckoutFactory
    {
        Checkout CrearCheckout(Guid operacionId, DateTime fechaSalida, string hora);
    }
}
