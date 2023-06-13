using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyAutoclicker
{
    public class NoteDuration
    {
        public static readonly double None = 0;
        public static readonly double Whole = 3;
        public static readonly double Half = 1.55;
        public static readonly double Quarter = 1;
        public static readonly double Eighth = 0.55;
        public static readonly double Sixteenth = 0.2;

        public double Duration { get; set; }

        public NoteDuration()
        {
            Duration = None;
        }

        public NoteDuration(double duration)
        {
            Duration = duration;
        }
    }
}
