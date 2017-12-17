using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class KhoSach_BO
    {
        private string maSach;
        private string tenSach;
        private int gia;
        private int daMuon;
        private int conLai;

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

        public int DaMuon
        {
            get
            {
                return daMuon;
            }

            set
            {
                daMuon = value;
            }
        }

        public int ConLai
        {
            get
            {
                return conLai;
            }

            set
            {
                conLai = value;
            }
        }
    }
}
