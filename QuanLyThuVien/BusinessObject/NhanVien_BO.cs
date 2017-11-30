using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class NhanVien_BO
    {
        private string maNV;
        private string hoTenNV;
        private bool gioiTinh;
        private DateTime ngaySinh;
        private string soDienThoai;
        private string diaChi;
        private string email;
        private DateTime ngayVaoLam;

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }

        public string HoTenNV
        {
            get
            {
                return hoTenNV;
            }

            set
            {
                hoTenNV = value;
            }
        }

        public bool GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime NgayVaoLam
        {
            get
            {
                return ngayVaoLam;
            }

            set
            {
                ngayVaoLam = value;
            }
        }
    }
}
