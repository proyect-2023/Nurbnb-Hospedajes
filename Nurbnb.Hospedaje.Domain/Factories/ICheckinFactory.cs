using Nurbnb.Hospedaje.Domain.Model.Checkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Domain.Factories
{
    public interface ICheckinFactory
    {
        Checkin CrearCheckin(Guid operacionId, DateTime fecha, string hora, string instrucciones);
    }
}
