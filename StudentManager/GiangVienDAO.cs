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

namespace StudentManager
{
    class GiangVienDAO
    {
        DBConnection dbConnection = new DBConnection();

        public void Them(GiangVien giangVien)
        {
            try
            {
                dbConnection.openConnectDB();

                string sqlStr =
                    string.Format("INSERT INTO GiangVien(maGV, ten, CMND, queQuan, diaChi, SDT, email, ngaySinh) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                    giangVien.GetMaGV(),
                    giangVien.GetTen(),
                    giangVien.GetCMND(),
                    giangVien.GetQueQuan(),
                    giangVien.GetDiaChi(),
                    giangVien.GetSDT(),
                    giangVien.GetEmail(),
                    giangVien.GetNgayThangNamSinh());

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

        public void Sua(GiangVien giangVien)
        {
            try
            {
                dbConnection.openConnectDB();

                string sqlStr =
                    string.Format("UPDATE GiangVien SET ten = '{1}', CMND = '{2}', queQuan = '{3}', diaChi = '{4}', SDT = '{5}', email = '{6}', ngaySinh = '{7}' Where maGV ='{0}'",
                    giangVien.GetMaGV(),
                    giangVien.GetTen(),
                    giangVien.GetCMND(),
                    giangVien.GetQueQuan(),
                    giangVien.GetDiaChi(),
                    giangVien.GetSDT(),
                    giangVien.GetEmail(),
                    giangVien.GetNgayThangNamSinh());

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

        public void Xoa(string maGV)
        {
            try
            {
                dbConnection.openConnectDB();

                string sqlStr = string.Format("DELETE FROM GiangVien WHERE maGV = '{0}'", maGV);


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
