using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionService.IntegrationTests;
[CollectionDefinition("Shared collection")]
public class SharedFixture : ICollectionFixture<CustomWebAppFactory>
{
}
