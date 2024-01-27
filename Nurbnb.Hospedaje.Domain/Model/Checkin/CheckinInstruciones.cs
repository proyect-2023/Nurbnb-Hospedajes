using Restaurant.SharedKernel.Core;
using Restaurant.SharedKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Domain.Model.Checkin
{
    public record CheckinInstruciones:ValueObject
    {
        public string Value { get; init; }
        public CheckinInstruciones(string value)
        {
            CheckRule(new StringNotNullOrEmptyRule(value));
            this.Value = value;
        }
        public static implicit operator string(CheckinInstruciones instrucciones) => instrucciones.Value;
        public static implicit operator CheckinInstruciones(string instrucciones) => new(instrucciones);
    }
}
