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

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Contexto : System.Data.Entity.DbContext, IContexto
    {
        public System.Data.Entity.DbSet<Almacene> Almacenes { get; set; } // Almacenes
        public System.Data.Entity.DbSet<AlmacenProducto> AlmacenProductoes { get; set; } // AlmacenProductos
        public System.Data.Entity.DbSet<Categoria> Categorias { get; set; } // Categorias
        public System.Data.Entity.DbSet<Cliente> Clientes { get; set; } // Clientes
        public System.Data.Entity.DbSet<Empresa> Empresas { get; set; } // Empresas
        public System.Data.Entity.DbSet<Entrada> Entradas { get; set; } // Entradas
        public System.Data.Entity.DbSet<EntradaDetalle> EntradaDetalles { get; set; } // EntradaDetalles
        public System.Data.Entity.DbSet<Formato> Formatoes { get; set; } // Formatos
        public System.Data.Entity.DbSet<Linea> Lineas { get; set; } // Lineas
        public System.Data.Entity.DbSet<Lote> Lotes { get; set; } // Lotes
        public System.Data.Entity.DbSet<Plane> Planes { get; set; } // Planes
        public System.Data.Entity.DbSet<Producto> Productoes { get; set; } // Productos
        public System.Data.Entity.DbSet<Sucursale> Sucursales { get; set; } // Sucursales
        public System.Data.Entity.DbSet<TiposMovimiento> TiposMovimientoes { get; set; } // TiposMovimiento

        static Contexto()
        {
            System.Data.Entity.Database.SetInitializer<Contexto>(null);
        }

        public Contexto()
            : base("Name=DefaultConnection")
        {
        }

        public Contexto(string connectionString)
            : base(connectionString)
        {
        }

        public Contexto(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public Contexto(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public Contexto(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AlmaceneConfiguration());
            modelBuilder.Configurations.Add(new AlmacenProductoConfiguration());
            modelBuilder.Configurations.Add(new CategoriaConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EmpresaConfiguration());
            modelBuilder.Configurations.Add(new EntradaConfiguration());
            modelBuilder.Configurations.Add(new EntradaDetalleConfiguration());
            modelBuilder.Configurations.Add(new FormatoConfiguration());
            modelBuilder.Configurations.Add(new LineaConfiguration());
            modelBuilder.Configurations.Add(new LoteConfiguration());
            modelBuilder.Configurations.Add(new PlaneConfiguration());
            modelBuilder.Configurations.Add(new ProductoConfiguration());
            modelBuilder.Configurations.Add(new SucursaleConfiguration());
            modelBuilder.Configurations.Add(new TiposMovimientoConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AlmaceneConfiguration(schema));
            modelBuilder.Configurations.Add(new AlmacenProductoConfiguration(schema));
            modelBuilder.Configurations.Add(new CategoriaConfiguration(schema));
            modelBuilder.Configurations.Add(new ClienteConfiguration(schema));
            modelBuilder.Configurations.Add(new EmpresaConfiguration(schema));
            modelBuilder.Configurations.Add(new EntradaConfiguration(schema));
            modelBuilder.Configurations.Add(new EntradaDetalleConfiguration(schema));
            modelBuilder.Configurations.Add(new FormatoConfiguration(schema));
            modelBuilder.Configurations.Add(new LineaConfiguration(schema));
            modelBuilder.Configurations.Add(new LoteConfiguration(schema));
            modelBuilder.Configurations.Add(new PlaneConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductoConfiguration(schema));
            modelBuilder.Configurations.Add(new SucursaleConfiguration(schema));
            modelBuilder.Configurations.Add(new TiposMovimientoConfiguration(schema));
            return modelBuilder;
        }
    }
}
// </auto-generated>
