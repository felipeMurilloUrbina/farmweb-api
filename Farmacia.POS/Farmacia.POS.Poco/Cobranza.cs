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

    // Cobranzas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class Cobranza
    {
        public int Id { get; set; } // Id (Primary key)
        public int ClienteId { get; set; } // ClienteId (Primary key)
        public int EmpresaId { get; set; } // EmpresaId (Primary key)
        public int SucursalId { get; set; } // SucursalId (Primary key)
        public string UsuarioCreadorId { get; set; } // UsuarioCreadorId (length: 128)
        public string UsuarioModificadorId { get; set; } // UsuarioModificadorId (length: 128)
        public decimal SaldoActual { get; set; } // SaldoActual (Primary key)
        public bool Activo { get; set; } // Activo (Primary key)
        public System.DateTime Fecha { get; set; } // Fecha (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent Cliente pointed by [Cobranzas].([ClienteId]) (FK_Cobranzas_Clientes)
        /// </summary>
        public virtual Cliente Cliente { get; set; } // FK_Cobranzas_Clientes

        /// <summary>
        /// Parent Empresa pointed by [Cobranzas].([EmpresaId]) (FK_Cobranzas_Empresas)
        /// </summary>
        public virtual Empresa Empresa { get; set; } // FK_Cobranzas_Empresas

        /// <summary>
        /// Parent Sucursale pointed by [Cobranzas].([SucursalId]) (FK_Cobranzas_Sucursales)
        /// </summary>
        public virtual Sucursale Sucursale { get; set; } // FK_Cobranzas_Sucursales

        public Cobranza()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
