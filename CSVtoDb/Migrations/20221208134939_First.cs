using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSVtoDb.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BookingReference = table.Column<string>(type: "TEXT", nullable: false),
                    OrderReference = table.Column<string>(type: "TEXT", nullable: false),
                    OTAReference = table.Column<string>(type: "TEXT", nullable: false),
                    Group = table.Column<string>(type: "TEXT", nullable: false),
                    GuestFirstName = table.Column<string>(type: "TEXT", nullable: false),
                    GuestLastName = table.Column<string>(type: "TEXT", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Nights = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomUnitType = table.Column<string>(type: "TEXT", nullable: false),
                    RatePlan = table.Column<string>(type: "TEXT", nullable: false),
                    RoomUnitName = table.Column<string>(type: "TEXT", nullable: false),
                    Beds = table.Column<string>(type: "TEXT", nullable: false),
                    Adults = table.Column<int>(type: "INTEGER", nullable: false),
                    Children = table.Column<int>(type: "INTEGER", nullable: false),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    TotalRevenue = table.Column<decimal>(type: "TEXT", nullable: false),
                    PaidAmount = table.Column<string>(type: "TEXT", nullable: false),
                    RoomUnitRevenue = table.Column<decimal>(type: "TEXT", nullable: false),
                    OtherRevenue = table.Column<string>(type: "TEXT", nullable: false),
                    Method = table.Column<string>(type: "TEXT", nullable: false),
                    Source = table.Column<string>(type: "TEXT", nullable: false),
                    Channel = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentMethod = table.Column<string>(type: "TEXT", nullable: false),
                    BookingStatus = table.Column<string>(type: "TEXT", nullable: false),
                    Arrival = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GuestEmail = table.Column<string>(type: "TEXT", nullable: false),
                    GuestPhone1 = table.Column<string>(type: "TEXT", nullable: false),
                    GuestPhone2 = table.Column<string>(type: "TEXT", nullable: false),
                    BookingNotes = table.Column<string>(type: "TEXT", nullable: false),
                    ExtrasBookedOnline = table.Column<string>(type: "TEXT", nullable: false),
                    PromoName = table.Column<string>(type: "TEXT", nullable: false),
                    PromoCode = table.Column<string>(type: "TEXT", nullable: false),
                    PromoDiscount = table.Column<decimal>(type: "TEXT", nullable: false),
                    BookingDateAndTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: false),
                    MemberId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");
        }
    }
}
