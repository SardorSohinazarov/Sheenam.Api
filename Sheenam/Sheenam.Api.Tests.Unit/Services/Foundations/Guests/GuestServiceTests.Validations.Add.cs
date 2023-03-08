﻿// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by me :)
// --------------------------------------------------------

using System.Linq.Expressions;
using Moq;
using Sheenam.Api.Models.Foundations.Guests;
using Sheenam.Api.Services.Foundations.Guests.Exceptions;

namespace Sheenam.Api.Tests.Unit.Services.Foundations.Guests;

public partial class GuestServiceTests
{
    [Fact]
    public async Task ShouldThrowValidationExceptionOnAddIfGuestIsNullAndLogItAsync()
    {
        //given
        Guest nullGuest = null;
        var nullGuestException = new NullGuestException();

        var expectedGuestValidationException =
            new GuestValidationException(nullGuestException);

        //when
        ValueTask<Guest> AddGuestTask =
            this.guestService.AddGuestAsync(nullGuest);

        //then
        await Assert.ThrowsAsync<GuestValidationException>(()=>
            AddGuestTask.AsTask());

        this.loggingBrokerMock.Verify(broker =>
            broker.LogError(It.Is(SameExceptionAs(expectedGuestValidationException))),
                Times.Once);

        this.storageBrokerMock.Verify(broker =>
            broker.InsertGuestAsync(It.IsAny<Guest>()), 
                Times.Never);

        this.loggingBrokerMock.VerifyNoOtherCalls();
        this.storageBrokerMock.VerifyNoOtherCalls();
    }
}
