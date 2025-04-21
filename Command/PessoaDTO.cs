using System.IO.Pipes;

namespace DTO
{
    public class PessoaDTO
    {
        public string Nome { get; set; }

        public int Idade { get; set; }
        public string DataNascimento { get; set; }

        public PessoaDTO( string _nome, DateTime _dataNascimento)
        {
            this.Nome = _nome;

            this.Idade = GetIdade(_dataNascimento);

            this.DataNascimento = _dataNascimento.ToString("dd/MM/yyyy");
        }

        private int GetIdade(DateTime _dataNascimento)
        {
            var idade = DateTime.Today.Year - _dataNascimento.Year;
            return _dataNascimento.Month > DateTime.Today.Month ? --idade : idade;
        }



    }
}
