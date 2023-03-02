using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment.Models;
using Assignment.Entities;

namespace Assignment.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // public IActionResult Index()
    // {
    //     return View();
    // }

  public IActionResult Index()
    {
    //      var model = new List<UserModel>();
    // model.Add(new UserModel { Name = "Janak",Age = "21",Salary = "13000",Designation = ".Net"});
    // model.Add(new UserModel{ Name = "Karan",Age = "20",Salary = "10000",Designation = "python"});
    // model.Add(new UserModel{ Name = "Tania", Age = "22",Salary = "11000",Designation = "React"});
    // return View(model);
    // }
      using (var context=new EmployeeDBContext())
        {
            var employeeList=context.EmployeeDetails.ToList();
             return View(employeeList);
        }
    }
[HttpPost]
    public IActionResult login()
{
    //handle your search stuff here...
    return RedirectToAction("Index", "Home");
}
public IActionResult Employee()
    {
        using (var context=new EmployeeDBContext())
        {
            var employeeList=context.EmployeeDetails.ToList();
            // var emplist=context.Forms.Where(x=>x.EmpId==3).FirstOrDefault();
        }
        return View();
    }
        public IActionResult AddEmployee(UserModel employeeModel)
    {
        using (var context=new EmployeeDBContext())
        {
            //  LoginModel=new EmployeeModel();
            // // employee.FirstName=employeeModel.FirstName;
            // // employee.Name=employeeModel.Name;
            // employee.Email=employeeModel.Email;
            // employee.Password=employeeModel.Password;
            // employee.ConfirmPassword=employee.ConfirmPassword;
            // employee.Contact=employeeModel.Contact;
            // context.Forms.Add(employee);
            // context.SaveChanges();
        }
        return RedirectToAction(actionName: "Index", controllerName: "Home");
        // return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }
    // public IActionResult DisplayUserDetails(){
    // var model = new List<UserModel>();
    // model.Add(new UserModel { Name = "Dhruv",Age = "21",Salary = "15000",Designation = ".Net"});
    // model.Add(new UserModel{ Name = "Rahul",Age = "21",Salary = "15000",Designation = ".Net"});
    // model.Add(new UserModel{ Name = "janak", Age = "22",Salary = "16000",Designation = "React"});
    // return View(model);
    // }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
