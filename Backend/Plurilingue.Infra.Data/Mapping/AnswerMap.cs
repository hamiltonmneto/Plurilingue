using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plurilingue.Domain.Entities;

namespace Plurilingue.Infra.Data.Mapping
{
    public class AnswerMap : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasOne(a => a.Question).WithMany(q => q.Answers).HasForeignKey(a => a.Question_Id);
        }
    }
}
