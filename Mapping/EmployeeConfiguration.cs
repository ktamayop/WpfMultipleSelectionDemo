using System.Data.Entity.ModelConfiguration;

namespace DomainSample.Entities
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            #region POCO Configuration

            Property(p => p.EmployeeId)
                .IsRequired()
                .IsConcurrencyToken(true);

            #endregion

            #region Mapping Configuration

            HasMany(p => p.EmployeeCurrentPositions)
                .WithMany(p => p.TakingEmployees)
                .Map(p =>
                {
                    p.MapLeftKey("EmployeeId");
                    p.MapRightKey("PositionId");
                    p.ToTable("EmployeePosition");
                });

            HasMany(p => p.EmployeeCurrentDegrees)
                .WithMany(p => p.TakingEmployees)
                .Map(p =>
                {
                    p.MapLeftKey("EmployeeId");
                    p.MapRightKey("DegreeId");
                    p.ToTable("EmployeeDegree");
                });

            HasMany(p => p.EmployeeCurrentRoles)
                .WithMany(p => p.TakingEmployees)
                .Map(p =>
                {
                    p.MapLeftKey("EmployeeId");
                    p.MapRightKey("RoleId");
                    p.ToTable("EmployeeRole");
                });

            #endregion

        }
    }
}
