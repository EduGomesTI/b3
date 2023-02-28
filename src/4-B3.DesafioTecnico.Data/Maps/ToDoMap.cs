using B3.DesafioTecnico.Data.Repositories.Base;
using B3.DesafioTecnico.Domain.Aggregates.ToDos.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace B3.DesafioTecnico.Data.Maps
{
    internal class ToDoMap : BaseMap<ToDo, int>
    {
        public override void Configure(EntityTypeBuilder<ToDo> builder)
        {
            base.Configure(builder);

            builder.ToTable("ToDo");

            builder.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("Description");

            builder.Property(t => t.CreateDate)
                .IsRequired()
                .HasColumnName("CreateDate");

            builder.Property(t => t.ConclusionDate)
                .HasColumnName("ConclusionDate");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status");
                
                
        }
    }
}
