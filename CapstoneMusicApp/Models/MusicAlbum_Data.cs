using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CapstoneMusicApp.Models
{
    public class MusicAlbum_Data : DbContext
    {
        public MusicAlbum_Data()
            : base("CapstoneMusicAlbum")
        {

        }

        public DbSet<MusicAlbum> MusicAlbums { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}