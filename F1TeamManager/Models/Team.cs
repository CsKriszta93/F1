using System.ComponentModel.DataAnnotations;

namespace F1TeamManager.Models
{
    public class Team
    { 
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(1900, 2018)]
        public int Founded { get; set; }

        [Required]
        [Range(0, 50)]
        public int WorldChampionshipsWon { get; set; }

        [Required]
        public bool IsPaidForMembership { get; set; }
    }
}