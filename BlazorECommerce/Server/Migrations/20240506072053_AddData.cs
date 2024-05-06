using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorECommerce.Server.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "ImageUrl", "description", "price", "title" },
                values: new object[] { 1, "https://upload.wikimedia.org/wikipedia/en/d/d4/Never_go_back_by_lee_child.png", "Never Go Back is the eighteenth book in the Jack Reacher series written by Lee Child.[1] It was published on 3 September 2013 in the United States", 9.99m, "Never Go Back" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "ImageUrl", "description", "price", "title" },
                values: new object[] { 2, "https://upload.wikimedia.org/wikipedia/en/3/3c/Killing_floor_by_lee_child_1st_edition_uk.png", "Killing Floor is the debut novel by Lee Child, first published in 1997 by Putnam. The book won the Anthony Award and Barry Award for best first novel. It is also the first book to feature the character Jack Reacher. It is written in the first person", 9.99m, "Killing Floor" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "ImageUrl", "description", "price", "title" },
                values: new object[] { 3, "https://upload.wikimedia.org/wikipedia/en/2/29/Tripwire_book.jpg", "Tripwire is the third book in the Jack Reacher series written by Lee Child. It was published in 1999 by Putnam in America and Bantam in the United Kingdom. It is written in the third person. In the novel, retired military police officer Jack Reacher becomes embroiled in a mystery involving a Vietnam War veteran who was reported missing in action, but who has resurfaced as a vicious loanshark with a secret he will murder to protec", 9.99m, "Trip Wire" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
