using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntityConfig
{
    public class TBUsuarioMap : IEntityTypeConfiguration<TBUsuario>
    {
        public void Configure(EntityTypeBuilder<TBUsuario> entity)
        {
            // Primary Key
            entity.HasKey(t => t.CODUSUARIO);


            // Table & Column Mappings
            entity.ToTable("TBUsuario");
            entity.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            entity.Property(t => t.NMUSUARIO).HasColumnName("NMUSUARIO");
            entity.Property(t => t.LOGIN).HasColumnName("LOGIN");
            entity.Property(t => t.SENHA).HasColumnName("SENHA");
            entity.Property(t => t.dtNascimento).HasColumnName("dtNascimento");
            entity.Property(t => t.dtCadastro).HasColumnName("dtCadastro");
            entity.Property(t => t.CPF).HasColumnName("CPF");
            entity.Property(t => t.EMAIL).HasColumnName("EMAIL");
            entity.Property(t => t.ATIVO).HasColumnName("ATIVO");

        }
    }
}