using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IdentityServer.Core.Models;

namespace ExpenseTracker.IdSrv.Config
{
    public class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
            {
                new Client
                {
                     Enabled = true,
                     ClientId = "mvc",
                     ClientName = "ExpenseTracker MVC Client (Hybrid Flow)",
                     Flow = Flows.Hybrid,
                     RequireConsent = true,

                     RedirectUris = new List<string>
                     {ExpenseTrackerConstants.ExpenseTrackerClient }

                }
            };

        }
    }
}
