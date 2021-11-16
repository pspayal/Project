namespace MVC_Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCourse : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERTINTO Courses(ID,Name, Discription,TutoreName, CourseRating)VALUES(1,English,Litrature,Eric,4)");
        }
        
        public override void Down()
        {
        }
    }
}
