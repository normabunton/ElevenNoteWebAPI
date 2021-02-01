namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditNote : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "ModifiedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "ModifiedUtc");
        }
    }
}
