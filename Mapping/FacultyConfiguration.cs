namespace DomainSample.Entities
{
    public class FacultyConfiguration : EntityConfiguration<Faculty>
    {
        public FacultyConfiguration()
        {
            #region POCO Configurations
            Property(p => p.Acronym)
                .IsRequired()
                .HasMaxLength(10);

            Property(p => p.FacultyNameEn)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.FacultyNameRu)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.FacultyDescriptionEn)
                .IsRequired()
                .HasMaxLength(1000);

            Property(p => p.FacultyDescriptionRu)
                .IsRequired()
                .HasMaxLength(1000);

            #endregion

            #region Mapping Configurations
            HasMany(p => p.Departments)
                .WithRequired(p => p.Faculty)
                .HasForeignKey(p => p.FacultyId);

            HasMany(p => p.Employees)
                .WithOptional(p => p.Faculty)
                .HasForeignKey(p => p.FacultyId);

            HasMany(p => p.Teachers)
                .WithOptional(p => p.Faculty)
                .HasForeignKey(p => p.FacultyId);

            HasMany(p => p.Students)
                .WithRequired(p => p.Faculty)
                .HasForeignKey(p => p.FacultyId);

            HasMany(p => p.Subjects)
                .WithRequired(p => p.Faculty)
                .HasForeignKey(p => p.FacultyId);

            HasMany(p => p.Specialties)
                .WithRequired(p => p.Faculty)
                .HasForeignKey(p => p.FacultyId);

            #endregion
        }
    }
}