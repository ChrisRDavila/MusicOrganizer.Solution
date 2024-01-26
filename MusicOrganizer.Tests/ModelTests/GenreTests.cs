using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System;
using System.Collections.Generic;

namespace MusicOrganizer.Tests

{
  [TestClass]
  public class GenreTests: IDisposable
  {
    public void Dispose()
    {
      Genre.ClearAll();
    }
    
    [TestMethod]
    public void GenreConstructor_CreatesInstanceOfGenre_Genre()
    {
      Genre testGenre = new Genre("music");
      Assert.AreEqual(typeof(Genre), testGenre.GetType());
    }
    
    [TestMethod]
    public void GetName_ReturnsNameOfGenre_String()
    {
      string name = "Genre Name";
      Genre testGenre = new Genre(name);
      string result = testGenre.Name;
      Assert.AreEqual(name,result);
    }
    
    [TestMethod]
    public void SetName_SetsNameOfGenre_String()
    {
      string updatedName = "New Name";
      Genre testGenre = new Genre("old name");
      testGenre.Name = updatedName;
      string result = testGenre.Name;
      Assert.AreEqual(updatedName, result);
    }
    
    [TestMethod]
    public void GetAll_ReturnsGenreInstanceList_GenreList()
    {
      Genre testGenre = new Genre("music");
      List<Genre> expected = new List<Genre> { testGenre };
      List<Genre> result = Genre.GetAll();
      CollectionAssert.AreEqual(expected,result);
    }
    
    [TestMethod]
    public void ClearAll_ClearsGenreInstanceList_Void()
    {
      Genre testGenre = new Genre("music");
      List<Genre> expected = new List<Genre> { };
      Genre.ClearAll();
      List<Genre> result = Genre.GetAll();
      CollectionAssert.AreEqual(expected,result);
    }

    [TestMethod]
    public void GetId_ReturnsInstanceId_Int()
    {
      Genre testGenre = new Genre("music");
      Assert.AreEqual(1, testGenre.Id);
    }

    [TestMethod]
    public void Find_ReturnsGenreFromInstanceList_Genre()
    {
      Genre testGenre = new Genre("music");
      Genre testGenre2 = new Genre("better music");
      Genre result = Genre.Find(2);
      Assert.AreEqual(testGenre2, result);
    }

    [TestMethod]
    public void AddAlbum_AddsAlbumToGenre_AlbumList()
    {
      string title = "album";
      string artist = "artist";
      Album testAlbum = new Album(title, artist);
      List<Album> expected = new List<Album> { testAlbum };
      string name = "music";
      Genre testGenre = new Genre(name);
      testGenre.AddAlbum(testAlbum);
      List<Album> result = testGenre.Albums;
      CollectionAssert.AreEqual(expected, result);
    }
  }

}