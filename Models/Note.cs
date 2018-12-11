using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
/*
This is the note model for use in application.
*/
namespace dotnet_notes_api.Models
{
    public class Note : Scratch
    {
        public Note()
        {
        }

        public Note(string text)
        {
            NoteID = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            NoteText = text;
        }
    }
}