using Microsoft.AspNetCore.Mvc.RazorPages;

public class CoursesModel: PageModel
{    
    public List<Course> Courses { get; set; }
    public void OnGet()
    {
        CollegeDbContext db = new();
        Courses = db.Courses.ToList();
    }
}