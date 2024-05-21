var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CollegeDbContext>();

var app = builder.Build();

app.MapGet("/", () => "learning developing REST API on .NET");
app.MapGet("/courses", (CollegeDbContext db) => db.Courses.ToList());
app.MapGet("/courses/{id:int}", (int id, CollegeDbContext db) => db.Courses.Find(id));
app.MapGet("/sessions", (CollegeDbContext db) => db.Sessions.ToList());
app.MapGet("/sessions/{id:int}", (int id, CollegeDbContext db) => db.Sessions.Find(id));

app.MapPost("/courses", (Course course, CollegeDbContext db) =>
{
    db.Courses.Add(course);
    db.SaveChanges();
});
app.MapPut("/courses", (int id, Course course, CollegeDbContext db) =>
{
    db.Courses.Update(course);
    db.SaveChanges();
});

app.MapDelete("/courses", (int id, Course course, CollegeDbContext db) =>
{
    db.Courses.Remove(course);
    db.SaveChanges();
});

//for Session
app.MapPost("/sessions", (Session session, CollegeDbContext db) =>
{
    db.Sessions.Add(session);
    db.SaveChanges();
});

app.MapPut("/session", (int id, Session session, CollegeDbContext db) =>
{
    db.Sessions.Update(session);
    db.SaveChanges();
});

app.MapDelete("/sessions", (int id, Session session, CollegeDbContext db) =>
{
    db.Sessions.Remove(session);
    db.SaveChanges();
});


app.Run();