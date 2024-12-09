using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btvn_buoi3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lsvSinhVien.Columns[0].Width = (int)(lsvSinhVien.Width * 0.25);
            lsvSinhVien.Columns[1].Width = (int)(lsvSinhVien.Width * 0.25);
            lsvSinhVien.Columns[2].Width = (int)(lsvSinhVien.Width * 0.25);
            lsvSinhVien.Columns[3].Width = (int)(lsvSinhVien.Width * 0.25);
            lsvSinhVien.View = View.Details;
            lsvSinhVien.GridLines = true;
            lsvSinhVien.FullRowSelect = true;

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item = lsvSinhVien.Items.Add(txtID.Text);
            item.SubItems.Add(txtHoTen.Text);
            item.SubItems.Add(txtMSSV.Text);
            item.SubItems.Add(txtCCCD.Text);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {

                foreach (ListViewItem item in lsvSinhVien.Items)
                {
                    if (item.SubItems[0].Text == txtID.Text)
                    {

                        item.SubItems[1].Text = txtHoTen.Text;
                        item.SubItems[2].Text = txtMSSV.Text;
                        item.SubItems[3].Text = txtCCCD.Text;
                        return;
                    }
                }
                MessageBox.Show("Không tìm thấy sinh viên với ID: " + txtID.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ID để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {

                foreach (ListViewItem item in lsvSinhVien.Items)
                {
                    if (item.SubItems[0].Text == txtID.Text)
                    {
                        lsvSinhVien.Items.Remove(item);
                        return;
                    }
                }
                MessageBox.Show("Không tìm thấy sinh viên với ID: " + txtID.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ID để xóa.");
            }
        }
        
    }
}
