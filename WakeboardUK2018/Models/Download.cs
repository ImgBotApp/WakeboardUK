using System.ComponentModel.DataAnnotations;

namespace WakeboardUK2018.Models
{
    public class Download
    {
        public int DownloadId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Url { get; set; }
    }
}