using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using UseYourIllusion.App.ViewModels.Teams;
using UseYourIllusion.Core.Services;

namespace UseYourIllusion.App.Controllers
{

    [ApiController]
    [Route("Team")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [Route("", Name = "GetTeams")]
        public async Task<IActionResult> GetTeams()
        {
            var teams = await _teamService.GetTeamsAsync();
            return Ok(teams.Select(TeamViewModel.From).ToList());
        }

        [Route("{id}", Name = "GetTeam")]
        public async Task<IActionResult> GetTeam(int id)
        {
            var team = await _teamService.GetTeamAsync(id);
            return Ok(TeamViewModel.From(team));
        }
        
        [HttpPut]
        [Route("{id}", Name = "UpdateTeam")]
        public async Task<IActionResult> UpdateTeam(int id, TeamViewModel team)
        {
            if (!ModelState.IsValid)
            {
                // todo: add GetErrors()...
            }

            await _teamService.UpdateAsync(team.ToModel());

            return Ok(team);
        }
    }
}
