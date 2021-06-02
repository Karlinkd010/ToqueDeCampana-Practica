﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToqueDeCampana_Practica.Models;

namespace ToqueDeCampana_Practica.Migrations
{
    [DbContext(typeof(bd_toque_campanaV1Context))]
    partial class bd_toque_campanaV1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToqueDeCampana_Practica.Models.TblAlumno", b =>
                {
                    b.Property<int>("IdAlumnos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_alumnos")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DtFechaIngreso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smalldatetime")
                        .HasColumnName("dtFechaIngreso")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("IdCarrera2")
                        .HasColumnType("int")
                        .HasColumnName("id_carrera2");

                    b.Property<int?>("IdResidencia2")
                        .HasColumnType("int")
                        .HasColumnName("id_residencia2");

                    b.Property<int?>("IdUniversidad2")
                        .HasColumnType("int")
                        .HasColumnName("id_universidad2");

                    b.Property<int?>("IntNoExterior")
                        .HasColumnType("int")
                        .HasColumnName("intNo_exterior");

                    b.Property<int?>("IntNoInterior")
                        .HasColumnType("int")
                        .HasColumnName("intNo_interior");

                    b.Property<string>("VchApellidos")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("vchApellidos");

                    b.Property<string>("VchAvatar")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("vchAvatar");

                    b.Property<string>("VchCalle")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("vchCalle");

                    b.Property<string>("VchCorreo")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("vchCorreo");

                    b.Property<string>("VchCurp")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("vchCurp");

                    b.Property<string>("VchDisertacion")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("vchDisertacion");

                    b.Property<DateTime?>("VchFechaNac")
                        .HasColumnType("date")
                        .HasColumnName("vchFechaNac");

                    b.Property<string>("VchFoto")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("vchFoto");

                    b.Property<string>("VchGenero")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("vchGenero");

                    b.Property<string>("VchMaps")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("vchMaps");

                    b.Property<string>("VchMatricula")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("vchMatricula");

                    b.Property<string>("VchNombre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("vchNombre");

                    b.Property<int?>("VchTel1")
                        .HasColumnType("int")
                        .HasColumnName("vchTel1");

                    b.Property<int?>("VchTel2")
                        .HasColumnType("int")
                        .HasColumnName("vchTel2");

                    b.HasKey("IdAlumnos")
                        .HasName("Pk_id_alumnos");

                    b.HasIndex("IdCarrera2");

                    b.HasIndex("IdResidencia2");

                    b.HasIndex("IdUniversidad2");

                    b.ToTable("tblAlumnos");
                });

            modelBuilder.Entity("ToqueDeCampana_Practica.Models.TblCarrera", b =>
                {
                    b.Property<int>("IdCarrera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_carrera")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("BtEstatus")
                        .HasColumnType("bit")
                        .HasColumnName("btEstatus");

                    b.Property<int>("IdUniversidad1")
                        .HasColumnType("int")
                        .HasColumnName("id_universidad1");

                    b.Property<string>("VchCarrera")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("vchCarrera");

                    b.Property<string>("VchDescripcion")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("vchDescripcion");

                    b.Property<string>("VchSementre")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("vchSementre");

                    b.HasKey("IdCarrera")
                        .HasName("PK_id_carrera");

                    b.HasIndex("IdUniversidad1");

                    b.ToTable("tblCarrera");
                });

            modelBuilder.Entity("ToqueDeCampana_Practica.Models.TblResidencium", b =>
                {
                    b.Property<int>("IdResidencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_residencia")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VchCPostal")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("vchC_postal");

                    b.Property<string>("VchCiudad")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("vchCiudad");

                    b.Property<string>("VchEstado")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("vchEstado");

                    b.Property<string>("VchMunicipio")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("vchMunicipio");

                    b.Property<string>("VchPais")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("vchPais");

                    b.HasKey("IdResidencia")
                        .HasName("PK_id_residencia");

                    b.ToTable("tblResidencia");
                });

            modelBuilder.Entity("ToqueDeCampana_Practica.Models.TblUniversidad", b =>
                {
                    b.Property<int>("IdUniversidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_universidad")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("BtEstatus")
                        .HasColumnType("bit")
                        .HasColumnName("btEstatus");

                    b.Property<int>("IdResidencia1")
                        .HasColumnType("int")
                        .HasColumnName("id_residencia1");

                    b.Property<string>("VchTelefono")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("vchTelefono");

                    b.Property<string>("VchUniversidad")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("vchUniversidad");

                    b.Property<string>("Vchemail")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("vchemail");

                    b.HasKey("IdUniversidad");

                    b.HasIndex("IdResidencia1");

                    b.ToTable("tblUniversidad");
                });

            modelBuilder.Entity("ToqueDeCampana_Practica.Models.Tblusuario", b =>
                {
                    b.Property<int>("IntIdusuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("intIdusuario")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VchPassword")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("vchPassword");

                    b.Property<string>("VchUsuario")
                        .HasMaxLength(22)
                        .IsUnicode(false)
                        .HasColumnType("varchar(22)")
                        .HasColumnName("vchUsuario");

                    b.HasKey("IntIdusuario");

                    b.ToTable("tblusuario");
                });

            modelBuilder.Entity("ToqueDeCampana_Practica.Models.TblAlumno", b =>
                {
                    b.HasOne("ToqueDeCampana_Practica.Models.TblCarrera", "IdCarrera2Navigation")
                        .WithMany("TblAlumnos")
                        .HasForeignKey("IdCarrera2")
                        .HasConstraintName("FK_tbl_Carrera2");

                    b.HasOne("ToqueDeCampana_Practica.Models.TblResidencium", "IdResidencia2Navigation")
                        .WithMany("TblAlumnos")
                        .HasForeignKey("IdResidencia2")
                        .HasConstraintName("FK_tbl_residencia1");

                    b.HasOne("ToqueDeCampana_Practica.Models.TblUniversidad", "IdUniversidad2Navigation")
                        .WithMany("TblAlumnos")
                        .HasForeignKey("IdUniversidad2")
                        .HasConstraintName("FK_tbl_universidad2");

                    b.Navigation("IdCarrera2Navigation");

                    b.Navigation("IdResidencia2Navigation");

                    b.Navigation("IdUniversidad2Navigation");
                });

            modelBuilder.Entity("ToqueDeCampana_Practica.Models.TblCarrera", b =>
                {
                    b.HasOne("ToqueDeCampana_Practica.Models.TblUniversidad", "IdUniversidad1Navigation")
                        .WithMany("TblCarreras")
                        .HasForeignKey("IdUniversidad1")
                        .HasConstraintName("FK_tbl_universidad1")
                        .IsRequired();

                    b.Navigation("IdUniversidad1Navigation");
                });

            modelBuilder.Entity("ToqueDeCampana_Practica.Models.TblUniversidad", b =>
                {
                    b.HasOne("ToqueDeCampana_Practica.Models.TblResidencium", "IdResidencia1Navigation")
                        .WithMany("TblUniversidads")
                        .HasForeignKey("IdResidencia1")
                        .HasConstraintName("FK_tbl_residencia")
                        .IsRequired();

                    b.Navigation("IdResidencia1Navigation");
                });

            modelBuilder.Entity("ToqueDeCampana_Practica.Models.TblCarrera", b =>
                {
                    b.Navigation("TblAlumnos");
                });

            modelBuilder.Entity("ToqueDeCampana_Practica.Models.TblResidencium", b =>
                {
                    b.Navigation("TblAlumnos");

                    b.Navigation("TblUniversidads");
                });

            modelBuilder.Entity("ToqueDeCampana_Practica.Models.TblUniversidad", b =>
                {
                    b.Navigation("TblAlumnos");

                    b.Navigation("TblCarreras");
                });
#pragma warning restore 612, 618
        }
    }
}