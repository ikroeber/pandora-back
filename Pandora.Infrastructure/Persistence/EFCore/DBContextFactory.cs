using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Pandora.Infrastructure.Persistence.EFCore
{
    // This must exist for migrations to work
    internal class DBContextFactory : IDesignTimeDbContextFactory<PandoraContext>
    {
        public PandoraContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PandoraContext>();
            return new(builder.Options, null!);
        }
    }
}
