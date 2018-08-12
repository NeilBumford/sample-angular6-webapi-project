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
         if(HttpContext.Session.GetObject<RoomDetailsResultViewModel>("RoomDetails") != null)
        {
          return HttpContext.Session.GetObject<RoomDetailsResultViewModel>("RoomDetails");
        }
        else return _roomDetailsService.GetRoomDetails(new RoomViewModel() { Length = 5.678M, Width = 3.846M, Height = 2.552M});
      }

      // POST api/room
      [HttpPost]
      //public ActionResult<RoomDetailsResultViewModel> Post([FromBody] RoomViewModel model)
      public void Post([FromBody] RoomViewModel model)
      {
        RoomDetailsResultViewModel vm = _roomDetailsService.GetRoomDetails(new RoomViewModel() { Length = model.Length, Width = model.Width, Height = model.Height });
        HttpContext.Session.SetObject("RoomDetails", vm);
        //return _roomDetailsService.GetRoomDetails(new RoomViewModel() { Length = model.Length, Width = model.Width, Height = model.Height });
      }
    }
}
