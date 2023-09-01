using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantDataAccessLayer.Migrations
{
    public partial class mig_add_SendMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SendMessages",
                columns: table => new
                {
                    SendMessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiverName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ReceiverMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SenderName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    SenderMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendMessages", x => x.SendMessageID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SendMessages");
        }
    }
}
