using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework1ASP.Pages
{
    public class Task2Model : PageModel //Модель сторінки, живе поки формується відповідь на запит
    {
        public char RandomLetter { get; set; }
        public void OnGet()
        {
            Random random = new Random();//Створення екземпляру класу для генерації рандомних чисел
            RandomLetter = (char)random.Next('A', 'Z' + 1);//Генерація випадкової літери від A до Z
        }
    }
}
