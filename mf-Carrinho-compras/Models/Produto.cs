using mf_Carrinho_compras.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarrinhoDeComprasGestaoSalao.Models
{
    //O padrão do framework é sempre em inglês. [Table] fixa o padrão das tabelas.
    [Table("Produtos")]
    public class Produto : LinksHATEOS
    {
        //Configuração de propriedades. Uma chave e requisitos obrigatórios
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")] //O campo valor é decimal e terá 2 casas decimais com, no máximo, 18 dígitos
        public Decimal Valor { get; set; }
        [Required]
        public TipoServicos Tipo { get; set; }
        [Required]
        public VendaProduto DataVenda { get; set; }
        [Required]
        public int SalaoId { get; set; }

        public Salao Salao { get; set; } //Carregar todas as informações associadas ao salão

    }

    // Padronizando os produtos vendidos
    public enum TipoServicos
    {
        LimpezaPele,
        HidratacaoFacial,
        Esfoliacao,
        DrenagemLinfatica,
        Maquiagem,
        DesignSobrancelhas,
        Massagem,
        CordeCabelo,
        Barba,
        HidratacaoCabelo,
    }
    // Padronizando os produtos e separando dos serviços
    public enum VendaProduto
    {
        Shampoo,
        Condicionador,
        Secador,
        Alisantes,
        Tinturas,
        Sabonete,
    }
}
