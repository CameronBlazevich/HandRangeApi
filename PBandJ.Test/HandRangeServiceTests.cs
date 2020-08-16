using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PBandJ.Api.Entities;
using PBandJ.Api.Models;
using PBandJ.Api.Repositories;
using PBandJ.Api.Services.HandRanges;

namespace PBandJ.Test
{
    [TestClass]
    public class HandRangeServiceTests
    {
        private Mock<IHandRangeRepository> _repoMock;
        private Mock<IHandRangeValidationService> _validationServiceMock;

        [TestInitialize]
        public void Init()
        {            
            _repoMock = new Mock<IHandRangeRepository>();
            _validationServiceMock = new Mock<IHandRangeValidationService>();
        }

        [TestCleanup]
        public void TearDown()
        {
            _repoMock = null;
            _validationServiceMock = null;
        }

        [TestMethod]
        public void GetHandRange_Successful()
        {
            var hands = new[] { new HandAction("AKo", 100,0,0), new HandAction("AKs",0,null,null)};
            var expected = new HandRangeDto
            {
                Hands= hands,
                UserId = "1"
            };

            var handRangeEntityMock = new HandRange
            {
                UserId = "1",
                HandsArray = hands,
            };

            _repoMock.Setup(repo => repo.GetHandRange(It.IsAny<string>(), It.IsAny<int>())).Returns(handRangeEntityMock);

            var service = new HandRangeService(_repoMock.Object, _validationServiceMock.Object);

            var result = service.GetHandRange("1", 1);
            result.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void CreateOrUpdateHandRange_CreatePathCallsAddHandRangeWithCorrectEntity()
        {
            var hands = new[] { new HandAction("AAo", 100, null, null),new HandAction("AJs", 100, null, null) };
            var handRangeDto = new HandRangeDto
            {
                Hands = hands,
                UserId = "2",
            };

            var handRangeEntity = new HandRange
            {
                UserId = "2",
                HandsArray = hands,
            };

            var handRangeAtRunTime = new HandRange();
            _validationServiceMock.Setup(vs => vs.VerifyHandRangeContainsOnlyValidHands(It.IsAny<HandAction[]>())).Verifiable();
            _repoMock.Setup(repo => repo.GetHandRange(It.IsAny<string>(), It.IsAny<int>())).Returns((HandRange)null);
            _repoMock.Setup(repo => repo.AddHandRange(It.IsAny<HandRange>()))
                .Callback<HandRange>(hr => handRangeAtRunTime = hr)
                .Returns(handRangeEntity);

            _repoMock.Setup(repo => repo.UpdateHandRange(It.IsAny<HandRange>())).Verifiable();

            var service = new HandRangeService(_repoMock.Object, _validationServiceMock.Object);

            var actual = service.CreateOrUpdateHandRange(handRangeDto);

            handRangeAtRunTime.Should().BeEquivalentTo(handRangeEntity);
            //actual.ShouldBeEquivalentTo(handRangeDto);
            _validationServiceMock.Verify(m => m.VerifyHandRangeContainsOnlyValidHands(It.IsAny<HandAction[]>()), Times.Once);
            _repoMock.Verify(m => m.UpdateHandRange(It.IsAny<HandRange>()), Times.Never);
            _repoMock.Verify(m => m.AddHandRange(It.IsAny<HandRange>()), Times.Once);
        }

        [TestMethod]
        public void CreateOrUpdateHandRange_UpdatePathCallsAddHandRangeWithCorrectEntity()
        {
            var hands = new[] { new HandAction("AAo",100,0,0), new HandAction("AJs", 100,0,0) };
            var handRangeDto = new HandRangeDto
            {
                Hands = hands,
            };

            var handRangeEntity = new HandRange
            {
                UserId = "2",
                HandsArray = hands,
            };

            var handRangeMock = new HandRange
            {
                UserId = handRangeEntity.UserId,
                HandsArray = new [] {new HandAction("Q6s", 100,0,0)}
            };

            var handRangeAtRunTime = new HandRange();
            _validationServiceMock.Setup(vs => vs.VerifyHandRangeContainsOnlyValidHands(It.IsAny<HandAction[]>())).Verifiable();
            _repoMock.Setup(repo => repo.GetHandRange(It.IsAny<string>(), It.IsAny<int>())).Returns(handRangeMock);
            _repoMock.Setup(repo => repo.UpdateHandRange(It.IsAny<HandRange>()))
                .Callback<HandRange>(hr => handRangeAtRunTime = hr)
                .Returns(handRangeEntity);
 
            _repoMock.Setup(repo => repo.AddHandRange(It.IsAny<HandRange>())).Verifiable();

            var service = new HandRangeService(_repoMock.Object, _validationServiceMock.Object);

            var actual = service.CreateOrUpdateHandRange(handRangeDto);

            handRangeAtRunTime.Should().BeEquivalentTo(handRangeEntity);
            //actual.ShouldBeEquivalentTo(handRangeDto);
            _validationServiceMock.Verify(m => m.VerifyHandRangeContainsOnlyValidHands(It.IsAny<HandAction[]>()), Times.Once);
            _repoMock.Verify(m => m.UpdateHandRange(It.IsAny<HandRange>()), Times.Once);
            _repoMock.Verify(m => m.AddHandRange(It.IsAny<HandRange>()), Times.Never);
        }
    }
}
