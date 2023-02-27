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
    class HocSinhDAO
    {
        DBConnection dbConnection = new DBConnection();

        public void Them(HocSinh hocSinh)
        {
            try
            {
                dbConnection.openConnectDB();

                string sqlStr =
                    string.Format("INSERT INTO HocSinh(maHS, ten, CMND, queQuan, diaChi, SDT, email, ngaySinh) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                    hocSinh.GetMaHS(),
                    hocSinh.GetTen(),
                    hocSinh.GetCMND(),
                    hocSinh.GetQueQuan(),
                    hocSinh.GetDiaChi(),
                    hocSinh.GetSDT(),
                    hocSinh.GetEmail(),
                    hocSinh.GetNgayThangNamSinh());

                dbConnection.thucThi(sqlStr, "Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnection.closeConnectDB();
            }
        }

        public void Sua(HocSinh hocSinh)
        {
            try
            {
                dbConnection.openConnectDB();

                string sqlStr =
                    string.Format("UPDATE HocSinh SET ten = '{1}', CMND = '{2}', queQuan = '{3}', diaChi = '{4}', SDT = '{5}', email = '{6}', ngaySinh = '{7}' Where maHS ='{0}'",
                    hocSinh.GetMaHS(),
                    hocSinh.GetTen(),
                    hocSinh.GetCMND(),
                    hocSinh.GetQueQuan(),
                    hocSinh.GetDiaChi(),
                    hocSinh.GetSDT(),
                    hocSinh.GetEmail(),
                    hocSinh.GetNgayThangNamSinh());

                dbConnection.thucThi(sqlStr, "Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnection.closeConnectDB();
            }
        }

        public void Xoa(string maHS)
        {
            try
            {
                dbConnection.openConnectDB();

                string sqlStr = string.Format("DELETE FROM HocSinh WHERE maHS = '{0}'", maHS);


                dbConnection.thucThi(sqlStr, "Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnection.closeConnectDB();
            }
        }

    }
}
