using MercosulEspumas.Api.Models;
using MercosulEspumas.Api.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace MercosulEspumas.Api.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class NeoAssistController : ControllerBase
    {
        private readonly ISearchOrder _searchOrder;
        public NeoAssistController(ISearchOrder searchOrder)
        {
            _searchOrder = searchOrder;
        }

        [HttpGet]
        [Route("neoassist-pedido/{pedido}")]
        [Authorize(Roles = "neoassist,TI")]
        public async Task<ActionResult<List<NeoAssistModel>>> GetOrder(string pedido)
        {
            if (pedido.Length != 16 || !Regex.IsMatch(pedido, @"^\d{13}-\d{2}$"))
            {
                throw new Exception("Número de pedido inválido. Deve ter 16 caracteres e seguir o formato XXXXXXXXXXXXX-XX.");
            }

            NeoAssistModel numOrder = await _searchOrder.SearchOrder(pedido);
            return Ok(numOrder);
        }
    }
}
