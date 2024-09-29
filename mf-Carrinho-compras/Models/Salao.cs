using mf_Carrinho_compras.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarrinhoDeComprasGestaoSalao.Models
{
    //[Table] fixa o padrão das tabelas. "Salão" é o nome da tabela.

    [Table("Salao")]
    public class Salao : LinksHATEOS
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cnpj { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public int Outros { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}


// Relacionamento N - N e 1 - N (Um salão tem N produtos)