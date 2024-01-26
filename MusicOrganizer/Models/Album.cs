using System.Collections.Generic;


namespace MusicOrganizer.Models
{
  public class Album 
  {
    public string Title { get; set; }
    public string Artist { get; set; }
    public int Id { get; }
    private static List<Album> _instances = new List<Album> { };
    public static string SearchQuery { get; set; }

    public Album(string title, string artist)
    {
      Title = title;
      Artist = artist;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Album> GetAll()
    {
      return _instances;
    }

    public static Album Find(int Id)
    {
      return _instances[Id-1];
    }

    public static List<int> FindAlbum(string search) {
      List<int> results = new List<int> { };
      foreach (Album album in _instances)
      {
        if (album.Title.Contains(search) || album.Artist.Contains(search))
        {
          results.Add(album.Id);
        }
      }
      return results;
    }

    public static List<int> FindAlbumNew() {
      List<int> results = new List<int> { };
      foreach (Album album in _instances)
      {
        if (album.Title.Contains(SearchQuery) || album.Artist.Contains(SearchQuery))
        {
          results.Add(album.Id);
        }
      }
      return results;
    }



  }
}