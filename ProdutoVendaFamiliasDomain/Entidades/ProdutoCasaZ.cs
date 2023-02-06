namespace ProdutoVendaFamiliasDomain.Entidades
{
    public class ProdutoCasaZ
    {
        public ProdutoCasaZ(List<Familia> familiasPretendentes)
        {
            FamiliasPretendentes = familiasPretendentes;

            ObterPontuacao();
        }

        public List<Familia>? FamiliasPretendentes { get; set; }

        private ProdutoCasaZ ObterPontuacao()
        {

            foreach (var familia in FamiliasPretendentes)
            {
                familia.Pontuacao = 0;

                if (familia.Renda <= 900)
                    familia.Pontuacao += 5;
                else if (familia.Renda > 900 && familia.Renda < 1500)
                    familia.Pontuacao += 3;

                if (familia.Dependentes.Any())
                {
                    var qtdDepedentesMenores = familia.Dependentes.Where(dependente => dependente.Idade < 18).Count();

                    if (qtdDepedentesMenores >= 3)
                        familia.Pontuacao += 3;
                    else if (qtdDepedentesMenores > 0 && qtdDepedentesMenores < 3)
                        familia.Pontuacao += 2;
                }
            }

            FamiliasPretendentes = FamiliasPretendentes.OrderByDescending(x => x.Pontuacao).ToList();

            return this;
        }
    }
}
