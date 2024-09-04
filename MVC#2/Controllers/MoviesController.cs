using Microsoft.AspNetCore.Mvc;
using MVC_2.Models;
namespace MVC_2.Controllers
{
    public class MoviesController : Controller
    {
        //Actions:Public non-static Functions
        //Action has Spicaal Datatypes[Action Result]

        //public string Test()
        //{
        //    return "Defult Paath";
        //}

        //public string GetMovies(int id)
        //{
        //    return $"ID:{id}";
        //}


        [HttpGet]
        [ActionName("Hamada")]
        public IActionResult GetMovies(int? id,string name,Movie movie)
        {
            //ContentResult res = new ContentResult();
            //res.Content = $"ID:{id}";
            ////res.ContentType = "text/html";
            ////res.ContentType = "object/pdf";
            return Content($"Id:{id}", "text/html");
        }


        //Action Parameters Binding:
        //1.Form
        //2.Segment
        //3.Query String /Query Params
        //4.File



        //public IActionResult Test()
        //{
        //    RedirectToActionResult res = new RedirectToActionResult("GetMovies", "Movies", new {id="id"});
        //    return res;
        //}

        //public ActionResult Test1(int?id)
        //{
        //    RedirectResult res;
        //    if (id == 1)
        //    {  
        //        res = new RedirectResult("https://www.facebook.com");
        //        return res;
        //    }
        //    else
        //    {
        //        res = new RedirectResult("https://www.google.com");
        //        return res;
        //    }
            
        //}


    }
}
 