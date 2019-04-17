using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using EpiserverInterviewExercises.Business.Enums;
using EpiserverInterviewExercises.Business.SelectionFactories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpiserverInterviewExercises.Models.Pages
{
    [SiteContentType(
        DisplayName = "Event page",
        Description = "",
        GUID = "3E94BCB0-D9A4-4E47-A386-3AF29E1AAB1D",
        GroupName = Global.GroupNames.Default)]
    [SiteImageUrl]
    public class EventPage : StandardPage
    {
        [Display(
          Name = "Summary",
          GroupName = SystemTabNames.Content,
          Order = 400)]
        [UIHint(UIHint.Textarea)]
        public virtual string Summary { get; set; }

        [Display(
          Name = "Description",
          GroupName = SystemTabNames.Content,
          Order = 410)]
        public virtual XhtmlString Description { get; set; }

        [Display(
          Name = "Title",
          GroupName = Global.GroupNames.Event,
          Order = 300)]
        [RegularExpression("^[a-zA-Z0-9]+$")]
        [Required]
        public virtual string Title { get; set; }

        [Display(
          Name = "Speaker",
          GroupName = Global.GroupNames.Event,
          Order = 310)]
        [SelectOne(SelectionFactoryType = typeof(SpeakerSelectionFactory))]
        public virtual string Speaker { get; set; }

        [Display(
          Name = "No Attendees", 
          GroupName = Global.GroupNames.Event,
          Order = 320)]
        [Range(1, 100)]
        public virtual int NoAttendees { get; set; }

        [Display(
          Name = "Start date",  
          GroupName = Global.GroupNames.Event,
          Order = 330)]
        [Required]
        public virtual DateTime StartDate { get; set; }

        [Display(
          Name = "End date",
          GroupName = Global.GroupNames.Event,
          Order = 340)]
        public virtual DateTime EndDate { get; set; }

        [Display(
          Name = "Event image", 
          GroupName = Global.GroupNames.Event,
          Order = 350)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference EventImage { get; set; }

        [Display(
          Name = "Additional content",
          GroupName = SystemTabNames.Content,
          Order = 420)]
        public virtual ContentArea AdditionalContent { get; set; }

        [Display(
          Name = "Event status", 
          GroupName = Global.GroupNames.Event,
          Order = 360)]
        [BackingType(typeof(PropertyNumber))]
        [SelectOne(SelectionFactoryType = typeof(EnumSelectionFactory<EventStatus>))]
        public virtual EventStatus EventStatus { get; set; } // renamed as in PageData is already property Status
    }
}