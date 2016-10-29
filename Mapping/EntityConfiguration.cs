using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DomainSample.Entities
{
    public abstract class EntityConfiguration<T> : EntityTypeConfiguration<T> where T : Entity
    {
        protected EntityConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.RowVersion).IsRowVersion();
        }
    }
}