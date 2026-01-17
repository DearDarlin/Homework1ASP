using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework1ASP.Pages
{
    public class Task1Model : PageModel//Оголошена в класі, щоб вона була доступна на сторінці Task1.cshtml
    {
        public int DayOfYear { get; set; } //Властивість моделі сторінки
        public void OnGet()//Користувач зайшов на сторінку
                           //Сервер отримує запит і виконує метод OnGet
        {
            DayOfYear = DateTime.Now.DayOfYear;
        }
    }
}
