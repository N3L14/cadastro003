namespace Cadastro.Models
{
    public class EnderecoModel
    {
        public int Id { get; set; }

        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? CEP { get; set; }
        public string? Complemento { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }

        public int PessoaId { get; set; }
        public PessoaFisicaModel Pessoa { get; set; } // pra andar pelos objetos
    }
}
