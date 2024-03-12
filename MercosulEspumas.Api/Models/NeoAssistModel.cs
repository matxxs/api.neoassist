using System.ComponentModel.DataAnnotations;

namespace MercosulEspumas.Api.Models
{
    public class NeoAssistModel
    {
        public string Filial { get; set; } = null!;
        public string Emissao { get; set; } = null!;
        public string Num_orcamento { get; set; } = null!;
        public string Num_pedido { get; set; } = null!;
        public string Whats_pedido { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string Nome_cliente { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Ddd { get; set; } = null!;
        public string Telefone { get; set; } = null!;
        public string Chave_nfe { get; set; } = null!;
        public string Zd3_idjet { get; set; } = null!;
        public string Zd3_codigo { get; set; } = null!;
        [Key]
        public string Zd3_nummkt { get; set; } = null!;
    }
}
