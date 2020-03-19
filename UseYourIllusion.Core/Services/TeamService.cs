using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UseYourIllusion.Core.Data;
using UseYourIllusion.Core.Data.Models;

namespace UseYourIllusion.Core.Services
{
    public interface ITeamService
    {
        Task<List<Team>> GetTeamsAsync();
    }
    public class TeamService : Base, ITeamService
    {
        public TeamService(UseYourIllusionDbContext context) : base(context)
        { 
        }

        public async Task<List<Team>> GetTeamsAsync()
        {
            return await _context.Teams.ToListAsync();
        }
    }
}
