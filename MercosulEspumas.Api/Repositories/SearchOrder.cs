using MercosulEspumas.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace MercosulEspumas.Api.Repositories
{
    public class SearchOrder : ISearchOrder
    {
        private readonly TOTVS12Context _dbContext;
        public SearchOrder(TOTVS12Context context)
        {
            _dbContext = context;
        }

        async Task<NeoAssistModel> ISearchOrder.SearchOrder(string order)
        {
            var query = await _dbContext.VW_NEO_STATUS_PEDIDO
                 .FromSqlInterpolated($"SELECT * FROM NEO_STATUS_PEDIDO WHERE ZD3_NUMMKT= {order}").ToListAsync();

            if (query.Count == 0)
            {
                throw new Exception($"Pedido: {order}, não encontrado no banco de dados ");
            }

            var neoAssistModels = query.Select(item => new NeoAssistModel
            {
                Filial = item.Filial.Trim(),
                Emissao = item.Emissao.Trim(),
                Num_orcamento = item.Num_orcamento.Trim(),
                Num_pedido = item.Num_pedido.Trim(),
                Whats_pedido = item.Whats_pedido.Trim(),
                Cliente = item.Cliente.Trim(),
                Nome_cliente = item.Nome_cliente.Trim(),
                Email = item.Email.Trim(),
                Ddd = item.Ddd.Trim(),
                Telefone = item.Telefone.Trim(),
                Chave_nfe = item.Chave_nfe.Trim(),
                Zd3_idjet = item.Zd3_idjet.Trim(),
                Zd3_codigo = item.Zd3_codigo.Trim(),
                Zd3_nummkt = item.Zd3_nummkt.Trim(),

            }).ToList();

            return neoAssistModels.FirstOrDefault();
        }
    }
}
