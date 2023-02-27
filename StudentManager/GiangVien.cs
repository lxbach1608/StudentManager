using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class GiangVien
    {
        private string maGV;

        private string ten;

        private string CMND;

        private string queQuan;

        private string diaChi;

        private string SDT;

        private string email;

        private DateTime ngayThangNamSinh;

        public GiangVien(string maGV, string ten, string CMND, string queQuan, string diaChi, string SDT, string email, DateTime ngayThangNamSinh)
        {
            this.SetMaGV(maGV);
            this.SetTen(ten);
            this.SetCMND(CMND);
            this.SetQueQuan(queQuan);
            this.SetDiaChi(diaChi);
            this.SetSDT(SDT);
            this.SetEmail(email);
            this.SetNgayThangNamSinh(ngayThangNamSinh.Date);
        }

        public string GetMaGV()
        {
            return maGV;
        }

        public void SetMaGV(string value)
        {
            maGV = value;
        }

        public string GetTen()
        {
            return ten;
        }

        public void SetTen(string value)
        {
            ten = value;
        }

        public string GetCMND()
        {
            return CMND;
        }

        public void SetCMND(string value)
        {
            CMND = value;
        }


        public string GetQueQuan()
        {
            return queQuan;
        }

        public void SetQueQuan(string value)
        {
            queQuan = value;
        }

        public string GetDiaChi()
        {
            return diaChi;
        }

        public void SetDiaChi(string value)
        {
            diaChi = value;
        }

        public string GetSDT()
        {
            return SDT;
        }

        public void SetSDT(string value)
        {
            SDT = value;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }

        public DateTime GetNgayThangNamSinh()
        {
            return ngayThangNamSinh;
        }

        public void SetNgayThangNamSinh(DateTime value)
        {
            ngayThangNamSinh = value;
        }
    }
}
