using EpiserverInterviewExercises.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverInterviewExercises.Models.ViewModels
{
    public class EventListingViewModel : PageViewModel<EventListingPage>
    {
        public EventListingViewModel(EventListingPage currentPage) : base(currentPage)
        {
        }

        public IEnumerable<EventPage> AllEvents { get; set; }
    }
}