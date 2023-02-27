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
    public partial class FHocSinh : Form
    {
        HocSinhDAO hsDAO = new HocSinhDAO();

        DBConnection dbConnection = new DBConnection();

        public FHocSinh()
        {
            InitializeComponent();
        }

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = string.Format("SELECT * FROM HocSinh");

                gvHocSinh.DataSource = dbConnection.layDanhSanh(sqlStr);
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
                HocSinh hocSinh = new HocSinh(txtMaHS.Text.Trim(), 
                                                txtTen.Text.Trim(), 
                                                txtCMND.Text.Trim(), 
                                                txtQueQuan.Text.Trim(), 
                                                txtDiaChi.Text.Trim(), 
                                                txtSDT.Text.Trim(), 
                                                txtEmail.Text.Trim(), 
                                                txtNgaySinh.Value);

                dbConnection.kiemTraHopLe(hocSinh);

                hsDAO.Them(hocSinh);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FHocSinh_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                HocSinh hocSinh = new HocSinh(txtMaHS.Text.Trim(),
                                                txtTen.Text.Trim(),
                                                txtCMND.Text.Trim(),
                                                txtQueQuan.Text.Trim(),
                                                txtDiaChi.Text.Trim(),
                                                txtSDT.Text.Trim(),
                                                txtEmail.Text.Trim(),
                                                txtNgaySinh.Value);

                dbConnection.kiemTraHopLe(hocSinh);

                hsDAO.Sua(hocSinh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FHocSinh_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                HocSinh hocSinh = new HocSinh(txtMaHS.Text.Trim(),
                                                txtTen.Text,
                                                txtCMND.Text,
                                                txtQueQuan.Text,
                                                txtDiaChi.Text,
                                                txtSDT.Text,
                                                txtEmail.Text,
                                                txtNgaySinh.Value);

                hsDAO.Xoa(hocSinh.GetMaHS());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FHocSinh_Load(sender, e);
            }
        }

        private void gvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đổ dữ liệu từ gridview vào textBox khi click vào chữ nội dung của ô 
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvHocSinh.Rows[e.RowIndex];
                txtMaHS.Text = row.Cells[0].Value.ToString().Trim();
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
