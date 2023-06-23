using System.ComponentModel.DataAnnotations;

namespace NoteTakingApplicationAPI.Models.DTO
{
    public class NoteDTO
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public string Category { get; set; }
    }
}
