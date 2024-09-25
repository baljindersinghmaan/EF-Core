// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

BloggingContext _db = new BloggingContext();
Console.WriteLine(_db.DbPath);
//Blog b1 = new Blog {Url = "www.google.ca"};
//_db.Blogs.Add(b1);
//_db.SaveChanges();

// Blog b2 = _db.Blogs.Find(1) ?? new();
// Blog b3 = _db.Blogs.Include(j => j.Posts).SingleOrDefault(b => b.BlogId == 1) ?? new();
 Blog b3 = _db.Blogs.Include(j => j.Posts).SingleOrDefault(b => b.Url == "www.yahoo.ca") ?? new();
 // b3.Url = "www.yahoo.com";
//Console.WriteLine($"{b2.BlogId} - {b2.Url}");

//Console.WriteLine(b2.Posts.Count);



//Post p1 = new Post{Title = "Hshshshjasaj1", Content = "sdgsgdgs12sd"};

//b2.Posts.Add(p1);
//_db.Remove(b3);

var result = _db.Blogs.Where(b => b.BlogId <= 55);
Console.WriteLine(result.Count());
foreach(var b in result){
    Console.WriteLine(b.Url);
}
// _db.SaveChanges();

