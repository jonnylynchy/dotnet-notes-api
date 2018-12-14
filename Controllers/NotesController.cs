using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using LiteDB;
// Use note model here
using dotnet_notes_api.Models;
using Microsoft.AspNetCore.Cors;

/*
    Notes Controller
    ========================
    This is the main controller for the notes app api. 
    This will handle get and post http requests from the client application.
*/
namespace dotnet_notes_api.Controllers
{
    // The whole application serves an api at /api/notes/
    [Route("api/[controller]")]
    // This enables cross-domain origin requests so I can test with a different url/domain
    [EnableCors("AllowAllOrigins")]
    // Marks this as an API controller
    [ApiController]
    public class NotesController : ControllerBase
    {
        // This sets up our initial connection string to the LiteDB database
        ConnectionString connectionString = new ConnectionString("NotesDB.db")
        {
            Mode = LiteDB.FileMode.Exclusive
        };

        // GET api/notes
        // This route gets all notes and returns them as JSON
        [HttpGet]
        public ActionResult<IEnumerable<Note>> Get()
        {
            // Connect to database
            using(var db = new LiteDatabase(connectionString))  
            {
                // Get all notes
                var notes = db.GetCollection<Note>("notes");
                // Order notes by created data
                var allNotes = notes.FindAll().OrderBy(note => note.CreatedAt).ToList();

                // return all notes
                return allNotes;
            }
        }

        // GET api/notes/5
        // finds and returns a particular note
        [HttpGet("{id}")]
        public ActionResult<Note> Get(Guid id)
        {
            // connect to database
            using(var db = new LiteDatabase(connectionString))  
            {
                // get notes collection
                var notes = db.GetCollection<Note>("notes");
                // find and return a particular note by id
                return notes.FindById(id);
            }
        }

        // POST api/notes
        [HttpPost]
        public ActionResult<Note> Post([FromBody] Note note)
        {
            Console.WriteLine("Note from body: {0}", note);
            // Initialize new note object
            Note newNote;

            // Initialize new action result to return to user
            ActionResult result;

            // Implement try/catch/finally here
            try {
                // attempt to set the new note with note text from body of post
                newNote = new Note(note.NoteText);

                // using our new db
                using(var db = new LiteDatabase(connectionString))  
                {
                    // get notes collection
                    var notes = db.GetCollection<Note>("notes");

                    // insert new note into collection
                    notes.Insert(newNote);
                }

                // return 200 ok along with new note
                result = Ok(newNote);

            } catch (Exception e) {
                // Something went wrong here
                Console.WriteLine("Exception: {0}", e);
                // return error
                result = BadRequest();
            } finally {
                // Just log out that request was good and insert was successful
                Console.WriteLine("Good request. Insert was successful.");
            }

            // Return Result to user
            return result;
        }

        // PUT api/notes/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Note note)
        {
            Console.WriteLine("PUT/update received: {0} {1}", id, note);
            // using our new db
            using(var db = new LiteDatabase(connectionString))  
            {
                // get notes collection
                var notes = db.GetCollection<Note>("notes");

                // find the note to update.
                var noteToUpdate = notes.FindById(id);
                noteToUpdate.NoteText = note.NoteText;
                // get the note that was passed
                notes.Update(noteToUpdate);
            }
        }

        // DELETE api/notes/5
        // this route finds and deletes a note that was passed by id
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            using(var db = new LiteDatabase(connectionString))  
            {
                // get notes collection
                var notesDb = db.GetCollection<Note>("notes");
                // delete note
                notesDb.Delete(id);
            }
        }
    }
}
