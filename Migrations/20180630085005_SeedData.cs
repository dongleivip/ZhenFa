using Microsoft.EntityFrameworkCore.Migrations;

namespace ZhenFa.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO \"Orders\" (\"Customer\", \"OrderDate\") VALUES ('测试-dev', '2018-01-01');");

            var selectOrderId = "(SELECT \"Id\" FROM \"Orders\" WHERE \"Customer\" = '测试-dev')";

            migrationBuilder.Sql($"INSERT INTO \"Items\" (\"Name\", \"Count\", \"Specs\", \"OrderId\") VALUES ('测试-Item-1', '1', '规格-1', {selectOrderId});");
            migrationBuilder.Sql($"INSERT INTO \"Items\" (\"Name\", \"Count\", \"Specs\", \"OrderId\") VALUES ('测试-Item-2', '2', '规格-1', {selectOrderId});");
            migrationBuilder.Sql($"INSERT INTO \"Items\" (\"Name\", \"Count\", \"Specs\", \"OrderId\") VALUES ('测试-Item-3', '3', '规格-1', {selectOrderId});");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM \"Orders\" WHERE \"Customer\" = '测试-dev'");
        }
    }
}
