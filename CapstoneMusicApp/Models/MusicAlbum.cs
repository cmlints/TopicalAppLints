using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapstoneMusicApp.Models
{
    public class MusicAlbum
    {
        public int Id { get; set; }
        public String Genre { get; set; }
        public String ArtistName { get; set; }
        public String AlbumName { get; set; }
        public String Song { get; set; }
        public String Year { get; set; }
        public String NumberOfSongs { get; set; }

        public ICollection<Review> Review { get; set; }
    }

}