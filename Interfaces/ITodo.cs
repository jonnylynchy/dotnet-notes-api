using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
/*
This is the interface for ToDos
*/
namespace dotnet_notes_api.Models
{
    public interface IToDo
    {
        // ToDo must implement a setStatus() method
        void setStatus(Boolean status);
    }
}