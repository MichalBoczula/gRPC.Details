using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gRPC.DeepDive.Service.Persistance.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDoLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
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
                columns: new[] { "Id", "Name", "StatusId" },
                values: new object[] { 1, "Initial", 1 });

            migrationBuilder.InsertData(
                table: "ToDoTasks",
                columns: new[] { "Id", "Name", "StatusId", "ToDoListId" },
                values: new object[] { 1, "First", 1, 1 });

            migrationBuilder.InsertData(
                table: "ToDoTasks",
                columns: new[] { "Id", "Name", "StatusId", "ToDoListId" },
                values: new object[] { 2, "Second", 1, 1 });

            migrationBuilder.InsertData(
                table: "ToDoTasks",
                columns: new[] { "Id", "Name", "StatusId", "ToDoListId" },
                values: new object[] { 3, "Third", 2, 1 });

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
