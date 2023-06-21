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
        public Cliente? Usuario;
        


        public string path = Environment.CurrentDirectory + @"\User.txt";


        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public void OnGet(){}

        public IActionResult OnPost(string cpf,string Password)
        {

            Usuario = _db.Cliente.Where(c => c.Cpf == cpf && c.Senha == Password).FirstOrDefault();
            if (Usuario == null)
            {
                return Page();
            }
            else
            { 
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(Usuario.Id);
                sw.Close();
                return RedirectToPage("/MainPage/Index");
            }

        }

        


    }
}