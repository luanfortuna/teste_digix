namespace ProdutoVendaFamiliasDomain.Entidades
{
    public class Familia
    {
        public string? Pretendente { get; set; }
        public string? Conjuje { get; set; }
        public long Renda { get; set; }
        public List<Pessoa>? Dependentes { get; set; }
        public int Pontuacao { get; set; }
    }
}
