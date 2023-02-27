using System.Threading.Tasks;
using Sheenam.Api.Broker.StorageBroker;
using Sheenam.Api.Models.Foundations.Guests;

namespace Sheenam.Api.Services.Foundations.Guests
{
    public class GuestService : IGuestService
    {
        private readonly IStorageBroker _storageBroker;

        public GuestService(IStorageBroker storageBroker)=>
            _storageBroker = storageBroker;

        public ValueTask<Guest> AddGuestAsync(Guest guest)=>
            throw new System.NotImplementedException();
    }
}
