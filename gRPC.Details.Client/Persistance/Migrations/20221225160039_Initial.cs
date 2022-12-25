using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gRPC.Details.Client.Persistance.Migrations
{
    internal partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDoLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToDoTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToDoListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToDoTasks_ToDoLists_ToDoListId",
                        column: x => x.ToDoListId,
                        principalTable: "ToDoLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ToDoLists",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "ToDoTasks",
                columns: new[] { "Id", "ToDoListId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ToDoTasks",
                columns: new[] { "Id", "ToDoListId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "ToDoTasks",
                columns: new[] { "Id", "ToDoListId" },
                values: new object[] { 3, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ToDoTasks_ToDoListId",
                table: "ToDoTasks",
                column: "ToDoListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDoTasks");

            migrationBuilder.DropTable(
                name: "ToDoLists");
        }
    }
}
