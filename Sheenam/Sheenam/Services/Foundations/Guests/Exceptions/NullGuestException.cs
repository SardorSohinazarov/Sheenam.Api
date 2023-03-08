// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by me :)
// --------------------------------------------------------

using Xeptions;

namespace Sheenam.Api.Services.Foundations.Guests.Exceptions
{
    public class NullGuestException:Xeption
    {
        public NullGuestException()
            :base(message:"Guest is null")
        {}
    }
}
