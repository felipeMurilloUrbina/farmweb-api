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
    public partial class Formato
    {
        public int Id { get; set; } // Id (Primary key)
        public string Descripcion { get; set; } // Descripcion (length: 100)
        public string ImagenMiniatura { get; set; } // ImagenMiniatura (length: 400)
        public string NombreFormato { get; set; } // NombreFormato (length: 100)
        public bool Activo { get; set; } // Activo

        // Reverse navigation

        /// <summary>
        /// Child Sucursales where [Sucursales].[FormatoId] point to this entity (FK_Sucursales_Formatos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sucursale> Sucursales { get; set; } // Sucursales.FK_Sucursales_Formatos

        public Formato()
        {
            Sucursales = new System.Collections.Generic.List<Sucursale>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
