namespace DomainSample.Entities
{
    public class TeacherConfiguration : EntityConfiguration<Teacher>
    {
        // I suppose problem is hidden here. TeacherConfiguration inherits from 
        // EntityConfiguration and may miss configuration of Employee. Am I right?
        public TeacherConfiguration()
        {
            HasMany(p => p.ReadeableSubjects)
                .WithMany(p => p.ReadeableTeachers)
                .Map(m =>
                {
                    m.MapLeftKey("TeacherId");
                    m.MapRightKey("SubjectId");
                    m.ToTable("TeacherSubject");
                });
        }
    }
}