using System.Text;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using VirtualBank;

namespace VirtualBank.Pages.MainPage
{
    public class IndexModel : PageModel
    {
        public AppDbContext _db { get; set; }
        public Cliente Usuario { get; set; }
        public string nome { get; set; }
        


        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public void OnGet(GetCurrentUser getCurrentUser)
        {
            Usuario = _db.Cliente.Where(c => c.Id == getCurrentUser.GettingUser()).FirstOrDefault();
            nome = getingFirstName();

        }



        public string getingFirstName()
        {
            List<char> name = new List<char>();
			char c;
			for (int i = 0; i <= Usuario.Nome.Length-1; i++)
			{
				c = Usuario.Nome.Trim()[i];
                if (c.Equals(' '))
					break;
                else
                    name.Add(c);
			}
            string result = new string(name.ToArray());
            return result.ToString();
		}
    }
}
