using System.Threading.Tasks;
using Sheenam.Api.Broker.StorageBroker;
using Sheenam.Api.Models.Foundations.Guests;

namespace Sheenam.Api.Services.Foundations.Guests
{
    public class GuestService : IGuestService
    {
        private readonly IStorageBroker storageBroker;

        public GuestService(IStorageBroker storageBroker)=>
            this.storageBroker = storageBroker;

        public ValueTask<Guest> AddGuestAsync(Guest guest)=>
            this.storageBroker.InsertGuestAsync(guest);
    }
}
