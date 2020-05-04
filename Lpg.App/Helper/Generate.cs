using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lpg.App.Helper
{
    public class Generate
    {
        public static string GenerateRandomNo()
        {
            Random _random = new Random();
            return _random.Next(0, 9999).ToString("D4");
        }
    }
}
