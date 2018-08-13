using System;
using System.Collections.Generic;
using System.Linq;
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
      public IActionResult Get()
      {
        RoomDetailsResultViewModel vm;
        if (HttpContext != null && HttpContext.Session.GetObject<RoomDetailsResultViewModel>("RoomDetails") != null)
        {
          vm = HttpContext.Session.GetObject<RoomDetailsResultViewModel>("RoomDetails");
        }
        else
        {
          vm = _roomDetailsService.GetRoomDetails(new RoomViewModel() { Length = 5.678M, Width = 3.846M, Height = 2.552M });
        }
        return Ok(vm);
    }

    // POST api/room
    [HttpPost]
    //public ActionResult<RoomDetailsResultViewModel> Post([FromBody] RoomViewModel model)
    public IActionResult Post([FromBody] RoomViewModel model)
    {
      RoomDetailsResultViewModel vm = _roomDetailsService.GetRoomDetails(new RoomViewModel() { Length = model.Length, Width = model.Width, Height = model.Height });
      if (HttpContext != null)
      {
        HttpContext.Session.SetObject("RoomDetails", vm);
      }
      return Ok(vm);
      //return _roomDetailsService.GetRoomDetails(new RoomViewModel() { Length = model.Length, Width = model.Width, Height = model.Height });
    }
    }
}
