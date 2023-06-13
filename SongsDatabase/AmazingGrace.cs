using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelodyAutoclicker.Interfaces;

namespace MelodyAutoclicker.SongsDatabase
{
    public class AmazingGrace : ISongInterface
    {
        public string Name { get; set; }
        public Note[] Notes { get; set; }
        public int Length { get; set; }

        public AmazingGrace()
        {
            Name = "Amazing Grace";
            Notes = new Note[]
            {

            };
            Length = 0;
        }
    }
}
