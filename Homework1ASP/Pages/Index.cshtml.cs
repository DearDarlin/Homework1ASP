using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework1ASP.Pages
{
    public class IndexModel : PageModel//Оголошена в класі, щоб вона була доступна на сторінці
    {
        private readonly ILogger<IndexModel> _logger;

        public int DayOfYear { get; set; } //Властивість моделі сторінки

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()//Користувач зайшов на сторінку
                           //Сервер отримує запит і виконує метод OnGet
        {
            DayOfYear = DateTime.Now.DayOfYear;
        }
    }
}
