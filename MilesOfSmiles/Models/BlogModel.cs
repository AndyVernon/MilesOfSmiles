using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilesOfSmiles.Models
{
    public class BlogModel
    {
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public bool Show { get; set; }
        public List<PhotoItem> Photos { get; set; }
    }

    public class PhotoItem
    {
        public string ImageSrc { get; set; }
        public string AltText { get; set; }
        public string TitleText { get; set; }
    }
}