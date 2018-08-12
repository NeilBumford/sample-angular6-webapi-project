using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngrierSix.Models
{
  public static class Paint
  {
    public static readonly IDictionary<string, decimal> Coverage;
    static Paint()
    {
      Coverage = new Dictionary<string, decimal>()
      {
        { "MattEmulsion", 13},
        { "Gloss", 8}
      };
    }
  }
}
