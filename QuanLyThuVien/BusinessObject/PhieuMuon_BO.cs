using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class PhieuMuon_BO
    {
        private string maPhieu;
        private string maThanhVien;
        private DateTime ngayMuon;
        private string maNhanVien;
        private DateTime ngayTra;
        private string maSach;
        private int soLuong;

        public string MaPhieu
        {
            get
            {
                return maPhieu;
            }

            set
            {
                maPhieu = value;
            }
        }

        public string MaThanhVien
        {
            get
            {
                return maThanhVien;
            }

            set
            {
                maThanhVien = value;
            }
        }

        public DateTime NgayMuon
        {
            get
            {
                return ngayMuon;
            }

            set
            {
                ngayMuon = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }

            set
            {
                maNhanVien = value;
            }
        }

        public DateTime NgayTra
        {
            get
            {
                return ngayTra;
            }

            set
            {
                ngayTra = value;
            }
        }

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
