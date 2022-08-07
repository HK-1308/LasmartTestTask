using LasmartTestTask.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LasmartTestTask.Data
{
    public class DatabaseInitializer
    {
        public static void Initial(IApplicationBuilder app,DataContext dataContext)
        {

            if(!dataContext.Points.Any())
            {
                var points = new List<Point> { new Point {Id = 1, PositionX = 50, PositionY = 50, Color = "gray", Radius =30 },
                                           new Point {Id = 2, PositionX = 500, PositionY = 300, Color = "red", Radius = 60 }};

                dataContext.Points.AddRange(points);
                dataContext.SaveChanges();

                var comments = new List<Comment> {
                new Comment { Id = 1, Text = "comment 1", Color = "white", PointId = 1},
                new Comment { Id = 2, Text = "comment 2", Color = "yellow", PointId = 1},
                new Comment { Id = 3, Text = "comment 3", Color = "white", PointId = 2 },
                new Comment { Id = 4, Text = "comment 4", Color = "gray", PointId = 2 },
                new Comment { Id = 5, Text = "comment 5", Color = "white", PointId = 2 },
                new Comment { Id = 6, Text = "comment 6 looooooooooong comment", Color = "yellow", PointId = 2 },
                new Comment { Id = 7, Text = "comment 7", Color = "gray", PointId = 2 },
                new Comment { Id = 8, Text = "comment 8", Color = "white", PointId = 2 }};

                dataContext.Comments.AddRange(comments);

                dataContext.SaveChanges();
            }
        }
    }
}
