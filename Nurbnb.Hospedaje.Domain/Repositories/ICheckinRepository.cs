using Nurbnb.Hospedaje.Domain.Model.Checkin;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Domain.Repositories
{
    public  interface ICheckinRepository : IRepository<Checkin,Guid>
    {
        Task UpdateAsync(Checkin newCheckin);
    }
}
