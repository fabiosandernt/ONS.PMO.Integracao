using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class FonteOrigemMapping : IEntityTypeConfiguration<FonteOrigem>
    {
        public void Configure(EntityTypeBuilder<FonteOrigem> entity)
        {
            entity.HasKey(e => e.IdFonteorigem).HasName("pk_tb_fonteorigem");

            entity.ToTable("tb_fonteorigem");

            entity.Property(e => e.IdFonteorigem).HasColumnName("id_fonteorigem");
            entity.Property(e => e.FlgEletrica).HasColumnName("flg_eletrica");
            entity.Property(e => e.FlgHidraulica).HasColumnName("flg_hidraulica");
            entity.Property(e => e.NomFonteorigem)
                .HasMaxLength(20)
                .HasColumnName("nom_fonteorigem");
        }
    }
}
