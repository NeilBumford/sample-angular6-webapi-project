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
      return new RoomDetailsResultViewModel()
      {
        FloorArea = 15.65333333M,
        Volume = 56.546333333M,
        PaintRequired = 9.768542M
      };
    }
  }
}
