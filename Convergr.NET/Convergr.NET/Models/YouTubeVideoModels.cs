using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Convergr.NET.Models
{
    public class YouTubeVideoModels
    {
        public int Id { get; set; }
        public string VideoTitle { get; set; }
        public string VideoID { get; set; }
        public int Score { get; set; }
        public List<HashtagModels> Hashtags { get; set; }
    }
    
}