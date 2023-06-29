using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Repository.Interfaces;

namespace VirtualBank.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public IClienteRepository _db;
        public Cliente? Usuario;

        
        public string path = Environment.CurrentDirectory + @"\User.txt";

        public IndexModel(IClienteRepository db)
        {
            _db = db;
        }

        public void OnGet(){}

        public IActionResult OnPost(string cpf, string Password)
        {

            var Usuario = _db.LogCliente(cpf, Password);
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