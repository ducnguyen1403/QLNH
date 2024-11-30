using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QLNH.Models;

public partial class DoAnPtudwContext : DbContext
{
    public DoAnPtudwContext()
    {
    }

    public DoAnPtudwContext(DbContextOptions<DoAnPtudwContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAdmin> TblAdmins { get; set; }

    public virtual DbSet<TblBill> TblBills { get; set; }

    public virtual DbSet<TblMenu> TblMenus { get; set; }

    public virtual DbSet<TblPage> TblPages { get; set; }

    public virtual DbSet<TblPageComment> TblPageComments { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblProductCategory> TblProductCategories { get; set; }

    public virtual DbSet<TblProductReview> TblProductReviews { get; set; }

    public virtual DbSet<TblRole> TblRoles { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAdmin>(entity =>
        {
            entity.HasKey(e => e.AdminId);

            entity.ToTable("tblAdmin");

            entity.Property(e => e.AdminId).HasColumnName("AdminID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.Role).WithMany(p => p.TblAdmins)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_tblAdmin_tblRole");
        });

        modelBuilder.Entity<TblBill>(entity =>
        {
            entity.HasKey(e => e.BillId);

            entity.ToTable("tblBill");

            entity.Property(e => e.BillId).HasColumnName("BillID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.BillCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(50);

            entity.HasOne(d => d.User).WithMany(p => p.TblBills)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_tblBill_tblUser");
        });

        modelBuilder.Entity<TblMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.ToTable("tblMenu");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<TblPage>(entity =>
        {
            entity.HasKey(e => e.PageId);

            entity.ToTable("tblPage");

            entity.Property(e => e.PageId).HasColumnName("PageID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(4000);
            entity.Property(e => e.Image).HasMaxLength(500);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<TblPageComment>(entity =>
        {
            entity.HasKey(e => e.PageCommentId);

            entity.ToTable("tblPageComment");

            entity.Property(e => e.PageCommentId).HasColumnName("PageCommentID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.PageId).HasColumnName("PageID");
            entity.Property(e => e.UserName).HasMaxLength(50);

            entity.HasOne(d => d.Page).WithMany(p => p.TblPageComments)
                .HasForeignKey(d => d.PageId)
                .HasConstraintName("FK_tblPageComment_tblPage");
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId);

            entity.ToTable("tblProduct");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");
            entity.Property(e => e.ProductName).HasMaxLength(50);

            entity.HasOne(d => d.ProductCategory).WithMany(p => p.TblProducts)
                .HasForeignKey(d => d.ProductCategoryId)
                .HasConstraintName("FK_tblProduct_tblProductCategory");
        });

        modelBuilder.Entity<TblProductCategory>(entity =>
        {
            entity.HasKey(e => e.ProductCategoryId);

            entity.ToTable("tblProductCategory");

            entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<TblProductReview>(entity =>
        {
            entity.HasKey(e => e.ProductReviewId);

            entity.ToTable("tblProductReview");

            entity.Property(e => e.ProductReviewId).HasColumnName("ProductReviewID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Detail).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.Product).WithMany(p => p.TblProductReviews)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_tblProductReview_tblProduct");
        });

        modelBuilder.Entity<TblRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("tblRole");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("tblUser");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
