namespace TicketHelper.String
{
    public static class TicketType
    {
        public static readonly string Other = "其他";
        public static readonly string Taxi = "打车票";
        public static readonly string Airplane = "飞机票";
        public static readonly string Train = "高铁票";
        public static readonly string Bicycle = "自行车";

        public static List<string> TicketTypes =
        [
            "全部","打车票","飞机票","自行车","高铁票","其他"
        ];
    }
}
