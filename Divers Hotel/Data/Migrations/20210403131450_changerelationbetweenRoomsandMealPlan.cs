using Microsoft.EntityFrameworkCore.Migrations;

namespace Divers_Hotel.Data.Migrations
{
    public partial class changerelationbetweenRoomsandMealPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rooms_MealPlanID",
                table: "Rooms");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_MealPlanID",
                table: "Rooms",
                column: "MealPlanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rooms_MealPlanID",
                table: "Rooms");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_MealPlanID",
                table: "Rooms",
                column: "MealPlanID",
                unique: true);
        }
    }
}
