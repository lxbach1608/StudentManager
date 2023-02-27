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
    public partial class FGiangVien : Form
    {

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        GiangVienDAO gvDAO = new GiangVienDAO();

        DBConnection dbConnection = new DBConnection();

        public FGiangVien()
        {
            InitializeComponent();
        }

        private void FGiangVien_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = string.Format("SELECT * FROM GiangVien");

                gvGiangVien.DataSource = dbConnection.layDanhSanh(sqlStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                GiangVien giangVien = new GiangVien(txtMaGV.Text.Trim(),
                                                txtTen.Text.Trim(),
                                                txtCMND.Text.Trim(),
                                                txtQueQuan.Text.Trim(),
                                                txtDiaChi.Text.Trim(),
                                                txtSDT.Text.Trim(),
                                                txtEmail.Text.Trim(),
                                                txtNgaySinh.Value);

                dbConnection.kiemTraHopLe(giangVien);

                gvDAO.Them(giangVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FGiangVien_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                GiangVien giangVien = new GiangVien(txtMaGV.Text.Trim(), 
                                                    txtTen.Text.Trim(), 
                                                    txtCMND.Text.Trim(), 
                                                    txtQueQuan.Text.Trim(), 
                                                    txtDiaChi.Text.Trim(), 
                                                    txtSDT.Text.Trim(), 
                                                    txtEmail.Text.Trim(), 
                                                    txtNgaySinh.Value);

                dbConnection.kiemTraHopLe(giangVien);

                gvDAO.Sua(giangVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FGiangVien_Load(sender, e);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                GiangVien giangVien = new GiangVien(txtMaGV.Text.Trim(),
                                                    txtTen.Text,
                                                    txtCMND.Text,
                                                    txtQueQuan.Text,
                                                    txtDiaChi.Text,
                                                    txtSDT.Text,
                                                    txtEmail.Text,
                                                    txtNgaySinh.Value);

                gvDAO.Xoa(giangVien.GetMaGV());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FGiangVien_Load(sender, e);
            }

        }

        private void gvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đổ dữ liệu từ gridview vào textBox khi click vào chữ nội dung của ô 

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvGiangVien.Rows[e.RowIndex];
                txtMaGV.Text = row.Cells[0].Value.ToString().Trim();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtCMND.Text = row.Cells[2].Value.ToString().Trim();
                txtQueQuan.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                txtSDT.Text = row.Cells[5].Value.ToString().Trim();
                txtEmail.Text = row.Cells[6].Value.ToString();
                txtNgaySinh.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
