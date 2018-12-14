using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
/*
This is the todo model for use in application.
This is a particular class for todo's vs a regular note.
A todo has an "isCompleted" boolean status
ToDo extends Scratch and implements IToDo
*/
namespace dotnet_notes_api.Models
{
    public class ToDo : Scratch, IToDo
    {
        // isCompleted status
        private Boolean isCompleted;

        // default empty constructor
        public ToDo() { }

        // constructor with paramter for text
        public ToDo(string text)
        {
            isCompleted = false;
            NoteID = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            NoteText = text;
        }

        // IsCompleted status property
        public bool IsCompleted { get => isCompleted; set => isCompleted = value; }

        // setStatus method
        public void setStatus(Boolean status) => this.isCompleted = status;
    }
}