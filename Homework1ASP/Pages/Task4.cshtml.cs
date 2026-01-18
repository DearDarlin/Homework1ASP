using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework1ASP.Pages
{
    public class Task4Model : PageModel
    {
        public List<string> Restaurant { get; set; }
        public void OnGet()
        {
            Restaurant = new List<string>
            {
                "Cherry Lake",
                "Маклауд",
                "Mandrivnyk",
                "Нова Провінція",
                "Beer&Blues Art Pub",
                "The Georgian Factory"
            };
        }
    }
}
