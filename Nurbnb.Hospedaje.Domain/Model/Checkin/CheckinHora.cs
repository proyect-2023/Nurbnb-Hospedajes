using Nurbnb.Hospedaje.Domain.Exceptions;
using Restaurant.SharedKernel.Core;
using Restaurant.SharedKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Domain.Model.Checkin
{
    public record CheckinHora:ValueObject
    {
        public string Value { get; init; }
        public CheckinHora(string value)
        {
            CheckRule(new StringNotNullOrEmptyRule(value));
            //hh:mm
            if (value.Length >5)
                throw new HoraIncorrectException();

            if (!value.Contains(":"))
                throw new HoraIncorrectException();
            this.Value = value;
        }
        public static implicit operator string(CheckinHora hora) => hora.Value;
        public static implicit operator CheckinHora(string hora) => new(hora);
    }
}
