using Microsoft.EntityFrameworkCore;
using Nurbnb.Hospedaje.Domain.Model.Checkin;
using Nurbnb.Hospedaje.Domain.Model.Checkout;
using Nurbnb.Hospedaje.Domain.Repositories;
using Nurbnb.Hospedaje.Infrastructure.EF.Contexts;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Infrastructure.EF.Repositories
{
    internal class CheckoutRepository:ICheckoutRepository
    {
        private readonly WriteDbContext _context;

        public CheckoutRepository(WriteDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Checkout obj)
        {
            await _context.Checkout.AddAsync(obj);
        }

       

        

        public Task UpdateAsync(Checkout checkout)
        {
            throw new NotImplementedException();
        }

        public async Task<Checkout?> FindByIdAsync(Guid id)
        {
            return await _context.Checkout.
               SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
