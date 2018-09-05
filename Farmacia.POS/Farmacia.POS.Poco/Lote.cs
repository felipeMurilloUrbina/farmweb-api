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

    // Lotes
    ///<summary>
    /// Catalogo
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class Lote
    {
        public int Id { get; set; } // Id (Primary key)
        public int EmpresaId { get; set; } // EmpresaId

        ///<summary>
        /// Codigo
        ///</summary>
        public string Codigo { get; set; } // Codigo (length: 50)

        ///<summary>
        /// Descripcion
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 300)
        public bool Activo { get; set; } // Activo

        ///<summary>
        /// Fecha
        ///</summary>
        public System.DateTime Fecha { get; set; } // Fecha

        public Lote()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
