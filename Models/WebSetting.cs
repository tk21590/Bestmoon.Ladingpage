namespace BestViaCustomer.LandingPage.Models
{
    public class WebSetting
    {
        public static string AppName => "Bestmoon";
        public static string WebName => "Bestmoon.vn";
        public static string WebUrl => "https://bestmoon.vn";
        public static string TitleName => "BestMoon cung cấp dịch vụ giải pháp marketing 4.0";
        public static string AppFlavor { get; set; } = "Bestmoon 1.0";
        public static string Company { get; set; } = "Bestmoon Company";
        public static string CompanyPhone { get; set; } = "0948744797";
        public static string CompanyMail{ get; set; } = "bestmoon.offical@gmail.com";
        public static string Version { get; set; } = "1.1.0";
        public static string Copyright { get; set; } = "@2024";
        public static string Address { get; set; } = "183/72/2, Nguyễn Văn Khối Phường 8, Quận Gò Vấp, TP.HCM";
        public static string BankName { get; set; } = "VO HUY TOAN";
        public static string BankNumber { get; set; } = "100919949999";
        public static string BankNoti { get; set; } = "Nạp tiền thấp hơn giá trị thấp nhất sẽ không được giải quyết";
        public static string BankNoti2 { get; set; } = "Số dư trong tài khoản được sử dụng để mua các dịch vụ trên web, không hỗ trợ hoàn lại tiền mặt hoặc chuyển khoản với bất kì lý do gì!";
        public static int BankMinNumber { get; set; } = 50000;
        public static List<string> NotiforUser = new List<string>
        {
          "Vui lòng lấy đúng tài khoản trạng thái IMG_282,check kỹ order tránh tạo nhầm, tính năng đang trong giai đoạn thử nghiệm nên sẽ không hoàn tiền nếu bạn tạo nhầm",
          "Đơn hàng trạng thái lỗi Block từ khách hàng (sai Pass| sai 2FA| Block_956| Block_very phone| Block_Devices ) tỉ lệ trên 50% đơn hàng sẽ TRỪ 100đ/acc",
          "Ngiêm cấm giải Tài khoản hack từ người dùng VN or có hành vi vi phạm pháp luật, chính trị, đồ trụy... Nếu cố tình bạn sẽ bị trừ hết tiền và band khỏi hệ thống vĩnh viễn, và phải chịu hoàn toàn trách nhiệm trước pháp luật.",
          "Đơn hàng sẽ được đối soát, tất toán và hoàn tiền tự động sau 30 tiếng kể từ khi đơn hàng được hoàn tất. ",
          "Mọi Góp Ý - Hổ Trợ Nhắn Tin Zalo 090.1801.183",
        };

    }
}
