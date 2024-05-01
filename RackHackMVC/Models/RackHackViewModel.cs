using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;

namespace RackHackMVC.Models
{
    public class RackHackViewModel
    {
        public List<int> PoolBalls { get; set; } =
            new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });



        public bool EightBallRackHackClick { get; set; }

        public bool EightBallRackHackDifferentWingsClick { get; set; }

        public bool NineBallRackHackClick { get; set; }

        public bool NineBallRackHack2AtBackClick { get; set; }

        public bool NineBallRackHack2ProhibitedFromBackClick { get; set; }

        public bool TenBallRackHackClick { get; set; }

        public bool TenBallRackHack2And3OnWingsClick { get; set; }
    }
}
