using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using LiteDB;
/*
This is the main scratch model for use in application.
It's an abstract class so other models can extend it and choose to override methods/properties if necessary.
*/
namespace dotnet_notes_api.Models
{
    public abstract class Scratch
    {
        // The unique note id
        private Guid _noteID;
        // The note text
        private string _noteText;
        // When this note was created
        private DateTime _createdAt;

        // Getters and setters for our fields
        [BsonId]
        public Guid NoteID { get => _noteID; set => _noteID = value; }
        public string NoteText { get => _noteText; set => _noteText = value; }
        public DateTime CreatedAt { get => _createdAt; set => _createdAt = value; }
    }
}