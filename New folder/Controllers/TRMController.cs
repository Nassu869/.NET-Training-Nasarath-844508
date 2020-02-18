using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication12.Controllers
{
    public class TRMController : Controller
    {
        // GET: TRM
        [HttpPost]
        public ActionResult Index(string re,string sk,DateTime st,DateTime en)
        {
            SHEEBAEntities ctx = new SHEEBAEntities();
            NEW_TRAINING tr = new NEW_TRAINING();
            tr.REQUEST_NAME = re;
            tr.SKILL = sk;
            tr.START_D = st;
            tr.END_D = en;
            ctx.NEW_TRAINING.Add(tr);
            ctx.SaveChanges();
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}