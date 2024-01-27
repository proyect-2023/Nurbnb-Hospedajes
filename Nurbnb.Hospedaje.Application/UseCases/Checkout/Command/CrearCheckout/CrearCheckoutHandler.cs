using MediatR;
using Nurbnb.Hospedaje.Domain.Factories;
using Nurbnb.Hospedaje.Domain.Repositories;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Application.UseCases.Checkout.Command.CrearCheckout
{
    public class CrearCheckoutHandler : IRequestHandler<CrearCheckoutCommand, Guid>
    {
        private readonly ICheckoutRepository _checkoutRepository;
        private readonly ICheckoutFactory _checkoutFactory;
        private readonly IUnitOfWork _unitOfWork;
        public CrearCheckoutHandler(ICheckoutRepository checkoutRepository, ICheckoutFactory checkoutFactory, IUnitOfWork unitOfWork)
        {
            _checkoutFactory = checkoutFactory;
            _unitOfWork = unitOfWork;
            _checkoutRepository = checkoutRepository;
        }
        public async Task<Guid> Handle(CrearCheckoutCommand request, CancellationToken cancellationToken)
        {
            var checkoutCreado = _checkoutFactory.CrearCheckout(request.OperacionId, request.Fecha, request.Hora);
            await _checkoutRepository.CreateAsync(checkoutCreado);

            await _unitOfWork.Commit();

            return (checkoutCreado != null ? checkoutCreado.Id : Guid.NewGuid());
        }
    }
}
