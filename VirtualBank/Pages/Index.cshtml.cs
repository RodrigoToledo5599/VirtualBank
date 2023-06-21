using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace VirtualBank.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public AppDbContext _db;
        public Cliente? clientim;
        public string clientCpf;
        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public void OnGet(){}

        public IActionResult OnPost(string cpf,string Password)
        {

            clientim = _db.Cliente.Where(c => c.Cpf == cpf && c.Senha == Password).FirstOrDefault();
            if (clientim == null)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("/MainPage/Index");
            }

        }

        


    }
}