using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;



namespace MusicOrganizer.Controllers
{
  public class SearchController : Controller
  {
    [HttpGet("/search")]
    public ActionResult Search()
    {
      return View();
    }

    [HttpPost("/search_results/{query}")]
    public ActionResult SearchResults(string query)
    {
      // List<int> resultIds = Album.FindAlbum(query);
      
      List<int> resultIds = Album.FindAlbumNew();
      List<Album> model = new List<Album> {};
      foreach (int result in resultIds)
      {
        Album searchResult = Album.Find(result);
        model.Add(searchResult);
      }
      return View(model);
    }

  }
}

