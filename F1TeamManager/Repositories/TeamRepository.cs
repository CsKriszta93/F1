using AutoMapper;
using F1TeamManager.Models;
using F1TeamManager.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace F1TeamManager.Repositories
{
    public class TeamRepository
    {
        private ApplicationDbContext context;

        public TeamRepository()
        {
            context = new ApplicationDbContext();
        }

        public IEnumerable<TeamViewModel> GetTeams()
        {
            var teams = context.Teams.Select(Mapper.Map<Team, TeamViewModel>).ToList();

            return teams;
        }

        public void AddNewTeam(TeamViewModel teamViewModel)
        {
            var team = Mapper.Map<TeamViewModel, Team>(teamViewModel);
            context.Teams.Add(team);
            context.SaveChanges();

            teamViewModel.Id = team.Id;
        }

        public TeamViewModel GetTeamById(int id)
        {
            var teamInDb = context.Teams.SingleOrDefault(t => t.Id == id);
            var selectedTeam = Mapper.Map<Team, TeamViewModel>(teamInDb);

            return selectedTeam;
        }

        public void UpdateTeam(TeamViewModel teamViewModel)
        {
            var teamInDb = context.Teams.Single(t => t.Id == teamViewModel.Id);
            Mapper.Map(teamViewModel, teamInDb);

            context.SaveChanges();
        }
            
        public void RemoveTeam(int id)
        {
            var teamToRemove = context.Teams.SingleOrDefault(t => t.Id == id);

            context.Teams.Remove(teamToRemove);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}