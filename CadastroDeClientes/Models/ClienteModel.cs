using System.ComponentModel.DataAnnotations;

namespace CadastroDeClientes.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do cliente!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite a data de nascimento do cliente!")]
        public DateTime DataDeNascimento{ get; set; }
        [Required(ErrorMessage = "Digite o RG do cliente!")]
        public string RG { get; set; }
        [Required(ErrorMessage = "Digite o CPF do cliente!")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Digite o celular do cliente!")]
        [Phone(ErrorMessage = "O celular informado não é válido!")]
        public string Celular { get; set; }
        [Phone(ErrorMessage = "O telefone informado não é válido!")]
        public string? TelefoneResidencial { get; set; }
        [Phone(ErrorMessage = "O telefone informado não é válido!")]
        public string? TelefoneComercial { get; set; }
        // Endereço principal
        [Required(ErrorMessage = "Digite o CEP!")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "Digite a rua!")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "Digite o bairro!")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Digite a cidade!")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Digite o estado!")]
        public string Estado { get; set; }
        // Endereço secundário
        public string? CepSec { get; set; }
        public string? RuaSec { get; set; }
        public string? BairroSec { get; set; }
        public string? CidadeSec { get; set; }
        public string? EstadoSec { get; set; }
        // Redes sociais
        [Url(ErrorMessage = "Digite um link válido!")]
        public string? Facebook { get; set; }
        [Url(ErrorMessage = "Digite um link válido!")]
        public string? Linkedin { get; set; }
        [Url(ErrorMessage = "Digite um link válido!")]
        public string? Twitter { get; set; }
        [Url(ErrorMessage = "Digite um link válido!")]
        public string? Instagram { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
