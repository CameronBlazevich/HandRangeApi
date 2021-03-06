﻿using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PBandJ.Api.Services;
using PBandJ.Api.Services.Exceptions;

namespace PBandJ.Test
{
    [TestClass]
    public class HandRangeValidationServiceTests
    {
        private readonly IHandRangeValidationService _handRangeValidationService;
        public HandRangeValidationServiceTests()
        {
            _handRangeValidationService = new HandRangeValidationService();
        }
        [TestMethod]
        public void VerifyHandRangeContainsOnlyValidHands_Successful()
        {
            var validHands = new[] {"AAo", "KQs"};
            Action act = () => _handRangeValidationService.VerifyHandRangeContainsOnlyValidHands(validHands);
            act.ShouldNotThrow();
        }

        [TestMethod]
        public void VerifyHandRangeContainsOnlyValidHands_WithInvalidHands_ShouldThrow()
        {
            var validHands = new[] { "AAo", "KQ", "Invalid" };
            Action act = () => _handRangeValidationService.VerifyHandRangeContainsOnlyValidHands(validHands);
            act.ShouldThrow<HandRangeServiceException>()
                .WithMessage("Invalid hands: KQ,Invalid");
        }
    }
}
