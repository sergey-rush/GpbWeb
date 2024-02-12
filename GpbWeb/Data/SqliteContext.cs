using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Common;
using GpbWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GpbWeb.Data;
public class SqliteContext : DbContext
{
    public DbSet<StorageFile> StorageFiles { get; set; }
    public DbSet<OrganizationDocumentGroup> OrganizationDocumentGroups { get; set; }
    public DbSet<OrganizationDocument> OrganizationDocuments { get; set; }

    public SqliteContext() : base()
    {
        //DbContextOptions<SqliteContext> options
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Filename=data.bin");
    }

    public SqliteContext(DbContextOptions<SqliteContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Core Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Core Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        // Move Identity to "public" Schema:
        builder.Entity<OrganizationDocument>().ToTable("docs");
        builder.Entity<OrganizationDocumentGroup>().ToTable("doc_groups");
        builder.Entity<StorageFile>().ToTable("storage_files");

        // Apply Snake Case Names for Properties:
        //ApplySnakeCaseNames(builder);
    }

    //public static DbConnection GetConnection()
    //{
    //    var connection = ConfigurationManager.ConnectionStrings["SQLiteConnection"];
    //    var factory = DbProviderFactories.GetFactory(connection.ProviderName);
    //    var dbCon = factory.CreateConnection();
    //    dbCon.ConnectionString = connection.ConnectionString;
    //    return dbCon;
    //}

    //private void ApplySnakeCaseNames(ModelBuilder modelBuilder)
    //{
    //    var mapper = new Transl NpgsqlSnakeCaseNameTranslator();

    //    foreach (var entity in modelBuilder.Model.GetEntityTypes())
    //    {
    //        foreach (IMutableProperty property in entity.GetProperties())
    //        {
    //            var npgsqlColumnName = mapper.TranslateMemberName(property.GetColumnName());

    //            property.SetColumnName(npgsqlColumnName);
    //        }
    //    }
    //}
}