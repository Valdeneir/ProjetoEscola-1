

using ProEscola.Data;
using ProEscola.Models;

namespace ProEscola.Repositório
{
    public class R_Alunos : IR_Aluno
    {
        private readonly BancoContext _bancoContext;


        public R_Alunos (BancoContext bancoContext)
        {

            _bancoContext = bancoContext;

        }

        public AlunoModel Adicionar(AlunoModel aluno)
        {

            _bancoContext.Aluno.Add(aluno);
            _bancoContext.SaveChanges();      //realizando um commit

            return aluno;

        }
    }
}
