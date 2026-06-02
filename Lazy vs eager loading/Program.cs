using Microsoft.EntityFrameworkCore;
using StudentCourseLoadingDemo.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var db = new LoadingDemoDbContext();

        // EAGER LOADING
        /*var students = db.Students
            .Include(s => s.Courses)
            .ToList();

        foreach (var s in students)
        {
            Console.WriteLine(s.Name);

            foreach (var c in s.Courses)
            {
                Console.WriteLine(" - " + c.Title);
            }
        }

        var student = db.Students.First();

        Console.WriteLine(student.Name);

        // now accessing related data
        var courses = db.Courses
            .Where(c => c.Studentid == student.Id)
            .ToList();

        foreach (var c in courses)
        {
            Console.WriteLine(c.Title);
        }

        var sync = new SyncService();
        sync.GetStudents(db);

        var asyncService = new AsyncService();
        await asyncService.GetStudentsAsync(db);*/
        List<Student> students = db.Students
            .FromSqlRaw("SELECT * FROM GetAllStudents()")
            .ToList();

        foreach (var s in students)
        {
            Console.WriteLine(s.Name);
        }
    }
}