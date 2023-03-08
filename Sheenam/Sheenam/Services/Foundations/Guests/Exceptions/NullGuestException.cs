// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by me :)
// --------------------------------------------------------

using Xeptions;

namespace Sheenam.Api.Services.Foundations.Guests.Exceptions
{
    public class GuestNullException:Xeption
    {
        public GuestNullException()
            :base(message:"Guest is null")
        {}
    }
}
