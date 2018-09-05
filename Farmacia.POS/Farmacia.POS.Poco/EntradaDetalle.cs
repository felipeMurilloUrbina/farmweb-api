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

    // EntradaDetalles
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class EntradaDetalle
    {
        public int EntradaId { get; set; } // EntradaId (Primary key)
        public int ProductoId { get; set; } // ProductoId (Primary key)
        public decimal Cantidad { get; set; } // Cantidad (Primary key)
        public decimal Costo { get; set; } // Costo (Primary key)
        public decimal Costo1 { get; set; } // Costo1 (Primary key)
        public decimal Iva { get; set; } // Iva (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent Entrada pointed by [EntradaDetalles].([EntradaId]) (FK_EntradaDetalles_Entradas)
        /// </summary>
        public virtual Entrada Entrada { get; set; } // FK_EntradaDetalles_Entradas

        /// <summary>
        /// Parent Producto pointed by [EntradaDetalles].([ProductoId]) (FK_EntradaDetalles_Productos)
        /// </summary>
        public virtual Producto Producto { get; set; } // FK_EntradaDetalles_Productos

        public EntradaDetalle()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>