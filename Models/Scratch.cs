using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using LiteDB;
/*
This is the note model for use in application.
*/
namespace dotnet_notes_api.Models
{
    public abstract class Scratch
    {
        private Guid _noteID;
        private string _noteText;
        private DateTime _createdAt;

        [BsonId]
        public Guid NoteID { get => _noteID; set => _noteID = value; }
        public string NoteText { get => _noteText; set => _noteText = value; }
        public DateTime CreatedAt { get => _createdAt; set => _createdAt = value; }
    }
}