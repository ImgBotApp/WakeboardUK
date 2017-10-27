using System;
using System.ComponentModel.DataAnnotations;

namespace WakeboardUK2018.Models
{
    public class Competitor
    {
        public int CompetitorId { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public int SexId { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}