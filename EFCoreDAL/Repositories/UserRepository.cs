using DatabaseDomain.DTO.Security;
using DatabaseDomain.Entities;
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
    public class UserRepository : GenericRepository<UserDomain>, IUserDomain
    {
        private readonly MainContext _context;
        public UserRepository(MainContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserInfoDTO>> GetAllUsersDTOAsync()
        {
            return await _context.Users.Select(r => new UserInfoDTO()
            {
                Id = r.Id,
                IsActive = r.IsActive,
                IsAdmin = r.IsAdmin,
                Username = r.Username
            }).ToListAsync();
        }
    }
}
