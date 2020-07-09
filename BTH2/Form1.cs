using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;
using System.IO;

namespace BTH2
{
    public partial class Form1 : Form
    {
        Table<LOP> bang_lop;
        Table<SINHVIEN> bang_sinhvien;
        string path = "../../Hinh";
        DataTable tbSinhVien, tbLop;
        SqlDataAdapter daSinhVien, daLop;
        BindingManagerBase DSSV;
        QuanlysinhvienDataContext db;
        bool capnhat = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gThongtin_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new QuanlysinhvienDataContext();
            bang_sinhvien = db.SINHVIENs;
            bang_lop = db.GetTable<LOP>();
            //tbSinhVien = new DataTable();
            //daSinhVien = new SqlDataAdapter("Select * from SINHVIEN",model.cnnStr);
            //daLop = new SqlDataAdapter("Select * from LOP", model.cnnStr);
            //tbLop = new DataTable();
                //try
                //{
                //    daSinhVien.Fill(tbSinhVien);
                //    daLop.Fill(tbLop);
                //}
                //catch(SqlException ex)
                //{
                //    MessageBox.Show(ex.ToString());
                //}
            var cmd = new SqlCommandBuilder(daSinhVien);
            Loadlop();
            loadDgv();
            tbxMaSV.DataBindings.Add("text",bang_sinhvien,"MaSV",true);
            tbxHoTen.DataBindings.Add("text",bang_sinhvien,"HoTen",true);
            tbxDiachi.DataBindings.Add("text", bang_sinhvien, "DiaChi",true);
            cbLop.DataBindings.Add("SelectedValue", bang_sinhvien, "MaLop",true);
            radNam.DataBindings.Add("checked", bang_sinhvien, "GioiTinh",true);
            dateNgaySinh.DataBindings.Add("text", bang_sinhvien, "NgaySinh", true);
            pHinh.DataBindings.Add("Image", bang_sinhvien, "Hinh",true);

            DSSV=this.BindingContext[bang_sinhvien];
            endbutton();
            
        }
        private void Loadlop()
        {
            cbLop.DataSource=bang_lop;
            cbLop.DisplayMember="TenLop";
            cbLop.ValueMember="MaLop";
        }
        private void loadDgv()
        {
            dgvDSSV.DataSource=bang_sinhvien;
  

        }
        private void endbutton()
        {
            btThem.Enabled = !capnhat;
            btLuu.Enabled = capnhat;
            btSua.Enabled = !capnhat;
            btXoa.Enabled = !capnhat;
            btHuy.Enabled = capnhat;
            gThongtin.Enabled = capnhat;
            gTimKiem.Enabled = !capnhat;
            pHinh.Enabled = capnhat;
        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            radNu.Checked = !radNam.Checked;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DSSV.AddNew();
            capnhat = true;
            endbutton();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSSV.EndCurrentEdit();
                db.SubmitChanges();
                //tbSinhVien.AcceptChanges();
                capnhat = false;
                endbutton();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
 
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSSV.RemoveAt(DSSV.Position);
                db.SubmitChanges();
               // daSinhVien.Update(tbSinhVien);
               // tbSinhVien.AcceptChanges();
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
            ChangeSet cs = db.GetChangeSet();
            db.Refresh(RefreshMode.OverwriteCurrentValues, cs.Updates);
           // tbSinhVien.RejectChanges();
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

        private void tbxTimkiem_MouseDown(object sender, MouseEventArgs e)
        {
            tbxTimkiem.Text = " ";
        }

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
                pHinh.ImageLocation = pathfile;
            }
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                DSSV.Position = bang_sinhvien.ToList().FindIndex(SV=>SV.MaSV.Contains(tbxTimkiem.Text));
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy");
;            }
        }

        private void btTimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                btTimkiem_Click(sender, e);
            }
                
                
        }



    }
}
