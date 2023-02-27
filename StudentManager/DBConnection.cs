using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace StudentManager
{
    class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public void openConnectDB()
        {
            conn.Open();
        }

        public void closeConnectDB()
        {
            conn.Close();
        }

        public DataTable layDanhSanh(string sqlStr)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            return dt;
        }

        public void thucThi(string sqlStr, string message)
        {
            SqlCommand cmd = new SqlCommand(sqlStr, conn);

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show($"{message}");
        }

        public void kiemTraHopLe(GiangVien giangVien)
        {
            if (kiemTraNull(giangVien))
                throw new Exception("Không được để trống bất kì ô nào !!");

            if (!kiemTraSDT(giangVien.GetSDT()))
                throw new Exception("SDT không hợp lệ! Yêu cầu: 10 số và không có kí tự chữ cái hay kí tự đặc biệt");

            if (!kiemTraEmail(giangVien.GetEmail()))
                throw new Exception("Email không hợp lệ!");
        }

        public void kiemTraHopLe(HocSinh hocSinh)
        {
            if (kiemTraNull(hocSinh))
                throw new Exception("Không được để trống bất kì ô nào !!");

            if (!kiemTraSDT(hocSinh.GetSDT()))
                throw new Exception("SDT không hợp lệ! Yêu cầu: 10 số và không có kí tự chữ cái hay kí tự đặc biệt");

            if (!kiemTraEmail(hocSinh.GetEmail()))
                throw new Exception("Email không hợp lệ!");
        }

        public bool kiemTraNull(GiangVien giangVien)
        {
            if (giangVien.GetMaGV() == ""
                || giangVien.GetTen() == ""
                || giangVien.GetCMND() == ""
                || giangVien.GetQueQuan() == ""
                || giangVien.GetDiaChi() == ""
                || giangVien.GetSDT() == ""
                || giangVien.GetEmail() == "")
            {
                return true;
            }
            return false;
        }

        public bool kiemTraNull(HocSinh hocSinh)
        {
            if (hocSinh.GetMaHS() == ""
                || hocSinh.GetTen() == ""
                || hocSinh.GetCMND() == ""
                || hocSinh.GetQueQuan() == ""
                || hocSinh.GetDiaChi() == ""
                || hocSinh.GetSDT() == ""
                || hocSinh.GetEmail() == "")
            {
                return true;
            }
            return false;
        }

        public bool kiemTraSDT(string SDT)
        {
            Regex regex = new Regex(@"^\+?\d{10}$");


            return regex.IsMatch(SDT);
        }

        public bool kiemTraEmail(string email)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            return regex.IsMatch(email);
        }
    }
}
