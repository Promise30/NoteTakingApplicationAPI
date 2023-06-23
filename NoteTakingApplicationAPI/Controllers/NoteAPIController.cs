using Microsoft.AspNetCore.Mvc;
using NoteTakingApplicationAPI.Data;
using NoteTakingApplicationAPI.Models;
using NoteTakingApplicationAPI.Models.DTO;
using static System.Reflection.Metadata.BlobBuilder;

namespace NoteTakingApplicationAPI.Controllers
{
    [Route("api/NoteAPI")]
    [ApiController]
    public class NoteAPIController : ControllerBase
    {
        // Return List of notes
        [HttpGet("notes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<NoteDTO>> GetNotes()
        {
            return Ok(Notes.notesList);
        }

        // Return a single Note
        [HttpGet("notes/{id:int}", Name = "GetNote")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<NoteDTO> GetNote(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var note = Notes.notesList.FirstOrDefault(a => a.Id == id);
            if (note == null)
            {
                return NotFound();
            }

            return Ok(note);
        }
        
        // Create a New Note
        [HttpPost("notes")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<NoteDTO> CreateNote([FromBody] NoteDTO note)
        {
            if (Notes.notesList.FirstOrDefault(u => u.Title.ToLower() == note.Title.ToLower()) != null)
            {
                // custom error message
                ModelState.AddModelError("", "Note Title already exists.");
                return BadRequest(ModelState);
            }
            if (note == null)
            {
                return BadRequest(note);
            }
            if (note.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            note.Id = Notes.notesList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            Notes.notesList.Add(note);

            return CreatedAtRoute("GetNote", new { id = note.Id }, note);
        }
        [HttpDelete("notes/{id:int}", Name = "DeleteNote")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        // Delete a Note
        public IActionResult DeleteNote(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var note = Notes.notesList.FirstOrDefault(u => u.Id == id);
            if (note == null)
            {
                return NotFound();
            }
            Notes.notesList.Remove(note);
            return NoContent();
        }

        // Update a Note
        [HttpPut("notes/{id:int}", Name = "UpdateNote")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateNote(int id, [FromBody] NoteDTO noteDTO)
        {
            if (noteDTO == null || id != noteDTO.Id)
            {
                return BadRequest();
            }
            var note = Notes.notesList.FirstOrDefault(u => u.Id == id);
            note.Title = noteDTO.Title;
            note.Content = noteDTO.Content;

            return NoContent();
        }

        // Search for Note(s) by Title
        [HttpGet("search/title/{noteTitle}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult SearchByTitle(string noteTitle)
        {
            var matchedNotesTitle = Notes.notesList.FindAll(a => a.Title.ToLower().Contains(noteTitle.ToLower()));
            if (matchedNotesTitle.Count == 0)
            {
                return NotFound();
            }
            return Ok(matchedNotesTitle);
        }

        // Search for Note(s) by Content
        [HttpGet("search/content/{noteContent}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult SearchByContent(string noteContent)
        {
            var matchedNotesContent = Notes.notesList.FindAll(a => a.Content.ToLower().Contains(noteContent.ToLower()));
            if (matchedNotesContent.Count == 0)
            {
                return NotFound();
            }
            return Ok(matchedNotesContent);
        }

        // Categorize a Note
        [HttpPut("notes/{id:int}/category")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult CategorizeNote(int id, [FromBody] CategorizeNoteRequest categorizeNote)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var note = Notes.notesList.FirstOrDefault(a => a.Id == id);
            if (note == null)
            {
                return NotFound();
            }
            note.Category = categorizeNote.Category;
            return NoContent();

        }




    }
}
