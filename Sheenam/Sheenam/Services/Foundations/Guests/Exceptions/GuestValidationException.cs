// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by me :)
// --------------------------------------------------------

using Xeptions;

namespace Sheenam.Api.Services.Foundations.Guests.Exceptions
{
    public class GuestValidationException :Xeption
    {
        public GuestValidationException(Xeption innerException)
            :base(message:"Guest validation error occured , fix the error and try again",
                 innerException:innerException)
        {}
    }
}
