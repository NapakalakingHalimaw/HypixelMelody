using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyAutoclicker
{
    public class Note
    {
        public enum NoteNumber : int
        {
            None = -1,
            C = 0,
            D = 1,
            E = 2,
            F = 3,
            G = 4,
            A = 5,
            B = 6
        }

        public NoteNumber Number { get; set; }
        public NoteDuration Duration { get; set; }

        public Note()
        {
            Number = NoteNumber.None;
            Duration = new();
        }

        public Note(NoteNumber noteNumber, NoteDuration duration)
        {
            Number = noteNumber;
            Duration = duration;
        }
    }
}
