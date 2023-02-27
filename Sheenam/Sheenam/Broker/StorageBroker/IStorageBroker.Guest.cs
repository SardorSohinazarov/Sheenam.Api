using System.Threading.Tasks;
using Sheenam.Api.Models.Foundations.Guests;

namespace Sheenam.Api.Broker.StorageBroker
{
    public partial interface IStorageBroker
    {
        ValueTask<Guest> InsertGuestAsync(Guest guest);
    }
}
