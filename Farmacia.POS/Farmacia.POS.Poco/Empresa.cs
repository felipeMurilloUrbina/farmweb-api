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
    ///<summary>
    /// Catalogo
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class Empresa
    {
        public int Id { get; set; } // Id (Primary key)
        public int TipoPlanId { get; set; } // TipoPlanId
        public string Descripcion { get; set; } // Descripcion (length: 300)
        public string Avatar { get; set; } // Avatar
        public System.DateTime? Fecha { get; set; } // Fecha
        public bool Activo { get; set; } // Activo

        // Reverse navigation

        /// <summary>
        /// Child Almacenes where [Almacenes].[SucursalId] point to this entity (FK_Almacenes_Empresas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Almacene> Almacenes { get; set; } // Almacenes.FK_Almacenes_Empresas
        /// <summary>
        /// Child Categorias where [Categorias].[EmpresaId] point to this entity (FK_Categorias_Empresas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Categoria> Categorias { get; set; } // Categorias.FK_Categorias_Empresas
        /// <summary>
        /// Child Clientes where [Clientes].[EmpresaId] point to this entity (FK_Clientes_Empresas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Cliente> Clientes { get; set; } // Clientes.FK_Clientes_Empresas
        /// <summary>
        /// Child Entradas where [Entradas].[EmpresaId] point to this entity (FK_Entradas_Empresas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Entrada> Entradas { get; set; } // Entradas.FK_Entradas_Empresas
        /// <summary>
        /// Child Lineas where [Lineas].[EmpresaId] point to this entity (FK_Lineas_Empresas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Linea> Lineas { get; set; } // Lineas.FK_Lineas_Empresas
        /// <summary>
        /// Child Productoes where [Productos].[EmpresaId] point to this entity (FK_Productos_Empresas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Producto> Productoes { get; set; } // Productos.FK_Productos_Empresas
        /// <summary>
        /// Child Sucursales where [Sucursales].[EmpresaId] point to this entity (FK_Sucursales_Empresas)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sucursale> Sucursales { get; set; } // Sucursales.FK_Sucursales_Empresas

        // Foreign keys

        /// <summary>
        /// Parent Plane pointed by [Empresas].([TipoPlanId]) (FK_Empresas_Planes)
        /// </summary>
        public virtual Plane Plane { get; set; } // FK_Empresas_Planes

        public Empresa()
        {
            Almacenes = new System.Collections.Generic.List<Almacene>();
            Categorias = new System.Collections.Generic.List<Categoria>();
            Clientes = new System.Collections.Generic.List<Cliente>();
            Entradas = new System.Collections.Generic.List<Entrada>();
            Lineas = new System.Collections.Generic.List<Linea>();
            Productoes = new System.Collections.Generic.List<Producto>();
            Sucursales = new System.Collections.Generic.List<Sucursale>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
