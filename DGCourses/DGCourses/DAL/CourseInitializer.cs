using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DGCourses.Models;

namespace DGCourses.DAL
{
    public class CourseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CourseContext>
    {
        protected override void Seed(CourseContext context)
        {
            var courses = new List<Course>
            {
            new Course{ID = 1, Name = "Log Lake", City = "Kalkaska", State = "MI", Country = "USA"},
            new Course{ID = 1, Name = "Hickory Hills", City = "Traverse City", State = "MI", Country = "USA"},
            new Course{ID = 1, Name = "Yeti", City = "Manton", State = "MI", Country = "USA"},
            new Course{ID = 1, Name = "Leviathan", City = "Ludington", State = "MI", Country = "USA"},
            new Course{ID = 1, Name = "Beauty", City = "Ludington", State = "MI", Country = "USA"},
            new Course{ID = 1, Name = "Beast", City = "Ludington", State = "MI", Country = "USA"},
            new Course{ID = 1, Name = "Goliath", City = "Ludington", State = "MI", Country = "USA"},
            new Course{ID = 1, Name = "Avalanche Park", City = "Boyne City", State = "MI", Country = "USA"}
            };

            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
        }
    }
}