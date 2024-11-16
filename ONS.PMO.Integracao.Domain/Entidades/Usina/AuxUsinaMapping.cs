﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

public class AuxUsinaMapping : IEntityTypeConfiguration<AuxUsina>
{
    public void Configure(EntityTypeBuilder<AuxUsina> entity)
    {
        entity.HasKey(e => e.IdOrigemcoleta)
                    .HasName("pk_tb_aux_usina");

        entity.ToTable("tb_aux_usina");

        entity.HasIndex(e => e.IdOrigemcoleta, "in_fk_origemcoleta_aux_usina");

        entity.Property(e => e.IdOrigemcoleta)
            .HasMaxLength(50)
            .HasColumnName("id_origemcoleta");
        entity.Property(e => e.CodDpp).HasColumnName("cod_dpp");
        entity.Property(e => e.CodSubmercado)
            .HasMaxLength(2)
            .IsUnicode(false)
            .IsFixedLength()
            .HasColumnName("cod_submercado");
        entity.Property(e => e.CodSubsistema)
            .HasMaxLength(2)
            .IsUnicode(false)
            .IsFixedLength()
            .HasColumnName("cod_subsistema");
        entity.Property(e => e.CodTpgeracao)
            .HasMaxLength(15)
            .HasColumnName("cod_tpgeracao");
        entity.Property(e => e.NomCurto)
            .HasMaxLength(50)
            .HasColumnName("nom_curto");
        entity.Property(e => e.NomLongo)
            .HasMaxLength(100)
            .HasColumnName("nom_longo");

        entity.HasOne(d => d.IdOrigemcoletaNavigation).WithOne(p => p.TbAuxUsina)
            .HasForeignKey<AuxUsina>(d => d.IdOrigemcoleta)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_origemcoleta_aux_usina");
    }
}
