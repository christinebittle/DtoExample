using EntityFrameworkTest.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamAPIController : ControllerBase
    {
        //todo: learn more about dependency injection
        private readonly ApplicationDbContext _context;

        public TeamAPIController(ApplicationDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// This endpoint returns teams in the syst4em
        /// </summary>
        /// <returns>[{Team},{Team},{Team}]</returns>
        /// <example>
        /// GET api/teamapi/listteams -> [{"teamId":6,"teamName":"Humber Hawks", "teamDesc":"This team has 2 players","schoolName":"Humber"},{"teamId":7,"teamName":"Humber Hawks Esports","teamDesc":"This team has 1 players","schoolName":"Humber"},{"teamId":8,"teamName":"Waterloo Warriors","teamDesc":"This team has 0 players","schoolName":"Waterloo"}]
        /// </example>
        [HttpGet(template:"ListTeams")]
        public List<TeamDto> ListTeams()
        {
            List<Team> Teams = _context.Teams
                .Include(t => t.School)
                .Include(t => t.Players).ToList();
            List<TeamDto> TeamDtos = new List<TeamDto>();
            foreach(Team Team in Teams)
            {
                //putting the information from the database into
                //a defined package
                TeamDtos.Add(new TeamDto() { 
                    TeamId = Team.TeamId,
                    TeamName = Team.TeamName,
                    TeamDesc = "This team has "+Team.Players.Count+" players",
                    SchoolName = Team.School.SchoolName
                   
                });

            }
            return TeamDtos;

        }
        [HttpGet(template:"FindTeam/{id}")]
        public Team FindTeam(int id)
        {
            //todo: return 404 if there is no team

            //select * from teams where teamid={id}
            return _context.Teams.Find(id);
        }

    }
}
