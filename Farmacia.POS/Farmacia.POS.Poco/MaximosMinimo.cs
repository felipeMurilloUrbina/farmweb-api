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

    // MaximosMinimos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class MaximosMinimo
    {
        public int Id { get; set; } // Id (Primary key)
        public int AlmacenId { get; set; } // AlmacenId (Primary key)
        public int ProductoId { get; set; } // ProductoId (Primary key)
        public int EmpresaId { get; set; } // EmpresaId (Primary key)
        public decimal ValorMin { get; set; } // ValorMin (Primary key)
        public decimal ValorMax { get; set; } // ValorMax (Primary key)
        public bool Activo { get; set; } // Activo (Primary key)
        public System.DateTime Fecha { get; set; } // Fecha (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent Almacene pointed by [MaximosMinimos].([AlmacenId]) (FK_MaximosMinimos_Almacenes)
        /// </summary>
        public virtual Almacene Almacene { get; set; } // FK_MaximosMinimos_Almacenes

        /// <summary>
        /// Parent Empresa pointed by [MaximosMinimos].([EmpresaId]) (FK_MaximosMinimos_Empresas)
        /// </summary>
        public virtual Empresa Empresa { get; set; } // FK_MaximosMinimos_Empresas

        /// <summary>
        /// Parent Producto pointed by [MaximosMinimos].([ProductoId]) (FK_MaximosMinimos_Productos)
        /// </summary>
        public virtual Producto Producto { get; set; } // FK_MaximosMinimos_Productos

        public MaximosMinimo()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
