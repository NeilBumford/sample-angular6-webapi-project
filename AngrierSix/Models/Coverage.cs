using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngrierSix.Models
{
  public static class Coverage
  {
    public static readonly decimal MattEmulsion;
    public static readonly decimal Gloss;
    static Coverage()
    {
      MattEmulsion = 13.3M;
      Gloss = 8.7M;
    }
  }
}
