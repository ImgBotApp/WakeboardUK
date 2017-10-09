using System;
using System.ComponentModel.DataAnnotations;

namespace WakeboardUK.Web.Models
{
    public class Competition
    {
        public int CompetitionId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? start_date { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? end_date { get; set; }

        public string short_name { get; set; }

        public int? location_id { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        public int? country_id { get; set; }

        public string photo_file_name { get; set; }

        public string photo_content_type { get; set; }

        public int? photo_file_size { get; set; }

        public string location { get; set; }

        public string entry { get; set; }

        public string sponsors { get; set; }

        public string schedule { get; set; }

        public string notes { get; set; }

        public string official_url { get; set; }

        public string accommodation { get; set; }

        public bool published { get; set;}

    }
}
