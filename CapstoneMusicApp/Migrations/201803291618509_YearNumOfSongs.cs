namespace CapstoneMusicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YearNumOfSongs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MusicAlbums", "Year", c => c.Int(nullable: false));
            AddColumn("dbo.MusicAlbums", "NumberOfSongs", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MusicAlbums", "NumberOfSongs");
            DropColumn("dbo.MusicAlbums", "Year");
        }
    }
}
