using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;


namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTests

  {
    // [TestMethod]
    // public void TestName_TestIsDoing_Returns()
    // {
    //   //Assemble
    //   //Act
    //   //Assert
    // }
    [TestMethod]
    public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {
      Album myAlbum = new Album();
      Assert.AreEqual(typeof(Album), myAlbum.GetType());
    }
  }
}    