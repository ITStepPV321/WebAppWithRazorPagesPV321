using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppWithRazorPagesPV321.Pages.Books
{
    public class BooksModel : PageModel
    {
        public string UserName { get; set; }
        public BooksModel()
        {
           UserName = "Admin";
            
        }

        public string PrintShortDate() {
            return $"Current Date: {DateTime.Now.Date.ToShortDateString()}";
        }
        public void OnGet()
        {

        }
    }
}
