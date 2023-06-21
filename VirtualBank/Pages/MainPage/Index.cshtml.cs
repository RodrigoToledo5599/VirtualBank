using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace VirtualBank.Pages.MainPage
{
    public class IndexModel : PageModel
    {
        public AppDbContext _db { get; set; }
        public Cliente Usuario { get; set; }
        public string path = Environment.CurrentDirectory + @"\User.txt";
        public int? userid {get;set; }


        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            StreamReader sr = new StreamReader(path);
            userid = int.Parse(sr.ReadLine());
            sr.Close();
            Usuario = _db.Cliente.Where(c => c.Id == userid).FirstOrDefault();
            


        }
    }
}
