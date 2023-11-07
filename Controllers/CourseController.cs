using basics.Models;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

// course
public class CourseController : Controller{
    // course
    // course/index
    // public IActionResult Index(){
    //     var kurs = new Course();
    //     kurs.Id = 1;
    //     kurs.Title = "Aspnet core kursu";
    //     kurs.Description = "Güzel bir kurs";
    //     kurs.Image="1.jpg";

    //     return View(kurs); //yapmış olduğumuz kurs nesnesini viewe gönderdik
    // } 

    public IActionResult Details(int? id){  // burası Route kısmına gelen idnin değerini direkt alıyo
        if(id == null){
            return Redirect("/course/list");  // buradaki amaç id değeri null ise bu url ye gitsin
        }
        var kurs = Repository.GetById(id);

        return View(kurs); 
    }

    // course/list
    public IActionResult List(){
    
        return View("CourseList", Repository.Courses);  
    }
}