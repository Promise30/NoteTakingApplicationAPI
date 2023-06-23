using NoteTakingApplicationAPI.Models.DTO;

namespace NoteTakingApplicationAPI.Data
{
    public static class Notes
    {
        public static List<NoteDTO> notesList = new List<NoteDTO>
        {
            new NoteDTO{Id=1, Title="Business Meeting", Content="Discuss business updates, review items, and set priorities for the upcoming week."},
            new NoteDTO{Id=2, Title="Research Findings", Content="Summarize the key findings from the research conducted last week."},
            new NoteDTO{Id=3, Title="Business Presentation", Content="Prepare a presentation highlighting the key features and benefits of our business."},
            new NoteDTO{Id=4, Title="Team Meeting Minutes", Content="Take note of the discussions, decisions, and action items from today's meeting."},
            new NoteDTO{Id=5, Title="Customer Feedback", Content="Compile and analyze customer feedback received through surveys and support channels"},
            new NoteDTO{Id=6, Title="Martial Arts Training Program", Content="Design a training regimen for martial arts practitioners to improve strength."},
            new NoteDTO{Id=7, Title="Fitness Routine for Runners", Content="Provide a detailed fitness routine tailored for runners to improve endurance and strength."},
            new NoteDTO{Id=8, Title="Soccer Practice Drills", Content="Outline a series of practice drills to improve passing on the soccer field."},
            new NoteDTO{Id=9, Title="Literature Analysis", Content="Analyze the themes, characters, and narrative structure in the novel"},
            new NoteDTO{Id=10, Title="Study Tips for Effective Learning", Content="Provide study tips to help students maximize their learning potential"}

        };
    }
}
