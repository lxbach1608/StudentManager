using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class HocSinh
    {
        private string maHS;

        private string ten;

        private string CMND;

        private string queQuan;

        private string diaChi;

        private string SDT;

        private string email;

        private DateTime ngayThangNamSinh;

        public HocSinh(string maHS, string ten, string CMND, string queQuan, string diaChi, string SDT, string email, DateTime ngayThangNamSinh)
        {
            this.SetMaHS(maHS);
            this.SetTen(ten);
            this.SetCMND(CMND);
            this.SetQueQuan(queQuan);
            this.SetDiaChi(diaChi);
            this.SetSDT(SDT);
            this.SetEmail(email);
            this.SetNgayThangNamSinh(ngayThangNamSinh.Date);
        }

        public string GetMaHS()
        {
            return maHS;
        }

        public void SetMaHS(string value)
        {
            maHS = value;
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
