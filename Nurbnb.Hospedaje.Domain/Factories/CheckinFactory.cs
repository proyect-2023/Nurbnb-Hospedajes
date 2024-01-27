using Nurbnb.Hospedaje.Domain.Model.Checkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Domain.Factories
{
    public class CheckinFactory : ICheckinFactory
    {
        public Checkin CrearCheckin(Guid operacionId, DateTime fecha, string hora, string instrucciones)
        {
            return new Checkin(operacionId,fecha, hora, instrucciones);
        }
    }
}
