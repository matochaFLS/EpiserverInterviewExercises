using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverInterviewExercises.Models.Pages
{
    [SiteContentType(
        DisplayName = "Event listing page",
        Description = "",
        GUID = "01634266-37E5-4E84-A956-F7C8DC21166E",
        GroupName = Global.GroupNames.Default)]
    [SiteImageUrl]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(EventPage)})] // Pages we can create under the event listing page...
    public class EventListingPage : SitePageData
    {
    }
}