using ProdutoVendaFamiliasDomain.Entidades;
using ProdutoVendaFamiliasService.Services;

namespace ProdutoVendaFamilias
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var listaFamilias = new List<Familia>()
            { new Familia()
            { Pretendente = "Giovane",
                Renda = 901,
                Dependentes = new List<Pessoa>() { new Pessoa() { Idade = 42, Nome = "Mariana" } }
            },
              new Familia()
            { Pretendente = "Luan",
              Renda = 500,
              Dependentes = new List<Pessoa>() { new Pessoa() { Idade = 16, Nome = "Marcos" } }
            },
              new Familia()
            { Pretendente = "Renan",
              Renda = 1500,
              Dependentes = new List<Pessoa>() { new Pessoa() { Idade = 21, Nome = "Cecilia" } }
            }

            };


            var service = new ProdutoService();

            var result = service.ProdutoCasaPopularZ(listaFamilias);

            foreach (var familia in result)
            {
                Console.WriteLine(@"Pretendente : {0}, Prontuação: {1}  ", familia.Pretendente, familia.Pontuacao);

            }

        }
    }
}