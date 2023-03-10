// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by me :)
// --------------------------------------------------------

using System.Linq.Expressions;
using Moq;
using Sheenam.Api.Broker.LoggingBroker;
using Sheenam.Api.Broker.StorageBroker;
using Sheenam.Api.Models.Foundations.Guests;
using Sheenam.Api.Services.Foundations.Guests;
using Tynamix.ObjectFiller;
using Xeptions;

namespace Sheenam.Api.Tests.Unit.Services.Foundations.Guests
{
    public partial class GuestServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly Mock<ILoggingBroker> loggingBrokerMock;
        private readonly IGuestService guestService;

        public GuestServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.loggingBrokerMock = new Mock<ILoggingBroker>();

            this.guestService =
                new GuestService(storageBroker: this.storageBrokerMock.Object,
                                 loggingBroker: this.loggingBrokerMock.Object);
        }

        private DateTimeOffset GetRandomDateTimeOfSet()
        {
            return new DateTimeRange(earliestDate: DateTime.UnixEpoch).GetValue();
        }

        private Guest CreateRandomGuest()=>
            CreateGuestFiller(dates:GetRandomDateTimeOfSet()).Create();

        private Expression<Func<Xeption, bool>> SameExceptionAs(Xeption expectedGuestValidationException)
        {
            return actualException =>
                actualException.Message == expectedGuestValidationException.Message
                && actualException.InnerException.Message == expectedGuestValidationException.InnerException.Message
                && (actualException.InnerException as Xeption).DataEquals(expectedGuestValidationException.InnerException.Data);
        }

        private Filler<Guest> CreateGuestFiller(DateTimeOffset dates)
        {
            var filler = new Filler<Guest>();

            filler.Setup().OnType<DateTimeOffset>().Use(dates);

            return filler;
        }
    }
}
