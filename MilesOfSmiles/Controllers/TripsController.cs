﻿using MilesOfSmiles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MilesOfSmiles.Controllers
{
    public class TripsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisneylandTrip2016()
        {
            TripViewModel viewModel = new TripViewModel();
            List<char> photos = Enumerable.Range('a', 26).Select(x => (char)x).ToList();
            var modelPhotos = new List<PhotoItem>();
            foreach (var item in photos)
            {
                modelPhotos.Add(new PhotoItem { ImageSrc = string.Format("{0}.jpg", item) });
            }
            viewModel.Photos = modelPhotos;
            List<string> forms = new List<string> { "001", "002", "003", "004", "006", "007", "008", "009" };
            var feedbackPhotos = new List<PhotoItem>();
            foreach (var item in forms)
            {
                feedbackPhotos.Add(new PhotoItem { ImageSrc = string.Format("{0}.jpg", item) });
            }
            viewModel.Feedback = feedbackPhotos;
            return View(viewModel);
        }

        public ActionResult DisneylandTrip2012()
        {
            var photos = new List<string> { "034", "037", "039", "064", "067", "069", "072", "076", "079", "081", "084", "085", "086", "087", "089", "090", "092", "095", "096", "097", "099", "101", "201", "202", "203", "204", "205", "206" };
            var viewData = new List<PhotoItem>();
            foreach (var item in photos)
            {
                viewData.Add(new PhotoItem { ImageSrc = string.Format("{0}.jpg", item) });
            }
            return View(viewData);
        }

    }
}
