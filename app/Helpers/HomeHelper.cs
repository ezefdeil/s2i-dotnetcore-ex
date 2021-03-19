using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace app.Helpers
{
  public  class HomeHelper
  {
    public static string GetRunningTime()
    {
      return (DateTime.UtcNow - Process.GetCurrentProcess().StartTime.ToUniversalTime()).ToString();

    }
  }
}
