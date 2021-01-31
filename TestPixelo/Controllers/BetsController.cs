using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TestPixelo.Models;

namespace TestPixelo.Controllers
{
    public class BetsController : Controller
    {
        private Entities db = new Entities();

        // GET: Bets
        public ActionResult Index()
        {
            return View(db.Bets.ToList());
        }

        // GET: Bets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bet bet = db.Bets.Single(w => w.ID == id);
            if (bet == null)
            {
                return HttpNotFound();
            }
            return View(bet);
        }

        // GET: Bets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MatchDescription,RateOne,RateDraw,RateTwo")] Bet bet)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(bet.MatchDescription))
                {
                    bet.MatchDescription = "MatchDescription";
                }
                
                db.Bets.Add(bet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bet);
        }

        // GET: Bets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bet bet = db.Bets.Single(w => w.ID == id);
            if (bet == null)
            {
                return HttpNotFound();
            }
            return View(bet);
        }

        // POST: Bets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MatchDescription,RateOne,RateDraw,RateTwo")] Bet bet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bet);
        }

        // GET: Bets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bet bet = db.Bets.Single(w => w.ID == id);
            if (bet == null)
            {
                return HttpNotFound();
            }
            return View(bet);
        }

        // POST: Bets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bet bet = db.Bets.Single(w => w.ID == id);
            db.Bets.Remove(bet);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}