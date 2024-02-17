using BlogEF.Data;
using BlogEF.Models;
using Microsoft.EntityFrameworkCore;

using (var context = new BlogDataContext())
{
    // var tag = new Tag { Name = ".NET", Slug = "dotnet" };
    // var tag1 = new Tag { Name = "ASP.NET", Slug = "asp.net" };

    // context.Tags?.Add(tag);
    // context.Tags?.Add(tag1);
    // context.SaveChanges();

    // var tag = context.Tags?.FirstOrDefault(x => x.Id == 2);
    // tag.Name = ".NET";
    // tag.Slug = "dotnet";

    // context.Update(tag);
    // context.SaveChanges();

    // var tag = context.Tags?.FirstOrDefault(x => x.Id == 2);

    // context.Remove(tag);
    // context.SaveChanges();

    var tags = context
        .Tags?
        .AsNoTracking()
        .ToList();

    foreach (var tag in tags)
    {
        Console.WriteLine(tag.Name);
    }
}