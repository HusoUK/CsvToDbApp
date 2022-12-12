using LINQtoCSV;

namespace CSVtoDb.Models
{
    public class BookingModel
    {
        public int Id { get; set; } = 0;

        [CsvColumn(Name = "Booking Date", FieldIndex = 1)]
        public DateTime BookingDate { get; set; }
        [CsvColumn(Name = "Booking Reference", FieldIndex = 2)]
        public string BookingReference { get; set; } = "Not given";
        [CsvColumn(Name = "Order Reference", FieldIndex = 3)]
        public string OrderReference { get; set; } = "Not given";
        [CsvColumn(Name = "OTA Reference", FieldIndex = 4)]
        public string OTAReference { get; set; } = "Not given";
        [CsvColumn(Name = "Group", FieldIndex = 5)]
        public string Group { get; set; } = "Not given";
        [CsvColumn(Name = "Guest First Name", FieldIndex = 6)]
        public string GuestFirstName { get; set; } = "Not given";
        [CsvColumn(Name = "Guest Last Name", FieldIndex = 7)]
        public string GuestLastName { get; set; } = "Not given";
        [CsvColumn(Name = "Check In", FieldIndex = 8)]
        public DateTime CheckIn { get; set; }
        [CsvColumn(Name = "Check Out", FieldIndex = 9)]
        public DateTime CheckOut { get; set; }
        [CsvColumn(Name = "Nights", FieldIndex = 10)]
        public int Nights { get; set; } = 0;

        [CsvColumn(Name = "Room/Unit Type", FieldIndex = 11)]
        public string RoomUnitType { get; set; } = @"N/A";
        [CsvColumn(Name = "Rate Plan", FieldIndex = 12)]
        public string RatePlan { get; set; } = @"N/A";
        [CsvColumn(Name = "Room/Unit Name", FieldIndex = 13)]
        public string RoomUnitName { get; set; } = @"N/A";
        [CsvColumn(Name = "Beds", FieldIndex = 14)]
        public string Beds { get; set; } = "Not given";
        [CsvColumn(Name = "Adults", FieldIndex = 15)]
        public int Adults { get; set; } = 0;
        [CsvColumn(Name = "Children", FieldIndex = 16)]
        public int Children { get; set; } = 0;
        [CsvColumn(Name = "Currency", FieldIndex = 17)]
        public string Currency { get; set; } = "Not given";
        [CsvColumn(Name = "Total Revenue", FieldIndex = 18)]
        public decimal TotalRevenue { get; set; } = 0;
        [CsvColumn(Name = "Paid Amount", FieldIndex = 19)]
        public string PaidAmount { get; set; } = "Nil";
        [CsvColumn(Name = "Room/Unit Revenue", FieldIndex = 20)]
        public decimal RoomUnitRevenue { get; set; } = 0;

        [CsvColumn(Name = "Other Revenue", FieldIndex = 21)]
        public string OtherRevenue { get; set; } = "Nil";
        [CsvColumn(Name = "Method", FieldIndex = 22)]
        public string Method { get; set; } = "Not given";
        [CsvColumn(Name = "Source", FieldIndex = 23)]
        public string Source { get; set; } = "Not given";
        [CsvColumn(Name = "Channel", FieldIndex = 24)]
        public string Channel { get; set; } = "Not given";
        [CsvColumn(Name = "Payment Method", FieldIndex = 25)]
        public string PaymentMethod { get; set; } = "Not given";
        [CsvColumn(Name = "Booking Status", FieldIndex = 26)]
        public string BookingStatus { get; set; } = "Nil";
        [CsvColumn(Name = "Arrival", FieldIndex = 27)]
        public DateTime Arrival { get; set; }
        [CsvColumn(Name = "Guest Email", FieldIndex = 28)]
        public string GuestEmail { get; set; } = "Not given";
        [CsvColumn(Name = "Guest Phone 1", FieldIndex = 29)]
        public string GuestPhone1 { get; set; } = "Not given";
        [CsvColumn(Name = "Guest Phone 2", FieldIndex = 30)]
        public string GuestPhone2 { get; set; } = "Not given";

        [CsvColumn(Name = "Booking Notes", FieldIndex = 31)]
        public string BookingNotes { get; set; } = "None";
        [CsvColumn(Name = "Extras Booked Online", FieldIndex = 32)]
        public string ExtrasBookedOnline { get; set; } = @"N/A";
        [CsvColumn(Name = "Promo Name", FieldIndex = 33)]
        public string PromoName { get; set; } = @"N/A";
        [CsvColumn(Name = "Promo Code", FieldIndex = 34)]
        public string PromoCode { get; set; } = @"N/A";
        [CsvColumn(Name = "Promo Discount", FieldIndex = 35)]
        public decimal PromoDiscount { get; set; } = 0;
        [CsvColumn(Name = "Booking Date and Time", FieldIndex = 36)]
        public DateTime BookingDateAndTime { get; set; }
        [CsvColumn(Name = "CompanyName", FieldIndex = 37)]
        public string CompanyName { get; set; } = @"N/A";
        [CsvColumn(Name = "MemberId", FieldIndex = 38)]
        public string MemberId { get; set; } = @"N/A";

    }
}
