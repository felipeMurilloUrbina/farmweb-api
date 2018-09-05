// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 1.4
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace Farmacia.POS.Model
{
    using Farmacia.POS.Model;

    // Sucursales
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SucursaleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sucursale>
    {
        public SucursaleConfiguration()
            : this("dbo")
        {
        }

        public SucursaleConfiguration(string schema)
        {
            ToTable("Sucursales", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EmpresaId).HasColumnName(@"EmpresaId").HasColumnType("int").IsRequired();
            Property(x => x.FormatoId).HasColumnName(@"FormatoId").HasColumnType("int").IsOptional();
            Property(x => x.UsuarioCreadorId).HasColumnName(@"UsuarioCreadorId").HasColumnType("int").IsRequired();
            Property(x => x.UsuarioModificadorId).HasColumnName(@"UsuarioModificadorId").HasColumnType("int").IsRequired();
            Property(x => x.AlmacenPrincipalId).HasColumnName(@"AlmacenPrincipalId").HasColumnType("int").IsOptional();
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(300);
            Property(x => x.NombreComercial).HasColumnName(@"NombreComercial").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Rfc).HasColumnName(@"Rfc").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Serie).HasColumnName(@"Serie").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Calle).HasColumnName(@"Calle").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Colonia).HasColumnName(@"Colonia").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ciudad).HasColumnName(@"Ciudad").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CodigoPostal).HasColumnName(@"CodigoPostal").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Municipio).HasColumnName(@"Municipio").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Estado).HasColumnName(@"Estado").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Pais).HasColumnName(@"Pais").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Telefono).HasColumnName(@"Telefono").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Celular).HasColumnName(@"Celular").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.RutaCer).HasColumnName(@"RutaCer").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.RutaKey).HasColumnName(@"RutaKey").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.ClavePrivada).HasColumnName(@"ClavePrivada").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Logo).HasColumnName(@"Logo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(160);
            Property(x => x.MensajeComercial).HasColumnName(@"MensajeComercial").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Activo).HasColumnName(@"Activo").HasColumnType("bit").IsRequired();
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.ColorReporte).HasColumnName(@"ColorReporte").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Asunto).HasColumnName(@"Asunto").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Mensaje).HasColumnName(@"Mensaje").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);

            // Foreign keys
            HasOptional(a => a.Formato).WithMany(b => b.Sucursales).HasForeignKey(c => c.FormatoId).WillCascadeOnDelete(false); // FK_Sucursales_Formatos
            HasRequired(a => a.Empresa).WithMany(b => b.Sucursales).HasForeignKey(c => c.EmpresaId).WillCascadeOnDelete(false); // FK_Sucursales_Empresas
        }
    }

}
// </auto-generated>
