using StudentCourseLoadingDemo.Models;

public class SyncService
{
    public void GetStudents(LoadingDemoDbContext db)
    {
        var students = db.Students.ToList();

        foreach (var s in students)
        {
            Console.WriteLine(s.Name);
        }
    }
}