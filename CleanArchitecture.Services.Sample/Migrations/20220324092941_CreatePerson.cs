using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Services.Sample.Migrations
{

    public partial class CreatePerson : Migration
    {

        #region - - - - - - Methods - - - - - -

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.CreateTable(
                    name: "Person",
                    columns: table => new
                    {
                        ID = table.Column<int>(type: "INTEGER", nullable: false)
                            .Annotation("Sqlite:Autoincrement", true),
                        Gender = table.Column<int>(type: "INTEGER", nullable: false),
                        Name = table.Column<string>(type: "TEXT", nullable: false)
                    },
                    constraints: table => table.PrimaryKey("PK_Person", x => x.ID));

            _ = migrationBuilder.InsertData(
                    table: "Person",
                    columns: new[] { "ID", "Gender", "Name" },
                    values: new object[] { 1, 1, "Hugh Mann" });

            _ = migrationBuilder.InsertData(
                    table: "Person",
                    columns: new[] { "ID", "Gender", "Name" },
                    values: new object[] { 2, 2, "Amanda Huggen-Kiss" });

            _ = migrationBuilder.InsertData(
                    table: "Person",
                    columns: new[] { "ID", "Gender", "Name" },
                    values: new object[] { 3, 3, "GennY McStable" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
            => migrationBuilder.DropTable(name: "Person");

        #endregion Methods

    }

}
