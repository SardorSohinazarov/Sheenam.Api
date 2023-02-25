using Microsoft.EntityFrameworkCore;
using Sheenam.Api.Models.Foundations.Guests;

namespace Sheenam.Api.Broker.StorageBroker
{
    public partial class StorageBroker
    {
        public DbSet<Guest> Guests { get; set; }
    }
}
