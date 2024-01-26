using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;



namespace MusicOrganizer.Controllers
{
  public class AlbumsController : Controller
  {
    [HttpGet("/genres/{genreId}/albums/new")]
    public ActionResult New(int genreId)
    {
      Genre genre = Genre.Find(genreId);
      return View(genre);
    }

    [HttpGet("/genres/{genreId}/albums/{albumId}")]
    public ActionResult Show(int genreId, int albumId)
    {
      Album album = Album.Find(albumId);
      Genre genre = Genre.Find(genreId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("album", album);
      model.Add("genre", genre);
      return View(model);
    }

  }
}

