using MercosulEspumas.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace MercosulEspumas.Api.TOTVS12
{
    public partial class TOTVS12Context : DbContext
    {
        public TOTVS12Context(DbContextOptions<TOTVS12Context> options)
            : base(options)
        {
            VW_NEO_STATUS_PEDIDO = Set<NeoAssistModel>();
        }

        public virtual DbSet<NeoAssistModel> VW_NEO_STATUS_PEDIDO { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DataBase");
            }
        }
    }
}
