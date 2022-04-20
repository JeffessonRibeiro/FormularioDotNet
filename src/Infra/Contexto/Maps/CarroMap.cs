using Dominio.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Contexto.Maps
{
    public class CarroMap : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.ToTable("Mesas");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Modelo).IsRequired().HasColumnType("Varchar(25)");
            builder.Property(c => c.QuantidadePortas).HasColumnType("int");
            builder.Property(c => c.Ano).IsRequired().HasColumnType("int");
            builder.Property(c => c.Marca).IsRequired().HasColumnType("Varchar(25)");


        }
    }
}
