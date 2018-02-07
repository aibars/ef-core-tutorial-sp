using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Data
{
    public class spEnrollmentsByStudents : Migration
    {
        protected override void Up( MigrationBuilder migrationBuilder)
        {
            var sp = @"
                CREATE PROCEDURE [GetEnrollmentsByStudent]
                AS
                BEGIN
                SELECT * FROM Students a INNER JOIN Enrollments
                b ON b.StudentId = a.Id
                END";

            migrationBuilder.Sql(sp);
        }
    }
}