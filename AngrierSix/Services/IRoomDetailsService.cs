using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngrierSix.Models;

namespace AngrierSix.Services
{
    public interface IRoomDetailsService
    {
      RoomDetailsResultViewModel GetRoomDetails(RoomViewModel model);
    }
}
