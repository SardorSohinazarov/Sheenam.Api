// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by me :)
// --------------------------------------------------------

using Xeptions;

namespace Sheenam.Api.Services.Foundations.Guests.Exceptions
{
    public class InvalidGuestException:Xeption
    {
        public InvalidGuestException():base(message:"Guest is invalid.")
        {
            
        }
    }
}
