using Nurbnb.Hospedaje.Domain.Model.Checkout;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Domain.Repositories
{
    public interface ICheckoutRepository:IRepository<Checkout,Guid>
    {
        Task UpdateAsync(Checkout newCheckout);
    }
}
