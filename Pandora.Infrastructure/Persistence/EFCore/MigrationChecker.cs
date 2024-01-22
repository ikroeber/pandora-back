using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace Pandora.Infrastructure.Persistence.EFCore
{
    public class MigrationChecker(PandoraContext context)
    {
        private readonly PandoraContext _context = context;

        public void CheckAndApplyMigrations()
        {
            if (_context.Database.GetPendingMigrations().IsNullOrEmpty())
            {
                return;
            }

            _context.Database.Migrate();
        }
    }
}
