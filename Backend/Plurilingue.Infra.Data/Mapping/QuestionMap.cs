using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plurilingue.Domain.Entities;

namespace Plurilingue.Infra.Data.Mapping
{
    public class QuestionMap : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasOne(q => q.User).WithMany(q => q.Questions).HasForeignKey(q => q.User_Id);
        }
    }
}
