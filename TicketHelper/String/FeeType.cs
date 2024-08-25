namespace TicketHelper.String
{
    public static class FeeType
    {
        public static readonly string Other = "其他";
        public static readonly string Living = "住宿费";
        public static readonly string Traffic = "交通费";
        public static readonly string Restore = "康复费";
        public static readonly string InPatient = "住院费";
        public static readonly string OutPatient = "门诊费";

        public static List<string> HospitalFeeTypes =
        [
            "全部","交通费","住宿费","门诊费","康复费","住院费","其他"
        ];
        public static List<string> HotelFeeTypes =
        [
            "全部","租房","酒店"
        ];
    }
}
