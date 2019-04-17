using System.Collections.Generic;
using EPiServer.Core;
using EpiserverInterviewExercises.Models.Pages;

namespace EpiserverInterviewExercises.Business.Interfaces
{
    public interface IContentLocator
    {
        IEnumerable<PageData> FindPagesByPageType(PageReference pageLink, bool recursive, int pageTypeId);
        IEnumerable<T> GetAll<T>(ContentReference rootLink) where T : PageData;
        IEnumerable<ContactPage> GetContactPages();
        IEnumerable<EventPage> GetEventPages(ContentReference parent);
    }
}