﻿// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by me :)
// --------------------------------------------------------

using Xeptions;

namespace Sheenam.Api.Services.Foundations.Guests.Exceptions
{
    public class GuestValidationException :Xeption
    {
        public GuestValidationException(Xeption innerException)
            :base(message: "Guest is invalid. Please fix the errors and try again.",
                 innerException:innerException)
        {}
    }
}
