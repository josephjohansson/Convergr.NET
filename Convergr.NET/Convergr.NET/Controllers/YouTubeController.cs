using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Convergr.NET.Models;
using Convergr.NET.ViewModels;

namespace Convergr.NET.Controllers
{
    public class YouTubeController : Controller
    {
        private ApplicationDbContext _context;

        public YouTubeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: YouTube/Random
        public ActionResult Random()
        {
            var video = _context.YouTubeVideos.ToList();
            var hashtags = _context.Hashtags.ToList();
            var viewModel = new RandomYoutubeViewModels
            {
                Video = video.First(),
                Hashtags = hashtags

            };
            return View(viewModel);
        }
    }
}