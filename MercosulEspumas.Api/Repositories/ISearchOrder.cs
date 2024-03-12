using MercosulEspumas.Api.Models;

namespace MercosulEspumas.Api.Repositories
{
    public interface ISearchOrder
    {
        Task<NeoAssistModel> SearchOrder(string order);
    }
}
