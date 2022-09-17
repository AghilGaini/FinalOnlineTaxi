using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDomain.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IUserDomain _user { get; set; }

        void Complete();
    }
}
