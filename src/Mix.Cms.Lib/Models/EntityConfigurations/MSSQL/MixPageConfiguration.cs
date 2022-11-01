﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mix.Cms.Lib.Enums;
using Mix.Cms.Lib.Models.Cms;

namespace Mix.Cms.Lib.Models.EntityConfigurations.MSSQL
{
    public class MixPageConfiguration : IEntityTypeConfiguration<MixPage>
    {
        public void Configure(EntityTypeBuilder<MixPage> entity)
        {
            entity.HasKey(e => new { e.Id, e.Specificulture })
                    .HasName("PK_mix_page");

            entity.ToTable("mix_page");

            entity.Property(e => e.Id)
                .ValueGeneratedNever();

            entity.HasIndex(e => e.Specificulture);

            entity.Property(e => e.Specificulture)
                .HasColumnType("varchar(10)")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.Content)
                .HasColumnType("ntext")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

            entity.Property(e => e.CssClass)
                .HasColumnType("nvarchar(250)")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.Excerpt)
                .HasColumnType("ntext")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.ExtraFields)
                .HasColumnType("ntext")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.Icon)
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.Image)
                .HasColumnType("nvarchar(250)")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.LastModified).HasColumnType("datetime");

            entity.Property(e => e.Layout)
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.SeoDescription)
                .HasColumnType("ntext")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.SeoKeywords)
                .HasColumnType("ntext")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.SeoName)
                .HasColumnType("varchar(500)")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.SeoTitle)
                .HasColumnType("nvarchar(250)")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.StaticUrl)
                .HasColumnType("nvarchar(250)")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasConversion(new EnumToStringConverter<MixContentStatus>())
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.Tags)
                .HasColumnType("ntext")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.Template)
                .HasColumnType("nvarchar(250)")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.Title)
                .HasColumnType("ntext")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.Type)
                .HasConversion(new EnumToStringConverter<MixPageType>())
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.HasOne(d => d.SpecificultureNavigation)
                .WithMany(p => p.MixPage)
                .HasPrincipalKey(p => p.Specificulture)
                .HasForeignKey(d => d.Specificulture)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Mix_Page_Mix_Culture");

            entity.Property(e => e.EditorValue)
                .HasColumnType("text")
                .HasCharSet("utf8")
                .UseCollation("Vietnamese_CI_AS");

            entity.Property(e => e.EditorType)
               .IsRequired()
               .HasConversion(new EnumToStringConverter<MixEditorType>())
               .HasDefaultValue(MixEditorType.Html)
               .HasColumnType("varchar(50)")
               .HasCharSet("utf8")
               .UseCollation("Vietnamese_CI_AS");
        }
    }
}