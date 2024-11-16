using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

public class AuxUsinaMontadorMapping : IEntityTypeConfiguration<AuxUsinaMontador>
{
    public void Configure(EntityTypeBuilder<AuxUsinaMontador> entity)
    {
        entity.HasKey(e => e.IdOrigemcoletamontador).HasName("pk_tb_aux_usinamontador");

        entity.ToTable("tb_aux_usinamontador");

        entity.HasIndex(e => e.IdOrigemcoletamontador, "in_fk_origemcoletamontador_aux_usinamontador");

        entity.Property(e => e.IdOrigemcoletamontador)
            .ValueGeneratedNever()
            .HasColumnName("id_origemcoletamontador");
        entity.Property(e => e.CodDpp).HasColumnName("cod_dpp");
        entity.Property(e => e.CodRee).HasColumnName("cod_ree");
        entity.Property(e => e.CodSubsistema)
            .HasMaxLength(2)
            .IsUnicode(false)
            .IsFixedLength()
            .HasColumnName("cod_subsistema");
        entity.Property(e => e.CodTpgeracao)
            .HasMaxLength(15)
            .HasColumnName("cod_tpgeracao");
        entity.Property(e => e.IdAge)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength()
            .HasColumnName("id_age");
        entity.Property(e => e.IdOrigemcoletamontadorree)
            .HasMaxLength(50)
            .HasColumnName("id_origemcoletamontadorree");
        entity.Property(e => e.IdResjusante).HasColumnName("id_resjusante");
        entity.Property(e => e.IdTpusina)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength()
            .HasColumnName("id_tpusina");
        entity.Property(e => e.NomCurto)
            .HasMaxLength(20)
            .HasColumnName("nom_curto");
        entity.Property(e => e.NomCurtoree)
            .HasMaxLength(100)
            .HasColumnName("nom_curtoree");
        entity.Property(e => e.NomCurtosubsistema)
            .HasMaxLength(20)
            .HasColumnName("nom_curtosubsistema");
        entity.Property(e => e.NomLongo)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("nom_longo");
        entity.Property(e => e.NumRestricao).HasColumnName("num_restricao");

        entity.HasOne(d => d.IdOrigemcoletamontadorNavigation).WithOne(p => p.TbAuxUsinamontador)
            .HasForeignKey<AuxUsinaMontador>(d => d.IdOrigemcoletamontador)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_origemcoletamontador_aux_usinamontador");
    }
}
