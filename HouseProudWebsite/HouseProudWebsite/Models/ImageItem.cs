using System;

namespace HouseProudWebsite.Models
{
    public class ImageItem
    {
        public string Image { get; set; } = string.Empty;
        public bool IsImageReveal { get; set; }
        public string RevealImage { get; set; } = string.Empty;
        public bool Enabled { get; set; }
        public bool Showcase { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool ShowDescription { get; set; }
    }
}
