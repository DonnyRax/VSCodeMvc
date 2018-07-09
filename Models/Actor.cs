using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Actor
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string FirstName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string LastName { get; set; }

        [Display(Name = "DoB"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
    }
}