using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Convergr.NET.Models;

namespace Convergr.NET.ViewModels
{
    public class RandomYoutubeViewModels
    {
        public YouTubeVideo Video { get; set; }
        public List<HashtagModels> Hashtags { get; set; }

    }
}