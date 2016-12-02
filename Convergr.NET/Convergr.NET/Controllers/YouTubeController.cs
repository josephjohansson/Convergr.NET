using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Convergr.NET.Models;

namespace Convergr.NET.Controllers
{
    public class YouTubeController : Controller
    {
        // GET: YouTube/Random
        public ActionResult Random()
        {
            var video = new YouTubeVideo() { VideoTitle = "Avengers"};

            return View(video);
        }
    }
}