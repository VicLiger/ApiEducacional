using System.ComponentModel.DataAnnotations;

namespace ApiEducacional.Entities
{
    public class Aluno
    {
        [Key]
        public int AlunoId { get; set; }

        [Required]
        [Range(0, 999999999, ErrorMessage = "Número de matrícula é inválido")]
        public int Matricula { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "O nome é muito extenso")]
        public string NomeCompleto { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "O nome é muito extenso")]
        public string NomePai {  get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "O cpf do pai inserido é inválido")]
        public string CpfPai { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "O nome é muito extenso")]
        public string NomeMae { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "O cpf do pai inserido é inválido")]
        public string CpfMae { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "O cpf do aluno é inválido")]
        public string Cpf {  get; set; }

        [Required]
        [StringLength(9, ErrorMessage = "Verifique o cep inserido")]
        public string Cep { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "O endenreço digitado é muito grande")]
        public string Endereco { get; set; }

    }
}
