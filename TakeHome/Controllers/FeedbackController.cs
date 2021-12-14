using System.Web.Mvc;
using TakeHome.Models;

namespace TakeHome.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(true)]
        public ActionResult Index(FeedbackFormModel form)
        {
            //todo: log this data before returning ThankYou page.

            if (ModelState.IsValid)
            {
                return View("ThankYou", new FeedbackFormConfirmationViewModel(form));
            }
            else
                ViewBag.Result = "Invalid Entries, Kindly Recheck.";
            return View();
        }

    }
}