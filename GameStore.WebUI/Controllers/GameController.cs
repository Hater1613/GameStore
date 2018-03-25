using GameStore.BusinessLogicLayer.Abstract;
using System.Linq;
using System.Web.Mvc;

namespace GameStore.WebUI.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService gameService;

        public GameController(IGameService gameService)
        {
            this.gameService = gameService;
        }

        public JsonResult GetAllGames()
        {
            var games = gameService.GetGamesList().ToList();
            return Json(games, JsonRequestBehavior.AllowGet);
        }
    }
}