﻿using UseYourIllusion.Core.Data.Models;

namespace UseYourIllusion.App.ViewModels.Teams
{
    public class TeamViewModel
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
    }
}
