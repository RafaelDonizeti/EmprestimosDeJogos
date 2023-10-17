using Microsoft.AspNetCore.Mvc;
using EmprestimosJogos.Data;
using EmprestimosJogos.Models;

namespace EmprestimosJogos.Controllers
{
    public class EmprestimoController : Controller
    {

        readonly private ApplicationDbContext _db;

        public EmprestimoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _db.Emprestimos;
            return View(emprestimos);
        }
    }
}
