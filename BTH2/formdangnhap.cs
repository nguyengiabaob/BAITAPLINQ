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
    public partial class formdangnhap : Form
    {
        public formdangnhap()
        {
            InitializeComponent();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !");
        }
    }
}
