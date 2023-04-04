using Microsoft.EntityFrameworkCore.Migrations;

namespace VesperApp.Migrations
{
    public partial class SocialMedia4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_TeamMembers_TeamMemberId",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_TeamMemberId",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "TeamMemberId",
                table: "SocialMedias");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "SocialMedias",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_TeamId",
                table: "SocialMedias",
                column: "TeamId");

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

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_TeamId",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "SocialMedias");

            migrationBuilder.AddColumn<int>(
                name: "TeamMemberId",
                table: "SocialMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_TeamMemberId",
                table: "SocialMedias",
                column: "TeamMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_TeamMembers_TeamMemberId",
                table: "SocialMedias",
                column: "TeamMemberId",
                principalTable: "TeamMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
