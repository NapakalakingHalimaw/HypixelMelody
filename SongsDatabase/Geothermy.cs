using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelodyAutoclicker.Interfaces;

namespace MelodyAutoclicker.SongsDatabase
{
    public class Geothermy : ISongInterface
    {
        public string Name { get; set; }
        public Note[] Notes { get; set; }
        public int Length { get; set; }

        public Geothermy()
        {
            Name = "Geothermy";
            Notes = new Note[]
            {

            };
            Length = 0;
        }
    }
}
