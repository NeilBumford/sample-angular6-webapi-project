using AngrierSix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngrierSix.Services
{
    public class RoomDetailsService: IRoomDetailsService
    {
    public RoomDetailsResultViewModel GetRoomDetails(RoomViewModel model)
    {
      //Length = 5.678, Width = 3.846, Height = 2.552

      return new RoomDetailsResultViewModel()
      {
        FloorArea = model.Length * model.Width,
        Volume = model.Length * model.Width * model.Height,
        PaintRequired = (((model.Length * model.Height) + (model.Width * model.Height)) * 2) / Coverage.MattEmulsion
      };
    }
  }
}
