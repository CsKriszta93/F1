using AutoMapper;
using F1TeamManager.Models;
using System.ComponentModel.DataAnnotations;

namespace F1TeamManager.ViewModels
{
    public class TeamViewModel
    {
        public string Title
        {
            get
            {
                return Id != 0 ? "Edit registered team" : "Register new team";
            }
        }

        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter a valid name for the F1 team.")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The year should be between 1900 and 2018")]
        [Range(1900, 2018)]
        public int? Founded { get; set; }

        [Display(Name = "World Championship Titles")]
        [Required(ErrorMessage = "The number should be between 0 and 50.")]
        [Range(0, 50)]
        public int? WorldChampionshipsWon { get; set; }

        [Display(Name = "Membership Fee")]
        [Required]
        public bool IsPaidForMembership { get; set; }

        //for creating a new movie plus initianize Id for the hidden field
        public TeamViewModel()
        {
            Id = 0;
        }

        //for editing an existing movie
        public TeamViewModel(TeamViewModel team)
        {  
            Id = team.Id;
            Name = team.Name;
            Founded = team.Founded;
            WorldChampionshipsWon = team.WorldChampionshipsWon;
            IsPaidForMembership = team.IsPaidForMembership;
        }
    }
}