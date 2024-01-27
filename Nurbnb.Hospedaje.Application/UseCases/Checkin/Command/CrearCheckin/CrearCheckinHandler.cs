using MediatR;
using Nurbnb.Hospedaje.Domain.Factories;
using Nurbnb.Hospedaje.Domain.Repositories;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Application.UseCases.Checkin.Command.CrearCheckin
{
    public class CrearCheckinHandler : IRequestHandler<CrearCheckinCommand, Guid>
    {
        private readonly ICheckinRepository _checkinRepository;
        private readonly ICheckinFactory _checkinFactory;
        private readonly IUnitOfWork _unitOfWork;
        public CrearCheckinHandler(ICheckinRepository checkinRepository,ICheckinFactory checkinFactory,IUnitOfWork unitOfWork)
        { 
             _checkinFactory = checkinFactory;
             _unitOfWork = unitOfWork;
             _checkinRepository = checkinRepository;
        }

        public async Task<Guid> Handle(CrearCheckinCommand request, CancellationToken cancellationToken)
        {
            var checkinCreado = _checkinFactory.CrearCheckin(request.OperacionId, request.Fecha, request.Hora,request.Instrucciones);
            await _checkinRepository.CreateAsync(checkinCreado);

            await _unitOfWork.Commit();

            return (checkinCreado != null ? checkinCreado.Id: Guid.NewGuid());
        }
    }
}
