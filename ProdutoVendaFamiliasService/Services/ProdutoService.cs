using ProdutoVendaFamiliasDomain.Entidades;
using ProdutoVendaFamiliasDomain.Interfaces;

namespace ProdutoVendaFamiliasService.Services
{
    public class ProdutoService : IProdutoService
    {
        public ProdutoService()
        {

        }

        public List<Familia> ProdutoCasaPopularZ(List<Familia> Concorrentes)
        {
            ProdutoCasaZ Produto = new(Concorrentes);

            return Produto.FamiliasPretendentes ?? new List<Familia>();
        }
    }
}
