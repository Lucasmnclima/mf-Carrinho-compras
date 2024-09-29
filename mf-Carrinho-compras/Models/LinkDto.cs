namespace mf_Carrinho_compras.Models
{
    public class LinkDto
    {
        public int Id { get; set; }
        public string Href { get; set; } // Link
        public string Rel { get; set; } //Relacionado
        public string Metodo { get; set; } //Metodo HTTP

        public LinkDto(int id, string href, string rel, string metodo)
        {
            Id = id;
            Href = href;
            Rel = rel;
            Metodo = metodo;
        }
    }

    public class LinksHATEOS
    {
        public List<LinkDto> Links { get; set; } = new List<LinkDto>();
    }
}