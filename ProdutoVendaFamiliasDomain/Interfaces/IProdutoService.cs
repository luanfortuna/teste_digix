using ProdutoVendaFamiliasDomain.Entidades;

namespace ProdutoVendaFamiliasDomain.Interfaces
{
    public interface IProdutoService
    {
        List<Familia> ProdutoCasaPopularZ(List<Familia> Concorrentes);
    }
}
