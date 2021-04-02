using Microsoft.EntityFrameworkCore.Migrations;

namespace Divers_Hotel.Data.Migrations
{
    public partial class changeTheRelationBetweenRoomTypeEntityAndRoomEntityToManyToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomTypeID",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "RoomTypes",
                newName: "TypeName");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeID",
                table: "Rooms",
                column: "RoomTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomTypeID",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "TypeName",
                table: "RoomTypes",
                newName: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeID",
                table: "Rooms",
                column: "RoomTypeID",
                unique: true);
        }
    }
}
