using Microsoft.AspNetCore.Mvc;
using RichTextEditorDemo.Models;

namespace RichTextEditorDemo.Controllers
{
    public class EditorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new PostViewModel());
        }

        [HttpPost]
        
        [IgnoreAntiforgeryToken] // To keep it simple
        public IActionResult Index(PostViewModel model)
        {
            Console.WriteLine(model.Content);
            ViewBag.Message = "Content submitted!";
            return View(model);
        }
    }
}
