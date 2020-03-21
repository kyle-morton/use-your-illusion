using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseYourIllusion.Core.Data;
using UseYourIllusion.Core.Data.Models;

namespace UseYourIllusion.Core.Services
{
    public interface ITeamService
    {
        Task<List<Team>> GetTeamsAsync();
        Task<Team> GetTeamAsync(int id);
        Task UpdateAsync(Team team);
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

        public async Task<Team> GetTeamAsync(int id)
        {
            return await _context.Teams.SingleOrDefaultAsync(t => t.Id == id);
        }

        public async Task UpdateAsync(Team team)
        {
            var existingTeam = await _context.Teams.SingleOrDefaultAsync(t => t.Id == team.Id);

            if (existingTeam == null)
                return;

            existingTeam.Location = team.Location;
            existingTeam.Name = team.Name;
            await _context.SaveChangesAsync();
        }
    }
}
