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

    // InventarioFisicos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InventarioFisicoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InventarioFisico>
    {
        public InventarioFisicoConfiguration()
            : this("dbo")
        {
        }

        public InventarioFisicoConfiguration(string schema)
        {
            ToTable("InventarioFisicos", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.EmpresaId).HasColumnName(@"EmpresaId").HasColumnType("int").IsRequired();
            Property(x => x.SucursalId).HasColumnName(@"SucursalId").HasColumnType("int").IsRequired();
            Property(x => x.AlmacenId).HasColumnName(@"AlmacenId").HasColumnType("int").IsRequired();
            Property(x => x.ProductoId).HasColumnName(@"ProductoId").HasColumnType("int").IsRequired();
            Property(x => x.Serie).HasColumnName(@"Serie").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Folio).HasColumnName(@"Folio").HasColumnType("int").IsRequired();
            Property(x => x.Indice).HasColumnName(@"Indice").HasColumnType("int").IsRequired();
            Property(x => x.Cantidad).HasColumnName(@"Cantidad").HasColumnType("decimal").IsRequired().HasPrecision(18,4);
            Property(x => x.Activo).HasColumnName(@"Activo").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.Almacene).WithMany(b => b.InventarioFisicoes).HasForeignKey(c => c.AlmacenId).WillCascadeOnDelete(false); // FK_InventarioFisicos_Almacenes
            HasRequired(a => a.Empresa).WithMany(b => b.InventarioFisicoes).HasForeignKey(c => c.EmpresaId).WillCascadeOnDelete(false); // FK_InventarioFisicos_Empresas
            HasRequired(a => a.Producto).WithMany(b => b.InventarioFisicoes).HasForeignKey(c => c.ProductoId).WillCascadeOnDelete(false); // FK_InventarioFisicos_Productos
            HasRequired(a => a.Sucursale).WithMany(b => b.InventarioFisicoes).HasForeignKey(c => c.SucursalId).WillCascadeOnDelete(false); // FK_InventarioFisicos_Sucursales
        }
    }

}
// </auto-generated>