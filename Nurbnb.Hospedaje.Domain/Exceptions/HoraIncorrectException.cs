using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Domain.Exceptions
{
    public class HoraIncorrectException:Exception
    {
        public HoraIncorrectException()
            : base("Formato de hora incorrecto, formato valido hh:mm")
        {
        }
    }
}
