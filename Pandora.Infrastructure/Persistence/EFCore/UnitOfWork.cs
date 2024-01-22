using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pandora.Domain;
using Pandora.Infrastructure.Persistence.EFCore.Repositories;

namespace Pandora.Infrastructure.Persistence.EFCore
{
    public class UnitOfWork(PandoraContext context, IUserRepository userRepository) : IUnitOfWork
    {
        private readonly PandoraContext _context = context;

        public void Commit()
        {
            _context.SaveChanges();
        }

        public IRepository UserRepository { get; } = userRepository;
    }
}
