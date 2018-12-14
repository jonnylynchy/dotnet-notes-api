using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
/*
This is the note model for use in application.
This class extends Scratch.
*/

namespace dotnet_notes_api.Models
{
    public class Note : Scratch
    {
        // empty default contstuctor
        public Note()
        {
        }

        // constructor with parameter for text
        public Note(string text)
        {
            NoteID = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            NoteText = text;
        }
    }
}