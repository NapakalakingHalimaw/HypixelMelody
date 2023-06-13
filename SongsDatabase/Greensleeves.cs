﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelodyAutoclicker.Interfaces;

namespace MelodyAutoclicker.SongsDatabase
{
    public class Greensleeves : ISongInterface
    {
        public string Name { get; set; }
        public Note[] Notes { get; set; }
        public int Length { get; set; }

        public Greensleeves()
        {
            Name = "Greensleeves";
            Notes = new Note[]
            {
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.F, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.G, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.G, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.F, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Half)),
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.F, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.G, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.G, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.F, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Half)),
                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.F, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.C, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.D, new NoteDuration(NoteDuration.Quarter)),
                new Note(Note.NoteNumber.E, new NoteDuration(NoteDuration.Half))
            };
            Length = 36; // 37
        }
    }
}