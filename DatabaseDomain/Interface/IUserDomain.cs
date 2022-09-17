using DatabaseDomain.DTO.Security;
using DatabaseDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDomain.Interface
{
    public interface IUserDomain : IGeneric<UserDomain>
    {
        Task<IEnumerable<UserInfoDTO>> GetAllUsersDTOAsync();
    }
}
