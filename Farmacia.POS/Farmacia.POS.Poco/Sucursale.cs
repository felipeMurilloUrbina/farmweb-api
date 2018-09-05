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
    ///<summary>
    /// Catalogo
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class Sucursale
    {
        public int Id { get; set; } // Id (Primary key)
        public int EmpresaId { get; set; } // EmpresaId
        public int? FormatoId { get; set; } // FormatoId
        public int UsuarioCreadorId { get; set; } // UsuarioCreadorId
        public int UsuarioModificadorId { get; set; } // UsuarioModificadorId
        public int? AlmacenPrincipalId { get; set; } // AlmacenPrincipalId

        ///<summary>
        /// Descripcion
        ///</summary>
        public string Descripcion { get; set; } // Descripcion (length: 300)

        ///<summary>
        /// NombreComercial
        ///</summary>
        public string NombreComercial { get; set; } // NombreComercial (length: 100)

        ///<summary>
        /// RFC
        ///</summary>
        public string Rfc { get; set; } // Rfc (length: 100)
        public string Serie { get; set; } // Serie (length: 50)
        public string Calle { get; set; } // Calle (length: 300)
        public string Colonia { get; set; } // Colonia (length: 50)
        public string Ciudad { get; set; } // Ciudad (length: 50)
        public string CodigoPostal { get; set; } // CodigoPostal (length: 50)

        ///<summary>
        /// Municipio
        ///</summary>
        public string Municipio { get; set; } // Municipio (length: 100)
        public string Estado { get; set; } // Estado (length: 100)
        public string Pais { get; set; } // Pais (length: 100)
        public string Telefono { get; set; } // Telefono (length: 50)
        public string Celular { get; set; } // Celular (length: 50)
        public string RutaCer { get; set; } // RutaCer (length: 100)
        public string RutaKey { get; set; } // RutaKey (length: 100)
        public string ClavePrivada { get; set; } // ClavePrivada (length: 100)
        public string Logo { get; set; } // Logo (length: 160)
        public string MensajeComercial { get; set; } // MensajeComercial (length: 100)
        public bool Activo { get; set; } // Activo
        public System.DateTime Fecha { get; set; } // Fecha
        public string ColorReporte { get; set; } // ColorReporte (length: 50)
        public string Asunto { get; set; } // Asunto
        public string Mensaje { get; set; } // Mensaje

        // Reverse navigation

        /// <summary>
        /// Child Almacenes where [Almacenes].[SucursalId] point to this entity (FK_Almacenes_Sucursales)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Almacene> Almacenes { get; set; } // Almacenes.FK_Almacenes_Sucursales

        // Foreign keys

        /// <summary>
        /// Parent Empresa pointed by [Sucursales].([EmpresaId]) (FK_Sucursales_Empresas)
        /// </summary>
        public virtual Empresa Empresa { get; set; } // FK_Sucursales_Empresas

        /// <summary>
        /// Parent Formato pointed by [Sucursales].([FormatoId]) (FK_Sucursales_Formatos)
        /// </summary>
        public virtual Formato Formato { get; set; } // FK_Sucursales_Formatos

        public Sucursale()
        {
            Almacenes = new System.Collections.Generic.List<Almacene>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>