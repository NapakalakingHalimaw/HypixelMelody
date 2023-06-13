using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyAutoclicker.Interfaces
{
    public interface ISongInterface
    {
        string Name { get; set; }
        Note[] Notes { get; set; }
        int Length { get; set; }
    }
}
