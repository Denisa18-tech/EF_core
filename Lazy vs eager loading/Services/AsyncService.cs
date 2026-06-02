using Microsoft.EntityFrameworkCore;
using StudentCourseLoadingDemo.Models;

public class AsyncService
{
    public async Task GetStudentsAsync(LoadingDemoDbContext db)
    {
        var students = await db.Students.ToListAsync();

        foreach (var s in students)
        {
            Console.WriteLine(s.Name);
        }
    }
}