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

    // Productos
    ///<summary>
    /// Catalogo
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public partial class Producto
    {
        public int Id { get; set; } // Id (Primary key)
        public int EmpresaId { get; set; } // EmpresaId
        public int? CategoriaId { get; set; } // CategoriaId
        public int? LineaId { get; set; } // LineaId
        public int? ProveedorId { get; set; } // ProveedorId
        public int? MonedaId { get; set; } // MonedaId

        ///<summary>
        /// @Encabezado:Si@Label:Codigo de Barras@Capturable:Si
        ///</summary>
        public string Codigo { get; set; } // Codigo (length: 50)

        ///<summary>
        /// @Encabezado:Si@Label:Descripcion@Capturable:Si
        ///</summary>
        public byte[] Descripcion { get; set; } // Descripcion (length: 300)

        ///<summary>
        /// @Encabezado:No@Label:Precio@Capturable:Si
        ///</summary>
        public decimal Precio { get; set; } // Precio

        ///<summary>
        /// @Encabezado:No@Label:Precio1@Capturable:Si
        ///</summary>
        public decimal Precio1 { get; set; } // Precio1

        ///<summary>
        /// @Encabezado:No@Label:Precio2@Capturable:Si
        ///</summary>
        public decimal Precio2 { get; set; } // Precio2

        ///<summary>
        /// @Encabezado:No@Label:Precio3@Capturable:Si
        ///</summary>
        public decimal Precio3 { get; set; } // Precio3
        public bool Activo { get; set; } // Activo

        ///<summary>
        /// @Encabezado:Si@Label:Fecha
        ///</summary>
        public System.DateTime Fecha { get; set; } // Fecha

        ///<summary>
        /// @Encabezado:No@Label:Precio1@Capturable:No
        ///</summary>
        public string Localizacion { get; set; } // Localizacion (length: 200)

        ///<summary>
        /// @Encabezado:No@Label:Precio1@Capturable:No
        ///</summary>
        public string Observacion { get; set; } // Observacion (length: 500)

        ///<summary>
        /// @Encabezado:No@Label:Imagen@Capturable:No
        ///</summary>
        public string Imagen { get; set; } // Imagen (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child AlmacenProductoes where [AlmacenProductos].[ProductoId] point to this entity (FK_AlmacenProductos_Productos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<AlmacenProducto> AlmacenProductoes { get; set; } // AlmacenProductos.FK_AlmacenProductos_Productos
        /// <summary>
        /// Child EntradaDetalles where [EntradaDetalles].[ProductoId] point to this entity (FK_EntradaDetalles_Productos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<EntradaDetalle> EntradaDetalles { get; set; } // EntradaDetalles.FK_EntradaDetalles_Productos
        /// <summary>
        /// Child InventarioFisicoes where [InventarioFisicos].[ProductoId] point to this entity (FK_InventarioFisicos_Productos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<InventarioFisico> InventarioFisicoes { get; set; } // InventarioFisicos.FK_InventarioFisicos_Productos
        /// <summary>
        /// Child MaximosMinimoes where [MaximosMinimos].[ProductoId] point to this entity (FK_MaximosMinimos_Productos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<MaximosMinimo> MaximosMinimoes { get; set; } // MaximosMinimos.FK_MaximosMinimos_Productos
        /// <summary>
        /// Child Movimientoes where [Movimientos].[ProductoId] point to this entity (FK_Movimientos_Productos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Movimiento> Movimientoes { get; set; } // Movimientos.FK_Movimientos_Productos

        // Foreign keys

        /// <summary>
        /// Parent Categoria pointed by [Productos].([CategoriaId]) (FK_Productos_Categorias)
        /// </summary>
        public virtual Categoria Categoria { get; set; } // FK_Productos_Categorias

        /// <summary>
        /// Parent Empresa pointed by [Productos].([EmpresaId]) (FK_Productos_Empresas)
        /// </summary>
        public virtual Empresa Empresa { get; set; } // FK_Productos_Empresas

        /// <summary>
        /// Parent Linea pointed by [Productos].([LineaId]) (FK_Productos_Lineas)
        /// </summary>
        public virtual Linea Linea { get; set; } // FK_Productos_Lineas

        /// <summary>
        /// Parent Moneda pointed by [Productos].([MonedaId]) (FK_Productos_Monedas)
        /// </summary>
        public virtual Moneda Moneda { get; set; } // FK_Productos_Monedas

        public Producto()
        {
            AlmacenProductoes = new System.Collections.Generic.List<AlmacenProducto>();
            EntradaDetalles = new System.Collections.Generic.List<EntradaDetalle>();
            InventarioFisicoes = new System.Collections.Generic.List<InventarioFisico>();
            MaximosMinimoes = new System.Collections.Generic.List<MaximosMinimo>();
            Movimientoes = new System.Collections.Generic.List<Movimiento>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
