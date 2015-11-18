using MyMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MyMusicStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HelloJavaScript()
        {
            return View();
        }
        public ActionResult demo1()
        {
            return View();
        }
        public ActionResult DOM()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("kirstinwalsh0805@gmail.com"));  // replace with valid value 
                message.From = new MailAddress(model.FromEmail);  // replace with valid value
                message.Subject = model.Subject;
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;
                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }
        public ActionResult Sent()
        {
            return View();
        }
        public ActionResult ContactAJAX()
        {
            return View();
        }
        public ActionResult Friday()
        {
            return View();
        }
        public JsonResult GetData()
        {
            EmailFormModel efm = new EmailFormModel();
            efm.FromName = "Kirstin";
            efm.FromEmail = "kirstinwalsh0805@gmail.com";
            efm.Subject = "From Server";

            return Json(efm, JsonRequestBehavior.AllowGet);
        }
    }
}