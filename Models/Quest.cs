using System.ComponentModel.DataAnnotations;

namespace NinjaQuest.Models{
    public class Quest
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
    }
}
//Created quest table in SQL
//added quests to the SQL table