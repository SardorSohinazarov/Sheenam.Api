﻿// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by me :)
// --------------------------------------------------------

using Moq;
using Sheenam.Api.Broker.StorageBroker;
using Sheenam.Api.Models.Foundations.Guests;
using Sheenam.Api.Services.Foundations.Guests;
using Tynamix.ObjectFiller;

namespace Sheenam.Api.Tests.Unit.Services.Foundations.Guests
{
    public partial class GuestServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly IGuestService guestService;

        public GuestServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();

            this.guestService =
                new GuestService(storageBroker: this.storageBrokerMock.Object);
        }

        private DateTimeOffset GetRandomDateTimeOfSet()
        {
            return new DateTimeRange(earliestDate: DateTime.UnixEpoch).GetValue();
        }

        private Guest CreateRandomGuest()=>
            CreateGuestFiller(dates:GetRandomDateTimeOfSet()).Create();

        private Filler<Guest> CreateGuestFiller(DateTimeOffset dates)
        {
            var filler = new Filler<Guest>();

            filler.Setup().OnType<DateTimeOffset>().Use(dates);

            return filler;
        }
    }
}
