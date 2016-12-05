using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Convergr.NET.Models;

namespace Convergr.NET.Controllers
{
    public class YouTubeVideosController : Controller
    {
        private ApplicationDbContext _context;

        public YouTubeVideosController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: YouTube/Viewer
        public ActionResult Viewer()
        {
            var video = _context.YouTubeVideos;
            var hashtags = _context.Hashtags;

            var viewModel = new WatchViewModels
            {
                HashtagModels = hashtags,
                YouTubeVideoModels = video
            };
            
            return View(viewModel);
        }
    }
}