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
            Chat ch = listChats.FirstOrDefault(c => c.Id == id);
            if (ch != null)
            {
                return View(ch);
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            Chat ch = listChats.FirstOrDefault(c => c.Id == id);
            if (ch != null)
            {
                return View(ch);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Chat ch = listChats.FirstOrDefault(c => c.Id == id);
                if (ch != null)
                {
                    listChats.Remove(listChats.FirstOrDefault(c => c.Id == id));
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
