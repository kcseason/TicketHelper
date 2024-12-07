namespace TicketHelper.String
{
    public static class CalcTotalType
    {
        public static readonly string Year = "按年";
        public static readonly string Month = "按月";
        public static readonly string City = "按城市";
        public static readonly string Company = "出行";
        public static readonly string Ticket = "按票类";
        public static readonly string FeeType = "按费用类别";

        public static List<string> ItineraryTypes =
        [
            "","按年","按月","按城市","出行","按票类"
        ];

        public static List<string> HotelTypes =
        [
            "","按年","按月","按城市","按费用类别"
        ];

        public static List<string> HospitalPatientTypes =
        [
            "","按年","按月","按城市","按票类"
        ];
    }
}
