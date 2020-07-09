using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BTH2
{
    public partial class Nhapthongytinsinhvien : Form
    {
        string path = "../../Hinh";
        DataTable tbSinhVien, tbLop;
        SqlDataAdapter daSinhVien, daLop;
        BindingManagerBase DSSV;
        bool capnhat = false;
        public Nhapthongytinsinhvien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gThongtin_Enter(object sender, EventArgs e)
        {

        }

       
        private void Loadlop()
        {
            //cbLop.DataSource=tbLop;
            //cbLop.DisplayMember="TenLop";
            //cbLop.ValueMember="MaLop";
        }
        private void loadDgv()
        {
           dgvDSSV.DataSource=tbSinhVien;
  

        }
        private void endbutton()
        {
            //btThem.Enabled = !capnhat;
            //btLuu.Enabled = capnhat;
            //btSua.Enabled = !capnhat;
           // btXoa.Enabled = !capnhat;
            //btHuy.Enabled = capnhat;
            //gThongtin.Enabled = capnhat;
            //gTimKiem.Enabled = !capnhat;
            //pHinh.Enabled = capnhat;
        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            //radNu.Checked = !radNam.Checked;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DSSV.AddNew();
            capnhat = true;
            endbutton();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DSSV.EndCurrentEdit();
            //    daSinhVien.Update(tbSinhVien);
            //    tbSinhVien.AcceptChanges();
            //    capnhat = false;               endbutton();
            //}
            //catch(SqlException ex)
            //{
            //    MessageBox.Show(ex.ToString());

            //}
            MessageBox.Show("Lưu thành công!");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSSV.RemoveAt(DSSV.Position);
                daSinhVien.Update(tbSinhVien);
                tbSinhVien.AcceptChanges();
                capnhat = false;
                endbutton();
            }
             catch(SqlException ex)
            {
                tbSinhVien.RejectChanges();
                 MessageBox.Show("Xoa That bai");
 
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            DSSV.CancelCurrentEdit();
            tbSinhVien.RejectChanges();
            capnhat = false;
            endbutton();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            endbutton();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
           

        }

        //private void tbxTimkiem_MouseDown(object sender, MouseEventArgs e)
        //{
        //    tbxTimkiem.Text = " ";
        //}

        private void dgvDSSV_SelectionChanged(object sender, EventArgs e)
        {
            if(capnhat)
            {
                btHuy_Click(sender, e);
            }
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btchonhinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG Files|*.jpg|PNG Files|*.png|ALL Files|*.*";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string filename = openFileDialog1.SafeFileName;
                string pathfile = path + "/" + filename;
                if(!File.Exists(pathfile))
                {
                    File.Copy(filename, pathfile);

                }
                //pHinh.ImageLocation = pathfile;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Nhapthongytinsinhvien_Load(object sender, EventArgs e)
        {
            tbSinhVien = new DataTable();
            daSinhVien = new SqlDataAdapter("select * from SINHVIEN", model.cnnStr);
            daLop = new SqlDataAdapter("Select * from LOP", model.cnnStr);
            tbLop = new DataTable();
            try
            {
                daSinhVien.Fill(tbSinhVien);
                daLop.Fill(tbLop);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            SqlCommandBuilder cmd = new SqlCommandBuilder(daSinhVien);
            Loadlop();
            loadDgv();
            ////tbxMaSV.DataBindings.Add("text", tbSinhVien, "MaSV", true);
            //tbxHoTen.DataBindings.Add("text", tbSinhVien, "HoTen", true);
            //tbxDiachi.DataBindings.Add("text", tbSinhVien, "DiaChi", true);
            //cbLop.DataBindings.Add("SelectedValue", tbSinhVien, "MaLop", true);
            //radNam.DataBindings.Add("checked", tbSinhVien, "GioiTinh", true);
            //dateNgaySinh.DataBindings.Add("text", tbSinhVien, "NgaySinh", true);
            // pHinh.DataBindings.Add("Image",tbSinhVien,"Hinh",true);

            DSSV = this.BindingContext[tbSinhVien];
            endbutton();

        }

        private void Nhapthongytinsinhvien_FormClosed(object sender, FormClosedEventArgs e)
        {
            PictureBox p = (PictureBox)model.pc;
            p.Show();
        }

//        //private void btTimkiem_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                DataRow r = tbSinhVien.Select("MaSV='" + tbxTimkiem.Text + "'")[0];
//                DSSV.Position = tbSinhVien.Rows.IndexOf(r);
               
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Không tìm thấy");
//;            }
//        }

        //private void btTimkiem_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if(e.KeyChar==(char)Keys.Enter)
        //    {
        //        btTimkiem_Click(sender, e);
        //    }
                
                
        //}
   



    }
}
