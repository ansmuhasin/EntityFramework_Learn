
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();
            //List<Course> courses = context.Courses.Where(a => a.Level == 1).OrderBy(c=>c.Name).ThenBy(c=> c.Level).ToList();
            //var courseDetails = context.Courses.Where(a => a.Level == 1).OrderBy(c => c.Name).ThenBy(c => c.Level)
            //    .Select(x => x.Tags);

            //foreach (var course in courseDetails)
            //{
            //    foreach (var item in course)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}
            //Console.ReadLine();

            //var tags = context.Courses.Where(a => a.Level == 1).OrderBy(c => c.Name).ThenBy(c => c.Level)
            //    .SelectMany(x => x.Tags);

            //foreach (var item in tags)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Grouping
            //var groups = context.Courses.GroupBy(x => x.Level);
            //foreach (var groip in groups)
            //{
            //    Console.WriteLine("Level:" + groip.Key);
            //    foreach (Course course in groip)
            //    {
            //        Console.WriteLine("\t"+ course.Name);
            //    }
            //}
            //Console.ReadLine();

            ////Inner Join
            //var result = context.Courses.Join(context.Authors, x => x.AuthorId, y => y.Id, (course, author) => new
            //{
            //    CourseName = course.Name,
            //    author.Name
            //});

            //Cross join
            //var result = context.Authors.GroupJoin(context.Courses, x => x.Id, y => y.AuthorId, (author, courses) => new
            //{
            //    Author = author,
            //    Count= courses.Count()
            //});

            //var courses = context.Courses.Single(c => c.Id == 2);
            //foreach (var item in courses.Tags)
            //{
            //    Console.WriteLine(item.Name);
            //}

            ////N+1 problem
            //var courses = context.Courses.ToList();
            //foreach (var item in courses)
            //{
            //    Console.WriteLine("{0},{1}", item.Name, item.Author.Name);
            //}

            ////Explicit loading MSDN way
            //var author = context.Authors.ToList();
            //context.Entry(author).Collection(a => a.Courses).Load();

            ////mosh way
            //var authorIDs = author.Select(x => x.Id);
            //context.Courses.Where(c => authorIDs.Contains(c.Id)).Load();


        }
    }
}
