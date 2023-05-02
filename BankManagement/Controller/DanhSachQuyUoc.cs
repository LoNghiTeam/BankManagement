using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Controller
{
    public enum ThoiHanGiaoDich
    {
        OneMonth = 1,
        ThreeMonths = 3,
        SixMonths = 6,
        TwelveMonths = 12,
        TwentyFourMonths = 24,
        ThirtySixMonths = 36
    }
    public enum LoaiLaiSuat
    {
        laivay = 1,
        laigui = 2,
        tile = 3,
        quydoiTD = 4
    }
    public enum LoaiGiaoDich
    {
        chuyentien = 1,
        naptien = 2,
        ruttien = 3,
        vaytien = 4,
        guitietkiem = 5,
        travay = 6,
        ruttietkiem = 7
    }
    public enum LoaiVay
    {
        vaythechap = 1,
        vaytindung = 2
    }
    public enum TaiKhoanGD { 
        nganhang = 1
    }
    public enum QuyenTaiKhoan
    {
        khachhang = 0,
        nhanvien = 1,
        quanly = 2
    }
    public enum TinhTrang
    {
        datra = 1,
        chuatra = 0
    }
}
