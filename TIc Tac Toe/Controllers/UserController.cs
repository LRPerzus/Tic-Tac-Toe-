using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TIc_Tac_Toe.DAL;
using TIc_Tac_Toe.Models;

namespace TIc_Tac_Toe.Controllers
{
    public class UserController : Controller
    {
        TicTacToeDAL context = new TicTacToeDAL();

        // Views Actions
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                RedirectToAction("Login", "Home");
            }
            user u = context.GetUser(HttpContext.Session.GetString("username"));
            return View(u);
        }

        public ActionResult Play()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                RedirectToAction("Login", "Home");
            }
            return View();
        }

        public ActionResult Local()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                RedirectToAction("Login", "Home");
            }
            return View(); 
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PostGame(int player1_userid, int player2_userid, string moveNotation, string winner)
        {
            gameStats gameStats = new gameStats();
            gameStats.player1_userid = player1_userid;
            gameStats.player2_userid = player2_userid;
            gameStats.winner = winner;
            gameStats.moveNotation = moveNotation;
            gameStats.timestamp = DateTime.Now;

            context.sendGame(gameStats);

            return RedirectToAction("Index", "User");
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
