using DatabaseDomain.Interface;
using EFCoreDAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDAL.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWork
    {
        private readonly MainContext _context;
        public IUserDomain _user { get; set; }

        public UnitOfWorkRepository(MainContext context)
        {
            _context = context;
            _user = new UserRepository(context);
        }


        public void Complete()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }
    }
}
