using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convergr.NET.Models;

namespace Convergr.NET.ViewModels
{
    class RandomVideoViewModel
    {
        public YouTubeVideo Video { get; set; }
        public List<Hashtag> Hashtags { get; set; }

    }
}
