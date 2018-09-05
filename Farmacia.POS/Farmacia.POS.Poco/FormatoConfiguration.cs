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

    // Formatos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class FormatoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Formato>
    {
        public FormatoConfiguration()
            : this("dbo")
        {
        }

        public FormatoConfiguration(string schema)
        {
            ToTable("Formatos", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.ImagenMiniatura).HasColumnName(@"ImagenMiniatura").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(400);
            Property(x => x.NombreFormato).HasColumnName(@"NombreFormato").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Activo).HasColumnName(@"Activo").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>