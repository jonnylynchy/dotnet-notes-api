using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
/*
This is the note model for use in application.
*/
namespace dotnet_notes_api.Models
{
    public class ToDo : Scratch, IToDo
    {
        private Boolean isCompleted;

        public ToDo() { }

        public ToDo(string text)
        {
            isCompleted = false;
            NoteID = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            NoteText = text;
        }

        public bool IsCompleted { get => isCompleted; set => isCompleted = value; }

        public void setStatus(Boolean status) => this.isCompleted = status;
    }
}