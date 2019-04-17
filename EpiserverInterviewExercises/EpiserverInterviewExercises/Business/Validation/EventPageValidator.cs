using EPiServer.Validation;
using EpiserverInterviewExercises.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverInterviewExercises.Business.Validation
{
    public class EventPageValidator : IValidate<EventPage>
    {
        public IEnumerable<ValidationError> Validate(EventPage instance)
        {
            if (instance.StartDate > instance.EndDate)
            {
                yield return new ValidationError
                {
                    ErrorMessage = "The event start date must occur before the end date",
                    PropertyName = "StartDate",
                    RelatedProperties = new string[] { "StartDate", "EndDate" },
                    Severity = ValidationErrorSeverity.Error,
                    ValidationType = ValidationErrorType.StorageValidation
                };
            }

            yield break;
        }
    }
}