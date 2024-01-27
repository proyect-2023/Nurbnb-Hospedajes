using Microsoft.EntityFrameworkCore;
using Nurbnb.Hospedaje.Domain.Model.Checkin;
using Nurbnb.Hospedaje.Domain.Repositories;
using Nurbnb.Hospedaje.Infrastructure.EF.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Infrastructure.EF.Repositories
{
    internal class CheckinRepository:  ICheckinRepository
    {
        private readonly WriteDbContext _context;

        public CheckinRepository(WriteDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Checkin obj)
        {
            await _context.Checkin.AddAsync(obj);
        }

        

        public async Task<Checkin?> FindByIdAsync(Guid id)
        {
            return await _context.Checkin.SingleOrDefaultAsync(x => x.Id == id);
        }

        public Task UpdateAsync(Checkin checkin)
        {
            throw new NotImplementedException();
        }
    }
}
