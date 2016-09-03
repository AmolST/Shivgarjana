using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shivgarjana.Models.Event
{
    public class Gallery
    {
        public int GalleryID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public MultimediaType MultimediaType { get; set; }
    }

    public enum MultimediaType
    {
        Photo,
        Video
    }
}