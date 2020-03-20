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
    }
}
