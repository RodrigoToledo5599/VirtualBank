using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace VirtualBank.Pages
{
    
    public class CreateAccountModel : PageModel
    {
        public AppDbContext? _db { get; set; }
        //public List<Cliente> ListaDeClientes { get; set; }
        [BindProperty]
        public Cliente Usuario { get; set; }
        public CreateAccountModel(AppDbContext db) 
        {
            _db = db;
        }


        public void OnGet() {}

        public IActionResult OnPost(Cliente Usuario)
        {
			bool valido = ValidandoConta(Usuario);
            if (valido == false)
                return Page();
            else
			    _db.Cliente.Add(Usuario);
			    _db.SaveChanges();
			    return RedirectToPage("/Index");
		}
        
        public bool ValidandoConta(Cliente User)
        {
            var ListaDeClientes = _db.Cliente.OrderBy(c => c.Id).ToList();
            bool checking = false;
            foreach(Cliente cliente in ListaDeClientes)
            {
                if (User.Cpf == cliente.Cpf && User.Email == cliente.Email && User.Senha == cliente.Senha)
                {
                    checking = false;
                    break;   
                }
                else
                    checking = true;
            }
            return checking;
        }


        
    }
}
