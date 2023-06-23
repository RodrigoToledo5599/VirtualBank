using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace VirtualBank.Pages
{
    [BindProperties]
    public class CreateAccountModel : PageModel
    {
        public AppDbContext? _db { get; set; }
        public List<Cliente> ListaDeClientes { get; set; }
        public Cliente? Usuario { get; set; }
        public CreateAccountModel(AppDbContext db) 
        {
            _db = db ?? throw new ArgumentNullException(nameof(db)); ;
        }


        public void OnGet()
        {
            ListaDeClientes = _db.Cliente.OrderBy(c => c.Id).ToList();
        }

        public IActionResult OnPost(Cliente Usuario)
        {
            bool valido = ValidandoConta(Usuario);;
            if (valido == false)
                return Page();
            else
                _db.Cliente.Add(Usuario);
                _db.SaveChanges();
                return RedirectToPage("/Index");
        }

        public bool ValidandoConta(Cliente User)
        {
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