using Microsoft.EntityFrameworkCore.Migrations;

namespace VesperApp.Migrations
{
    public partial class SocialMediaUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_TeamMembers_TeamId",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "TeamMemberId",
                table: "SocialMedias");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "SocialMedias",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_TeamMembers_TeamId",
                table: "SocialMedias",
                column: "TeamId",
                principalTable: "TeamMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_TeamMembers_TeamId",
                table: "SocialMedias");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "SocialMedias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "TeamMemberId",
                table: "SocialMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_TeamMembers_TeamId",
                table: "SocialMedias",
                column: "TeamId",
                principalTable: "TeamMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
