// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by me :)
// --------------------------------------------------------

using System.Threading.Tasks;
using Sheenam.Api.Models.Foundations.Guests;
using Sheenam.Api.Services.Foundations.Guests.Exceptions;
using Xeptions;

namespace Sheenam.Api.Services.Foundations.Guests
{
    public partial class GuestService
    {
        private delegate ValueTask<Guest> ReturningGuestFunction();

        private async ValueTask<Guest> TryCatch(ReturningGuestFunction guestFunction)
        {
            try
            {
                return await guestFunction();
            }
            catch (NullGuestException nullGuestException)
            {
                throw CreateAndLogValidationException(nullGuestException);
            }
        }

        private GuestValidationException CreateAndLogValidationException(Xeption xeption)
        {
            var guestValidationException = new GuestValidationException(xeption);

            this.loggingBroker.LogError(guestValidationException);

            return guestValidationException;
        }
    }
}
