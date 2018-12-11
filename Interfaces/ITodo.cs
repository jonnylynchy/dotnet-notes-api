using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
/*
This is the note model for use in application.
*/
namespace dotnet_notes_api.Models
{
    public interface IToDo
    {
        void setStatus(Boolean status);
    }
}