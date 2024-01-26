using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System;
using System.Collections.Generic;


namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTests : IDisposable
  {
    public void Dispose()
    {
      Album.ClearAll();
    }
    
    [TestMethod]
    public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {
      Album myAlbum = new Album("title", "artist");
      Assert.AreEqual(typeof(Album), myAlbum.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Album Title";
      Album myAlbum = new Album(title, "artist");
      string result = myAlbum.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "Album Title";
      Album myAlbum = new Album(title, "artist");
      string updatedTitle = "New Album Title";
      myAlbum.Title = updatedTitle;
      string result = myAlbum.Title;
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetArtist_ReturnsArtist_String()
    {
      string artist = "Artist Name";
      string title = "Album Title";
      Album myAlbum = new Album(title, artist);
      string result = myAlbum.Artist;
      Assert.AreEqual(artist, result);
    }

    [TestMethod]
    public void SetArtist_SetArtist_String()
    {
      string artist = "Artist Name";
      string title = "Album Title";
      Album myAlbum = new Album(title, artist);
      string updatedArtist = "New Artist Name";
      myAlbum.Artist = updatedArtist;
      string result = myAlbum.Artist;
      Assert.AreEqual(updatedArtist, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_AlbumList()
    {
      Album myAlbum = new Album("title", "artist");
      List<Album> expected = new List<Album> { myAlbum };
      List<Album> result = Album.GetAll();
      CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ClearAll_ClearsListOfInstances_AlbumList()
    {
      Album myAlbum = new Album("title", "artist");
      List<Album> expected = new List<Album> { };
      Album.ClearAll();
      List<Album> result = Album.GetAll();
      CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void GetId_ReturnId_Int()
    {
      Album myAlbum = new Album("title", "artist");
      Assert.AreEqual(1, myAlbum.Id);
    }

    [TestMethod]
    public void Find_ReturnsAlbumFromInstanceList_Album()
    {
      Album myAlbum = new Album("title", "artist");
      Album myAlbum2 = new Album("title2", "artist2");
      Album result = Album.Find(2);
      Assert.AreEqual(myAlbum2, result);
      
    }

    [TestMethod]
    public void FindAlbum_ReturnsAlbumFromListUsingStringQuery_Album()
    {
      // Album myAlbum = new Album("title", "artist");
      // Album myAlbum2 = new Album("title2", "artist2");
      // Album result = Album.FindArtist("artist2");
      // Assert.AreEqual(myAlbum2, result);

      Album myAlbum = new Album("title", "artist");
      Album myAlbum2 = new Album("title2", "artist2");
      List<int> result = Album.FindAlbum("title");
      List<int> expected = new List<int> { myAlbum.Id, myAlbum2.Id };
      CollectionAssert.AreEqual(result, expected);
    }

  }
}    