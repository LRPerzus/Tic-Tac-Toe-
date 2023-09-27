﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TIc_Tac_Toe.DAL;
using TIc_Tac_Toe.Models;

namespace TIc_Tac_Toe.Controllers
{
    public class UserController : Controller
    {
        TicTacToeDAL context = new TicTacToeDAL();

        // GET: User
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                RedirectToAction("Login", "Home");
            }
            user u = context.GetUser(HttpContext.Session.GetString("username"));
            return View(u);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
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
        public ActionResult Create(IFormCollection collection)
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
