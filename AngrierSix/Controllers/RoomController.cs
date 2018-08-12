using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngrierSix.Models;
using AngrierSix.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngrierSix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {

      private readonly IRoomDetailsService _roomDetailsService;

      public RoomController(IRoomDetailsService roomDetailsService)
      {
        _roomDetailsService = roomDetailsService;
      }
      // GET api/room
      [HttpGet]
      public ActionResult<RoomDetailsResultViewModel> Get()
      {
        return _roomDetailsService.GetRoomDetails(new RoomViewModel() { Length = 5.678M, Width = 3.846M, Height = 2.552M});
      }

      // POST api/room
      [HttpPost]
      public ActionResult<RoomDetailsResultViewModel> Post([FromBody] RoomViewModel model)
      {
        return new RoomDetailsResultViewModel();
      }
  }
}
