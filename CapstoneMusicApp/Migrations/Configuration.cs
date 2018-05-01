namespace CapstoneMusicApp.Migrations
{
    using CapstoneMusicApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CapstoneMusicApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CapstoneMusicApp.Models.ApplicationDbContext context)
        {
            context.MusicAlbums.AddOrUpdate(m => m.Genre,
                new MusicAlbum()
                {
                    Genre = "Country",
                    ArtistName = "Sam Hunt",
                    AlbumName = "Montevallo",
                    Song = "Cop Car",
                    Year = "2014",
                    NumberOfSongs = "10"
                },

                new MusicAlbum()
                {
                    Genre = "Country",
                    ArtistName = "Reba McEntire",
                    AlbumName = "Room to Breathe",
                    Song = "Sky Full of Angels",
                    Year = "2003",
                    NumberOfSongs = "12"
                },

                 new MusicAlbum()
                 {
                     Genre = "Country",
                     ArtistName = "Alan Jackson",
                     AlbumName = "Good Time",
                     Song = "Good Time",
                     Year = "2008",
                     NumberOfSongs = "17"
                 },

                 new MusicAlbum()
                 {
                      Genre = "Country",
                      ArtistName = "Kane Brown",
                      AlbumName = "Kane Brown Deluxe",
                      Song = "Heaven",
                     Year = "2017",
                     NumberOfSongs = "15"
                 },

                  new MusicAlbum()
                  {
                      Genre = "Country",
                      ArtistName = "Maddie and Tae",
                      AlbumName = "Start Here",
                      Song = "Shut Up and Fish",
                      Year = "2015",
                      NumberOfSongs = "11"
                  },

                new MusicAlbum()
                {
                    Genre = "Country",
                    ArtistName = "Dierks Bently",
                    AlbumName = "Raiser",
                    Song = "Drunk on a Plane",
                    Year = "2014",
                    NumberOfSongs = "12"
                },

                 new MusicAlbum()
                 {
                     Genre = "Country",
                     ArtistName = "Brothers Osbone",
                     AlbumName = "Pawn Shop",
                     Song = "It Ain't My Fault",
                     Year = "2016",
                     NumberOfSongs = "11"
                 },

                 new MusicAlbum()
                 {
                     Genre = "Country",
                     ArtistName = "Hunter Hayes",
                     AlbumName = "Hunter Hayes",
                     Song = "Everybody's Got Somebody But Me",
                     Year = "2011",
                     NumberOfSongs = "12"
                 },

                  new MusicAlbum()
                  {
                      Genre = "Country",
                      ArtistName = "Jaron Lowenstein",
                      AlbumName = "Getting Dressed in the Dark",
                      Song = "Pray For You",
                      Year = "2010",
                      NumberOfSongs = "10"
                  },

                new MusicAlbum()
                {
                    Genre = "Country",
                    ArtistName = "Gloriana",
                    AlbumName = "Gloriana",
                    Song = "Wild at Heart",
                    Year = "2009",
                    NumberOfSongs = "13"
                },

                 new MusicAlbum()
                 {
                     Genre = "Country",
                     ArtistName = "Joey & Rory",
                     AlbumName = "The Life of a Song",
                     Song = "Cheater Cheater",
                     Year = "2008",
                     NumberOfSongs = "12"
                 },

                 new MusicAlbum()
                 {
                     Genre = "Country",
                     ArtistName = "Shania Twain",
                     AlbumName = "Come On Over",
                     Song = "Man! I Feel Like a Women",
                     Year = "1997",
                     NumberOfSongs = "16"
                 },
                  new MusicAlbum()
                  {
                      Genre = "Country",
                      ArtistName = "Luke Bryan",
                      AlbumName = "Crash My Party",
                      Song = "Play It Again",
                      Year = "2013",
                      NumberOfSongs = "13"
                  },

                new MusicAlbum()
                {
                    Genre = "Country",
                    ArtistName = "Old Dominion",
                    AlbumName = "Meat and Candy",
                    Song = "Break Up With Him",
                    Year = "2015",
                    NumberOfSongs = "11"
                },

                 new MusicAlbum()
                 {
                     Genre = "Country",
                     ArtistName = "Taylor Swift",
                     AlbumName = "Taylor Swift",
                     Song = "Should've Said No",
                     Year = "2006",
                     NumberOfSongs = "11"
                 }
                 );
        }
    }
}
