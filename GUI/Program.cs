using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        //                       _oo0oo_				        NAM MÔ ADI ĐÀ PHẬT
        //                      o8888888o		Thí chủ con tên là Trần Anh Quân, dương lịch mười tháng bẩy 2004
        //                      88" . "88		Ngụ tại 479/29 Lĩnh Nam, Hoàng Mai, Hà Nôi, Việt Nam
        //                      (| -_- |)		
        //                      0\  =  /0		     Con lạy chín phương trời, con lạy mười phương đất
        //                    ___/`---'\___		        Chư Phật mười phương, mười phương chư Phật
        //                  .' \\|     |// '.		     Con ơn nhờ trời đất có chỗ che, Thánh Thần cứu độ
        //                 / \\|||  :  |||// \		Xin nhất tâm kính lễ Hoàng thiên Hậu tổ, Tiên Phật Thánh Thần
        //                / _||||| -:- |||||- \			Giúp đỡ con code sạch, ít bug
        //               |   | \\\  -  /// |   |				Bạn bè vui vẻ, thầy cô quý mến
        //               | \_|  ''\---/''  |_/ |		Sức khỏe dồi dào, tiền vào như nước
        //               \  .-\__  '-'  ___/-. /	
        //             ___'. .'  /--.--\  `. .'___
        //          ."" '<  `.___\_<|>_/___.' >' "".	NAM MÔ VIÊN THÔNG GIÁO CHỦ ĐẠI TỪ ĐẠI BI TẤM THANH CỨU KHỔ CỨU NẠN
        //         | | :  `- \`.;`\ _ /`;.`/ - ` : | |	        QUẢN ĐẠI LINH CẢM QUAN THẾ ÂM BỒ TÁT
        //         \  \ `_.   \_ __\ /__ _/   .-` /  /	
        //     =====`-.____`.___ \_____/___.-`___.-'=====
        //                       `=---='
        //
        //    
        //           
        //   
        [STAThread]

        static void Main()
        {
            if(Environment.OSVersion.Version.Major >= 6) {
                SetProcessDPIAware();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DangNhapForm());
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
