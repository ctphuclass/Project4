using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class SeachBO
    {
        private string maSach;
        private string tenSach;     
        private string tenNXB;
        private string tenTG;
        private string theLoai;
        private DateTime ngayNhap;
        private int gia;
        private int soLuong;       
       

        public string MaSach
        {
            get
            {
                return maSach;
            }

            set
            {
                maSach = value;
            }
        }

        public string TenSach
        {
            get
            {
                return tenSach;
            }

            set
            {
                tenSach = value;
            }
        }

        public string TenNXB
        {
            get
            {
                return tenNXB;
            }

            set
            {
                tenNXB = value;
            }
        }

        public string TenTG
        {
            get
            {
                return tenTG;
            }

            set
            {
                tenTG = value;
            }
        }

        public string TheLoai
        {
            get
            {
                return theLoai;
            }

            set
            {
                theLoai = value;
            }
        }

        public DateTime NgayNhap
        {
            get
            {
                return ngayNhap;
            }

            set
            {
                ngayNhap = value;
            }
        }

        public int Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }
    }
}
