namespace Bai8
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    public class KhachHang
    {
        public string SoTaiKhoan { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public long SoTien { get; set; }

        public KhachHang()
        {

        }

        public KhachHang(string soTaiKhoan, string tenKhachHang, string diaChi, long soTien)
        {
            SoTaiKhoan=soTaiKhoan;
            TenKhachHang=tenKhachHang;
            DiaChi=diaChi;
            SoTien=soTien;
        }
    }
}