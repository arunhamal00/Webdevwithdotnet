using Microsoft.AspNetCore.Mvc.RazorPages;

public class CoursesModel : PageModel
{
    public List<Course> Courses { get; set; }
    public async Task OnGet()
    {
        // CollegeDbContext db = new();
        // Courses = db.Courses.ToList();

        //http call
        HttpClient http = new HttpClient();
        Courses = await http.GetFromJsonAsync<List<Course>>("http://localhost:5250/Courses");
    }
}
