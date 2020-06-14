using System.ComponentModel.DataAnnotations;

namespace NinjaQuest.Models
{
    public class Ninja
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(7)]
        public string Name { get; set; }
    }
}//created Ninja table in SQL
//altered table ninjas