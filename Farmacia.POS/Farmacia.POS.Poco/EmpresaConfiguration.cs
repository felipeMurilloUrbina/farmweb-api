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

    // Empresas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class EmpresaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Empresa>
    {
        public EmpresaConfiguration()
            : this("dbo")
        {
        }

        public EmpresaConfiguration(string schema)
        {
            ToTable("Empresas", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TipoPlanId).HasColumnName(@"TipoPlanId").HasColumnType("int").IsRequired();
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Avatar).HasColumnName(@"Avatar").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsOptional();
            Property(x => x.Activo).HasColumnName(@"Activo").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.Plane).WithMany(b => b.Empresas).HasForeignKey(c => c.TipoPlanId).WillCascadeOnDelete(false); // FK_Empresas_Planes
        }
    }

}
// </auto-generated>