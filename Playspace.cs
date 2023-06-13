using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyAutoclicker
{
    public class Playspace
    {
        public int Width { get { return X2 - X1; } }
        public int Height { get { return Y2 - Y1; } }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public int PerNoteX { get { return Width / 7; } }
        public int PerNoteY { get { return Height; } }
        public int NoteCenterX { get { return X1 + PerNoteX / 2; } }
        public int NoteCenterY { get { return Y1 + PerNoteY / 2; } }

        public Playspace(int x1, int y1, int x2, int y2)
        {
            X1 = x1; Y1 = y1; X2 = x2; Y2 = y2;
        }
    }
}
