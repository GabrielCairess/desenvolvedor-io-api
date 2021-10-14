using AppMvcBasica.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("VARCHAR(200)");

            builder.Property(p => p.Descricao)
               .IsRequired()
               .HasColumnType("VARCHAR(100)");

            builder.Property(p => p.Imagem)
               .IsRequired()
               .HasColumnType("VARCHAR(100)");

            builder.ToTable("PRODUTOS");
        }
    }
}
