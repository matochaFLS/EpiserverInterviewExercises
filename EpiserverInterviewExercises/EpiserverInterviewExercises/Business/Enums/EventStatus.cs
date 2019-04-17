using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpiserverInterviewExercises.Business.Enums
{
    public enum EventStatus
    {
        [Display(Name = "Unknown")]
        Unknown = 1,

        [Display(Name = "Closed")]
        Closed = 2
    }
}