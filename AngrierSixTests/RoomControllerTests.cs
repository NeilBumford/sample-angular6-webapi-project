using AngrierSix;
using AngrierSix.Controllers;
using AngrierSix.Models;
using AngrierSix.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Moq;
//using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace AngrierSixTests
{
    public class RoomControllerTests
    {
        Mock<IRoomDetailsService> mockRoomDetailsService = new Mock<IRoomDetailsService>();

        public RoomControllerTests()
        {
            //_server = new TestServer(new WebHostBuilder()
                //.UseContentRoot(@"D:\Users\neilb\Documents\GitHub\MST.Golf.Scoring\MST.Golf.Scoring")
             //   .UseStartup<Startup>());
            //_client = _server.CreateClient();
        }

        [Fact]
        public void RoomController_Get_Returns_RoomDetailsResultViewModel()
        {
            // mockRoomDetailsService.Setup(s => s.GetRoomDetails(new RoomViewModel() { Length = 4M, Width = 3M, Height = 2M })).Returns(new RoomDetailsResultViewModel());
            //RoomController roomController = new RoomController(mockRoomDetailsService.Object);
            RoomController roomController = new RoomController(new RoomDetailsService());
            var result = roomController.Get();

            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var roomDetailsResultViewModel = okResult.Value.Should().BeAssignableTo<RoomDetailsResultViewModel>().Subject;
            Assert.IsType<RoomDetailsResultViewModel>(roomDetailsResultViewModel);
        }

        [Fact]
        public void RoomController_Post_Returns_RoomDetailsResultViewModel()
        {
            RoomController roomController = new RoomController(new RoomDetailsService());
            var result = roomController.Post(new RoomViewModel() { Length = 4M, Width = 3M, Height = 2M });

            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var roomDetailsResultViewModel = okResult.Value.Should().BeAssignableTo<RoomDetailsResultViewModel>().Subject;
            Assert.IsType<RoomDetailsResultViewModel>(roomDetailsResultViewModel);
            Assert.Equal("12.00", roomDetailsResultViewModel.FloorArea);
            Assert.Equal("24.00", roomDetailsResultViewModel.Volume);
            Assert.Equal("2.11", roomDetailsResultViewModel.PaintRequired);

        }
    }
}
