using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Web.Mvc;
using MyWatchStore.Models;

namespace MyWatchStore.Controllers
{
    public class WatchesController : Controller
    {
        // Danh sách đồng hồ tạm thời để minh họa
        private static List<Watch> watches = new List<Watch>
        {
            new Watch { Mã = 1, Tên = "Rolex xịn xò", Thông_tin = "là một chiếc rolex chính gốc, nhập khẩu nước ngoài với đầy đủ thông tin pháp lý ", Giá = 15000.00M, Ảnh = "/images/rolex-submariner.jpg" },
            new Watch { Mã = 2, Tên = "Omega Speedmaster", Thông_tin = "Classic chronograph watch", Giá = 5000.00M, Ảnh = "/images/omega-speedmaster.jpg" }
        };

        // Action method để hiển thị chi tiết sản phẩm
        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                // ID không được cung cấp, sử dụng giá trị mặc định
                id = 1;
            }

            var watch = watches.FirstOrDefault(w => w.Mã == id.Value);
            if (watch == null)
            {
                return HttpNotFound();
            }
            return View(watch);
        }

        public ActionResult MenWatches()
        {

            return View();
        }

        public ActionResult WomenWatches()
        {

            return View();
        }

        public ActionResult CoupleWatches()
        {

            return View();
        }

        public ActionResult ProductDetails(int id)
        {

            return View();


        }
        public ActionResult Banner()
        {
            return View();
        }
       
    }

    public class ServicesController : Controller
    {
        public ActionResult Warranty()
        {
            // Logic để lấy thông tin dịch vụ bảo hành
            return View();
        }

        public ActionResult Repair()
        {
            // Logic để lấy thông tin dịch vụ sửa chữa
            return View();
        }

        public ActionResult OtherServices()
        {
            // Logic để lấy thông tin các dịch vụ khác
            return View();
        }



    }
    public class LichsuController : Controller
    {
        // Danh sách lịch sử mua hàng tạm thời để minh họa
        private static List<Watch> lichsumuahang = new List<Watch>
        {
            new Watch { Mã = 1, TenKH = "Nguyen Van A", Tên = "Rolex Submariner", Ngay = new DateTime(2023, 5, 1), Giá = 15000.00M, Thông_tin = "Delivered" },
            new Watch { Mã = 2, TenKH = "Le Thi B", Tên = "Omega Speedmaster", Ngay = new DateTime(2023, 6, 15), Giá = 5000.00M, Thông_tin = "Pending" }
        };

        // Action method để hiển thị lịch sử mua hàng
        public ActionResult Lichsu()
        {
            return View(lichsumuahang);
        }
    }
}

