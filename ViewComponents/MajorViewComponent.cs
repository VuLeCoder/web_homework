using Microsoft.AspNetCore.Mvc;
using Lab5.Data;
using Lab5.Models;

namespace Lab5.ViewComponents;

public class MajorViewComponent : ViewComponent
{
    private readonly SchoolContext db;

    public MajorViewComponent(SchoolContext context)
    {
        this.db = context;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var majors = db.Majors.ToList();
        return View("RenderMajor", majors);
    }
}