using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PBandJ.Api.Entities;
using PBandJ.Api.Services;
using PBandJ.Api.Services.Exceptions;
using PBandJ.Api.Services.HandRanges;

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
            var validHands = new[] {new HandAction("AAo", 95, 5, 0), new HandAction("KQs", 80, 20, 0)};
            Action act = () => _handRangeValidationService.VerifyHandRangeContainsOnlyValidHands(validHands);
            act.Should().NotThrow();
        }

        [TestMethod]
        public void VerifyHandRangeContainsOnlyValidHands_WithInvalidHands_ShouldThrow()
        {
            var validHands = new[]
            {
                new HandAction("AAo", 100, 0, 0),
                new HandAction("KQ", 95, 5, 0),
                new HandAction("Invalid", 0, 100, 0)
            };
            Action act = () => _handRangeValidationService.VerifyHandRangeContainsOnlyValidHands(validHands);
            act.Should().Throw<HandRangeServiceException>()
                .WithMessage("Invalid hands: KQ,Invalid");
        }
        
        [TestMethod]
        public void VerifyHandRangeContainsOnlyValidHands_WithInvalidFrequencies_ShouldThrow()
        {
            var validHands = new[]
            {
                new HandAction("AAo", 100, 0, 10),
                new HandAction("KQo", 95, 5, 5),

            };
            Action act = () => _handRangeValidationService.VerifyHandRangeContainsOnlyValidHands(validHands);
            act.Should().Throw<HandRangeServiceException>()
                .WithMessage("Invalid frequencies for hands: AAo,KQo");
        }
    }
}
