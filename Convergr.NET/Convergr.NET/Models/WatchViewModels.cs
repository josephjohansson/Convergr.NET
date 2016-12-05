using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Convergr.NET.Models
{
    public class WatchViewModels
    {
        public DbSet<YouTubeVideoModels> YouTubeVideoModels { get; set; }
        public DbSet<HashtagModels> HashtagModels { get; set; }
    }
}