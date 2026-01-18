using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework1ASP.Pages
{
    public class AboutCountry
    {
        public string Country { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public string OfficialLanguages { get; set; }
        public string President { get; set; }
        public string Population { get; set; }
    }
    public class Task5Model : PageModel
    {
        public List<AboutCountry> Countries { get; set; } 


        public void OnGet()
        {
            Countries = new List<AboutCountry>
            {
                new AboutCountry
            {
                Country = "France",
                Capital = "Paris",
                Currency = "Euro",
                OfficialLanguages = "French",
                President = "Emmanuel Macron",
                Population = "67 million"
            },
            new AboutCountry
            {
                Country = "Japan",
                Capital = "Tokyo",
                Currency = "Japanese Yen",
                OfficialLanguages = "Japanese",
                President = "N/A (Prime Minister: Fumio Kishida)",
                Population = "126 million"
            },
            new AboutCountry
            {
                Country = "Brazil",
                Capital = "Bras?lia",
                Currency = "Brazilian Real",
                OfficialLanguages = "Portuguese",
                President = "Luiz In?cio Lula da Silva",
                Population = "213 million"
            }
            };
        }
    }
}
