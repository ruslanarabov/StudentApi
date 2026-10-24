using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controller;

public class StudentsController : Microsoft.AspNetCore.Mvc.Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}