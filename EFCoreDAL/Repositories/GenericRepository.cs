using DatabaseDomain.Interface;
using EFCoreDAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDAL.Repositories
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
        private readonly MainContext _context;

        public GenericRepository(MainContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIDAsync(long id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}
