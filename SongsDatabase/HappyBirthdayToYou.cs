﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelodyAutoclicker.Interfaces;

namespace MelodyAutoclicker.SongsDatabase
{
    public class HappyBirthdayToYou : ISongInterface
    {
        public string Name { get; set; }
        public Note[] Notes { get; set; }
        public int Length { get; set; }

        public HappyBirthdayToYou()
        {
            Name = "Happy Birthday to You";
            Notes = new Note[] {
                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Eighth)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Half)),
                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Half)),
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Whole)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Half)),

                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Eighth)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Half)),
                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Half)),
                new Note(Note.NoteNumber.F, new NoteDuration(NoteDuration.Whole)),
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Half)),

                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Half)),
                new Note(Note.NoteNumber.A, new NoteDuration(NoteDuration.Half)),
                new Note(Note.NoteNumber.G, new NoteDuration(NoteDuration.Half)),
                new Note(Note.NoteNumber.F, new NoteDuration(NoteDuration.Half)),
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Half)),

                new Note(Note.NoteNumber.G, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.G, new NoteDuration(NoteDuration.Eighth)),
                new Note(Note.NoteNumber.F, new NoteDuration(NoteDuration.Half)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Half)),
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Half)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Half))
                    };
            Length = 14;
        }
    }
}
