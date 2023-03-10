// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by me :)
// --------------------------------------------------------

using System.Threading.Tasks;
using Sheenam.Api.Broker.LoggingBroker;
using Sheenam.Api.Broker.StorageBroker;
using Sheenam.Api.Models.Foundations.Guests;

namespace Sheenam.Api.Services.Foundations.Guests
{
    public partial class GuestService : IGuestService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public GuestService(
            IStorageBroker storageBroker, 
            ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
        }


        //Exception handling -> Exception Noise cansilation
        public ValueTask<Guest> AddGuestAsync(Guest guest) =>
            TryCatch(async () =>
            {
                ValidateGuestNotNull(guest);

                return await this.storageBroker.InsertGuestAsync(guest);
            });
    }
}
