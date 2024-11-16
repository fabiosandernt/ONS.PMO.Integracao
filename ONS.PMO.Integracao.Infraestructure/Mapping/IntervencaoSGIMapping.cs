using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Infraestructure.Mapping
{
    public class IntervencaoSGIMapping : IEntityTypeConfiguration<IntervencaoSGI>
    {
        public void Configure(EntityTypeBuilder<IntervencaoSGI> entity)
        {
            entity.HasKey(e => e.IdIntervencaosgi).HasName("pk_tb_intervencaosgi");

            entity.ToTable("tb_intervencaosgi");

            entity.Property(e => e.IdIntervencaosgi).HasColumnName("id_intervencaosgi");
            entity.Property(e => e.DinFimprogramado)
                .HasColumnType("datetime")
                .HasColumnName("din_fimprogramado");
            entity.Property(e => e.DinInicioefetivo)
                .HasColumnType("datetime")
                .HasColumnName("din_inicioefetivo");
            entity.Property(e => e.DscIntervencaosgi)
                .HasMaxLength(150)
                .HasColumnName("dsc_intervencaosgi");
            entity.Property(e => e.DscRecomendacao)
                .HasMaxLength(350)
                .HasColumnName("dsc_recomendacao");
            entity.Property(e => e.IdAgenteinstituicao).HasColumnName("id_agenteinstituicao");
            entity.Property(e => e.IdOrigemcoletauge)
                .HasMaxLength(50)
                .HasColumnName("id_origemcoletauge");
            entity.Property(e => e.NomAgente)
                .HasMaxLength(100)
                .HasColumnName("nom_agente");
            entity.Property(e => e.NomEquipamentoprincipal)
                .HasMaxLength(50)
                .HasColumnName("nom_equipamentoprincipal");
            entity.Property(e => e.NomStatus)
                .HasMaxLength(50)
                .HasColumnName("nom_status");
            entity.Property(e => e.NomTpintervencaosgi)
                .HasMaxLength(50)
                .HasColumnName("nom_tpintervencaosgi");
            entity.Property(e => e.NumIntervencaosgi).HasColumnName("num_intervencaosgi");
        }
    }
}