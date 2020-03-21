using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UseYourIllusion.Core.Data.Models;

namespace UseYourIllusion.App.ViewModels.Teams
{
    public class TeamViewModel : IValidatableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public static TeamViewModel From(Team team)
        {
            return new TeamViewModel
            {
                Id = team.Id,
                Name = team.Name,
                Location = team.Location
            };
        }

        public Team ToModel()
        {
            return new Team
            {
                Id = Id,
                Location = Location,
                Name = Name
            };
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(Location))
            {
                yield return new ValidationResult("Location is required");
            }
            if (string.IsNullOrEmpty(Name))
            {
                yield return new ValidationResult("Name is required");
            }
            if (Id == 0)
            {
                yield return new ValidationResult("Id is required");
            }
        }
    }
}
