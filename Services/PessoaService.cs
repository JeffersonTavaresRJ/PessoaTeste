namespace Services
{
    using DTO;
    using Models;
    public class PessoaService
    {
        private List<Pessoa> Popula()
        {
            var year = 1976;
            List<Pessoa> lista = new List<Pessoa>();

            for (int i = 0; i < 48; i++)
            {
                Pessoa p = new Pessoa();
                p.Nome = "Jefferson" + i;

                Random random = new Random();
                int mes = random.Next(1, 13);

                p.DataNascimento = new DateTime(year + i, mes, 18);

                lista.Add(p);
            }

            return lista;
        }

        public List<PessoaDTO> GetAll()
        {
            var lista = Popula();
            List<PessoaDTO> result = new List<PessoaDTO>();

            foreach (var item in lista)
            {
                PessoaDTO pessoaDTO = new PessoaDTO(item.Nome, item.DataNascimento);
                result.Add(pessoaDTO);
            }

            return result;
        }

    }
}
