using Microsoft.AspNetCore.Mvc;

public class UsersController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    public ActionResult AddUser()
    {
        return View();
    }
    public ActionResult EditUser()
    {
        return View();
    }
}