using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH2
{  
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void nhâp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Nhapthongytinsinhvien nhapthongtin = new Nhapthongytinsinhvien();
            nhapthongtin.MdiParent = this;
            nhapthongtin.WindowState = FormWindowState.Maximized;
            nhapthongtin.StartPosition = FormStartPosition.CenterScreen;
            nhapthongtin.Show();
            pictureBox1.Hide(); ;
        }

        private void Formmain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            model.pc = pictureBox1;
            //formdangnhap f = new formdangnhap();
            //f.MdiParent = this;
            //f.StartPosition = FormStartPosition.CenterScreen;
            //f.ShowDialog(); ;
        }
    }
}
