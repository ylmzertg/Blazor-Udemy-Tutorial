using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MiPrimeraaplicacionusandoBlazor.Server.Models
{
    public partial class BDBibliotecaContext : DbContext
    {
        public BDBibliotecaContext()
        {
        }

        public BDBibliotecaContext(DbContextOptions<BDBibliotecaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autors { get; set; }
        public virtual DbSet<Button> Buttons { get; set; }
        public virtual DbSet<DetalleReserva> DetalleReservas { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }
        public virtual DbSet<Pagina> Paginas { get; set; }
        public virtual DbSet<PaginaTipoUsuButton> PaginaTipoUsuButtons { get; set; }
        public virtual DbSet<PaginaTipoUsuario> PaginaTipoUsuarios { get; set; }
        public virtual DbSet<Pai> Pais { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<ReservaEstado> ReservaEstados { get; set; }
        public virtual DbSet<ReservaHistorial> ReservaHistorials { get; set; }
        public virtual DbSet<Sexo> Sexos { get; set; }
        public virtual DbSet<TipoLibro> TipoLibros { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-PTIBPG6\\SQLEXPRESS;database=BDBiblioteca;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(e => e.Iidautor)
                    .HasName("PK_Autors");

                entity.ToTable("Autor");

                entity.Property(e => e.Iidautor).HasColumnName("IIDAUTOR");

                entity.Property(e => e.Apmaterno)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("APMATERNO");

                entity.Property(e => e.Appaterno)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("APPATERNO");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Iidpais).HasColumnName("IIDPAIS");

                entity.Property(e => e.Iidsexo).HasColumnName("IIDSEXO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.HasOne(d => d.IidpaisNavigation)
                    .WithMany(p => p.Autors)
                    .HasForeignKey(d => d.Iidpais)
                    .HasConstraintName("FK__Autor__IIDPAIS__4BAC3F29");

                entity.HasOne(d => d.IidsexoNavigation)
                    .WithMany(p => p.Autors)
                    .HasForeignKey(d => d.Iidsexo)
                    .HasConstraintName("FK__Autor__IIDSEXO__4AB81AF0");
            });

            modelBuilder.Entity<Button>(entity =>
            {
                entity.HasKey(e => e.Iidbutton);

                entity.ToTable("Button");

                entity.Property(e => e.Iidbutton).HasColumnName("IIDBUTTON");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Nombrebutton)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBREBUTTON");
            });

            modelBuilder.Entity<DetalleReserva>(entity =>
            {
                entity.HasKey(e => e.Iiddetallereserva);

                entity.ToTable("DetalleReserva");

                entity.Property(e => e.Iiddetallereserva).HasColumnName("IIDDETALLERESERVA");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Iidlibro).HasColumnName("IIDLIBRO");

                entity.Property(e => e.Iidreserva).HasColumnName("IIDRESERVA");

                entity.HasOne(d => d.IidlibroNavigation)
                    .WithMany(p => p.DetalleReservas)
                    .HasForeignKey(d => d.Iidlibro)
                    .HasConstraintName("FK__DetalleRe__IIDLI__3B75D760");

                entity.HasOne(d => d.IidreservaNavigation)
                    .WithMany(p => p.DetalleReservas)
                    .HasForeignKey(d => d.Iidreserva)
                    .HasConstraintName("FK__DetalleRe__IIDRE__3A81B327");
            });

            modelBuilder.Entity<Libro>(entity =>
            {
                entity.HasKey(e => e.Iidlibro)
                    .HasName("PK_Libros");

                entity.ToTable("Libro");

                entity.Property(e => e.Iidlibro).HasColumnName("IIDLIBRO");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Fotocaratula)
                    .IsUnicode(false)
                    .HasColumnName("FOTOCARATULA");

                entity.Property(e => e.Iidautor).HasColumnName("IIDAUTOR");

                entity.Property(e => e.Libropdf)
                    .IsUnicode(false)
                    .HasColumnName("LIBROPDF");

                entity.Property(e => e.Numpaginas).HasColumnName("NUMPAGINAS");

                entity.Property(e => e.Resumen)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("RESUMEN");

                entity.Property(e => e.Stock).HasColumnName("STOCK");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TITULO");

                entity.HasOne(d => d.IidautorNavigation)
                    .WithMany(p => p.Libros)
                    .HasForeignKey(d => d.Iidautor)
                    .HasConstraintName("FK__Libro__IIDAUTOR__5FB337D6");
            });

            modelBuilder.Entity<Pagina>(entity =>
            {
                entity.HasKey(e => e.Iidpagina)
                    .HasName("PK_Paginas");

                entity.ToTable("Pagina");

                entity.Property(e => e.Iidpagina).HasColumnName("IIDPAGINA");

                entity.Property(e => e.Accion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACCION");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Bvisible).HasColumnName("BVISIBLE");

                entity.Property(e => e.Mensaje)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MENSAJE");
            });

            modelBuilder.Entity<PaginaTipoUsuButton>(entity =>
            {
                entity.HasKey(e => e.Iidpaginatipousubutton);

                entity.ToTable("PaginaTipoUsuButton");

                entity.Property(e => e.Iidpaginatipousubutton).HasColumnName("IIDPAGINATIPOUSUBUTTON");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Iidbutton).HasColumnName("IIDBUTTON");

                entity.Property(e => e.Iidpaginatipousuario).HasColumnName("IIDPAGINATIPOUSUARIO");

                entity.HasOne(d => d.IidbuttonNavigation)
                    .WithMany(p => p.PaginaTipoUsuButtons)
                    .HasForeignKey(d => d.Iidbutton)
                    .HasConstraintName("FK__PaginaTip__IIDBU__72C60C4A");

                entity.HasOne(d => d.IidpaginatipousuarioNavigation)
                    .WithMany(p => p.PaginaTipoUsuButtons)
                    .HasForeignKey(d => d.Iidpaginatipousuario)
                    .HasConstraintName("FK__PaginaTip__IIDPA__71D1E811");
            });

            modelBuilder.Entity<PaginaTipoUsuario>(entity =>
            {
                entity.HasKey(e => e.Iidpaginatipousuario);

                entity.ToTable("PaginaTipoUsuario");

                entity.Property(e => e.Iidpaginatipousuario).HasColumnName("IIDPAGINATIPOUSUARIO");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Iidpagina).HasColumnName("IIDPAGINA");

                entity.Property(e => e.Iidtipousuario).HasColumnName("IIDTIPOUSUARIO");

                entity.HasOne(d => d.IidpaginaNavigation)
                    .WithMany(p => p.PaginaTipoUsuarios)
                    .HasForeignKey(d => d.Iidpagina)
                    .HasConstraintName("FK__PaginaTip__IIDPA__145C0A3F");

                entity.HasOne(d => d.IidtipousuarioNavigation)
                    .WithMany(p => p.PaginaTipoUsuarios)
                    .HasForeignKey(d => d.Iidtipousuario)
                    .HasConstraintName("FK__PaginaTip__IIDTI__15502E78");
            });

            modelBuilder.Entity<Pai>(entity =>
            {
                entity.HasKey(e => e.Iidpais);

                entity.Property(e => e.Iidpais).HasColumnName("IIDPAIS");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.Iidpersona);

                entity.ToTable("Persona");

                entity.Property(e => e.Iidpersona).HasColumnName("IIDPERSONA");

                entity.Property(e => e.Apmaterno)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("APMATERNO");

                entity.Property(e => e.Appaterno)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("APPATERNO");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Btieneusuario).HasColumnName("BTIENEUSUARIO");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CORREO");

                entity.Property(e => e.Fechanacimiento)
                    .HasColumnType("date")
                    .HasColumnName("FECHANACIMIENTO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.Iidreserva);

                entity.ToTable("Reserva");

                entity.Property(e => e.Iidreserva).HasColumnName("IIDRESERVA");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Dfechafinreserva)
                    .HasColumnType("datetime")
                    .HasColumnName("DFECHAFINRESERVA");

                entity.Property(e => e.Dfechareserva)
                    .HasColumnType("datetime")
                    .HasColumnName("DFECHARESERVA");

                entity.Property(e => e.Iidestadoreserva).HasColumnName("IIDESTADORESERVA");

                entity.Property(e => e.Iidusuario).HasColumnName("IIDUSUARIO");

                entity.Property(e => e.Numlibros).HasColumnName("NUMLIBROS");

                entity.HasOne(d => d.IidestadoreservaNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.Iidestadoreserva)
                    .HasConstraintName("FK__Reserva__IIDESTA__34C8D9D1");
            });

            modelBuilder.Entity<ReservaEstado>(entity =>
            {
                entity.HasKey(e => e.Iidestadoreserva);

                entity.ToTable("ReservaEstado");

                entity.Property(e => e.Iidestadoreserva).HasColumnName("IIDESTADORESERVA");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Vdescripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("VDESCRIPCION");

                entity.Property(e => e.Vnombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VNOMBRE");
            });

            modelBuilder.Entity<ReservaHistorial>(entity =>
            {
                entity.HasKey(e => e.Iidhistorial);

                entity.ToTable("ReservaHistorial");

                entity.Property(e => e.Iidhistorial).HasColumnName("IIDHISTORIAL");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Iidestado).HasColumnName("IIDESTADO");

                entity.Property(e => e.Iidreserva).HasColumnName("IIDRESERVA");

                entity.Property(e => e.Iidusuario).HasColumnName("IIDUSUARIO");

                entity.Property(e => e.Vobservacion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("VOBSERVACION");

                entity.HasOne(d => d.IidestadoNavigation)
                    .WithMany(p => p.ReservaHistorials)
                    .HasForeignKey(d => d.Iidestado)
                    .HasConstraintName("FK__ReservaHi__IIDES__3E52440B");

                entity.HasOne(d => d.IidreservaNavigation)
                    .WithMany(p => p.ReservaHistorials)
                    .HasForeignKey(d => d.Iidreserva)
                    .HasConstraintName("FK__ReservaHi__IIDRE__3C69FB99");

                entity.HasOne(d => d.IidusuarioNavigation)
                    .WithMany(p => p.ReservaHistorials)
                    .HasForeignKey(d => d.Iidusuario)
                    .HasConstraintName("FK__ReservaHi__IIDUS__3F466844");
            });

            modelBuilder.Entity<Sexo>(entity =>
            {
                entity.HasKey(e => e.Iidsexo);

                entity.ToTable("Sexo");

                entity.Property(e => e.Iidsexo).HasColumnName("IIDSEXO");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<TipoLibro>(entity =>
            {
                entity.HasKey(e => e.Iidtipolibro);

                entity.ToTable("TipoLibro");

                entity.Property(e => e.Iidtipolibro).HasColumnName("IIDTIPOLIBRO");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Nombretipolibro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRETIPOLIBRO");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.Iidtipousuario);

                entity.ToTable("TipoUsuario");

                entity.Property(e => e.Iidtipousuario).HasColumnName("IIDTIPOUSUARIO");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Iidusuario);

                entity.ToTable("Usuario");

                entity.Property(e => e.Iidusuario).HasColumnName("IIDUSUARIO");

                entity.Property(e => e.Bhabilitado).HasColumnName("BHABILITADO");

                entity.Property(e => e.Contra)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CONTRA");

                entity.Property(e => e.Iidpersona).HasColumnName("IIDPERSONA");

                entity.Property(e => e.Iidtipousuario).HasColumnName("IIDTIPOUSUARIO");

                entity.Property(e => e.Nombreusuario)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBREUSUARIO");

                entity.HasOne(d => d.IidpersonaNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Iidpersona)
                    .HasConstraintName("FK__Usuario__IIDPERS__276EDEB3");

                entity.HasOne(d => d.IidtipousuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Iidtipousuario)
                    .HasConstraintName("FK__Usuario__IIDTIPO__182C9B23");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
