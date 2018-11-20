using F1TeamManager.Repositories;
using F1TeamManager.ViewModels;
using System.Web.Mvc;

namespace F1TeamManager.Controllers
{
    public class TeamsController : Controller
    {
        private TeamRepository teamRepository;

        public TeamsController()
        {
            teamRepository = new TeamRepository();
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            var teams = teamRepository.GetTeams();

            return View(teams);
        }

        public ViewResult AddTeam()
        {
            var viewModel = new TeamViewModel();

            return View("TeamForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(TeamViewModel team)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new TeamViewModel(team);

                return View("TeamForm", viewModel);
            }

            if(team.Id == 0)
            {
                teamRepository.AddNewTeam(team);

                return RedirectToAction("Index");
            }
            else
            {
                teamRepository.UpdateTeam(team);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var teamToEdit = teamRepository.GetTeamById(id);

            if (teamToEdit == null)
                return HttpNotFound();

            var viewModel = new TeamViewModel(teamToEdit);

            return View("TeamForm", viewModel);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            teamRepository.RemoveTeam(id);

            return RedirectToAction("Index");
        } 
     }
}