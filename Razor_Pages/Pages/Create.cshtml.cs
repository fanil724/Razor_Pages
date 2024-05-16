using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages.Models;

namespace Razor_Pages.Pages
{
    [IgnoreAntiforgeryToken]
    public class CreateModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public User Person { get; set; } = new();
        public CreateModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Users.Add(Person);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
