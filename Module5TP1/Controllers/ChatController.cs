using Module5TP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module5TP1.Controllers
{
    public class ChatController : Controller
    {
        private static List<Chat> listChats = Chat.GetMeuteDeChats();
        // GET: Chat
        public ActionResult Index()
        {
            return View(listChats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            return View(listChats[id-1]);
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            return View(listChats[id-1]);
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                listChats.RemoveAt(id-1);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
