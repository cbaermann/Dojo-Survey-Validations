using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DojoSurveyValidtion.Models
{
    public class Survey
    {
        [Required(ErrorMessage = "Please enter your first name!")]
        [MinLength(2, ErrorMessage= "First name must be at least 2 characters!")]
        public string Name {get;set;}

        [Required(ErrorMessage="Please enter your location!")]
        public string Location {get;set;}

        [Required(ErrorMessage="Please enter your favorite langauge!")]
        public string Language {get;set;}

        [MinLength(20, ErrorMessage="Please enter at least 20 characters for your comment!")]
        public string Comment {get;set;}

    }
}