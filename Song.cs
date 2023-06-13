using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelodyAutoclicker.Interfaces;

namespace MelodyAutoclicker
{
    public class Song : ISongInterface
    {
        private int noteIndex = -1;

        public string Name { get; set; }
        public Note[] Notes { get; set; }
        public int Length { get; set; }

        public Playspace Playspace { get; set; }

        public Song(ISongInterface song)
        {
            Name = song.Name;
            Notes = song.Notes;
            Length = song.Length;
            Playspace = new Playspace(0, 0, 0, 0);
        }

        public Song(ISongInterface song, Playspace playspace)
        {
            Name = song.Name;
            Notes = song.Notes;
            Length = song.Length;
            Playspace = playspace;
        }

        public (int x, int y) CalculateNotePosition(Note note)
        {
            int x = Playspace.NoteCenterX + Playspace.PerNoteX * (int)note.Number;
            int y = Playspace.NoteCenterY;
            return (x, y);
        }

        public NoteDuration StartPlaying()
        {
            noteIndex = 0;
            var (x, y) = CalculateNotePosition(Notes[noteIndex]);
            Debug.WriteLine($"[{noteIndex}]: Playing: {Notes[noteIndex].Number}, at: {x};{y}");
            MouseOperations.SetCursorPosition(x, y); 
            Thread.Sleep(1);
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleDown);
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleUp);
            return Notes[noteIndex].Duration;
        }

        public NoteDuration? PlayNextNote()
        {
            if (noteIndex == -1)
            {
                StartPlaying();
                return null;
            }
            if (noteIndex >= Notes.Length)
            {
                StopPlaying();
                return null;
            }

            if (++noteIndex >= Notes.Length)
            {
                StopPlaying();
                return null;
            }
            var (x, y) = CalculateNotePosition(Notes[noteIndex]);
            Debug.WriteLine($"[{noteIndex}]: Playing: {Notes[noteIndex].Number}, at: {x};{y}");
            MouseOperations.SetCursorPosition(x, y);
            Thread.Sleep(1);
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleDown);
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleUp);
            return Notes[noteIndex].Duration;
        }

        public void StopPlaying()
        {
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleUp);
            noteIndex = -1;
        }
    }
}
