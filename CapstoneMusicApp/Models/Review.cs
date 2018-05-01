using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapstoneMusicApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public String Content { get; set; }

        public int MusicAlbumId { get; set; }
    }
}