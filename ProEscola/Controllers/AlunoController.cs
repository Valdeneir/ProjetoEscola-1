using Microsoft.AspNetCore.Mvc;
using ProEscola.Models;
using ProEscola.Repositório;

namespace ProEscola.Controllers
{
    public class AlunoController : Controller
    {

        private readonly IR_Aluno _aluno;


        public AlunoController(IR_Aluno aluno)
        {

            _aluno = aluno;

        }


        public IActionResult IndexAluno()
        {
            return View();
        }


        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Alterar()
        {
            return View();
        }

        public IActionResult AddMateria()
        {
            return View();
        }

        [HttpPost]  //metodo de inclusão, recebe e cadastra a informação
        public IActionResult Adicionar(AlunoModel aluno)
        {
            
            _aluno.Adicionar(aluno);
            return RedirectToAction("Index");


        }



    }
}
