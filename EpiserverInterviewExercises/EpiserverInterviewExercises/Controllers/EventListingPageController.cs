using EpiserverInterviewExercises.Business;
using EpiserverInterviewExercises.Business.Interfaces;
using EpiserverInterviewExercises.Models.Pages;
using EpiserverInterviewExercises.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiserverInterviewExercises.Controllers
{
    public class EventListingPageController : PageControllerBase<EventListingPage>
    {
        private IContentLocator _contentLocator;

        public EventListingPageController(IContentLocator contentLocator)
        {
            _contentLocator = contentLocator;
        }

        public ActionResult Index(EventListingPage currentPage)
        {
            var model = new EventListingViewModel(currentPage)
            {
                AllEvents = _contentLocator.GetEventPages(currentPage.ContentLink)
            };
            return View(model);
        }
    }
}