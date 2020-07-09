namespace BTH2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMaSV = new System.Windows.Forms.TextBox();
            this.gThongtin = new System.Windows.Forms.GroupBox();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDiachi = new System.Windows.Forms.TextBox();
            this.i = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gTimKiem = new System.Windows.Forms.GroupBox();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.tbxTimkiem = new System.Windows.Forms.TextBox();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pHinh = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btchonhinh = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.gThongtin.SuspendLayout();
            this.gTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxMaSV
            // 
            this.tbxMaSV.Location = new System.Drawing.Point(107, 57);
            this.tbxMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMaSV.Name = "tbxMaSV";
            this.tbxMaSV.Size = new System.Drawing.Size(292, 22);
            this.tbxMaSV.TabIndex = 1;
            // 
            // gThongtin
            // 
            this.gThongtin.Controls.Add(this.dateNgaySinh);
            this.gThongtin.Controls.Add(this.cbLop);
            this.gThongtin.Controls.Add(this.radNu);
            this.gThongtin.Controls.Add(this.radNam);
            this.gThongtin.Controls.Add(this.label6);
            this.gThongtin.Controls.Add(this.tbxDiachi);
            this.gThongtin.Controls.Add(this.i);
            this.gThongtin.Controls.Add(this.label4);
            this.gThongtin.Controls.Add(this.label3);
            this.gThongtin.Controls.Add(this.tbxHoTen);
            this.gThongtin.Controls.Add(this.label2);
            this.gThongtin.Controls.Add(this.tbxMaSV);
            this.gThongtin.Controls.Add(this.label1);
            this.gThongtin.Location = new System.Drawing.Point(71, 69);
            this.gThongtin.Margin = new System.Windows.Forms.Padding(4);
            this.gThongtin.Name = "gThongtin";
            this.gThongtin.Padding = new System.Windows.Forms.Padding(4);
            this.gThongtin.Size = new System.Drawing.Size(929, 256);
            this.gThongtin.TabIndex = 8;
            this.gThongtin.TabStop = false;
            this.gThongtin.Text = "Thông tin sinh viên";
            this.gThongtin.Enter += new System.EventHandler(this.gThongtin_Enter);
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Location = new System.Drawing.Point(107, 190);
            this.dateNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(292, 22);
            this.dateNgaySinh.TabIndex = 14;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(541, 117);
            this.cbLop.Margin = new System.Windows.Forms.Padding(4);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(264, 24);
            this.cbLop.TabIndex = 13;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(715, 58);
            this.radNu.Margin = new System.Windows.Forms.Padding(4);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 21);
            this.radNu.TabIndex = 12;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(572, 54);
            this.radNam.Margin = new System.Windows.Forms.Padding(4);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(58, 21);
            this.radNam.TabIndex = 11;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Giới Tính";
            // 
            // tbxDiachi
            // 
            this.tbxDiachi.Location = new System.Drawing.Point(541, 164);
            this.tbxDiachi.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDiachi.Multiline = true;
            this.tbxDiachi.Name = "tbxDiachi";
            this.tbxDiachi.Size = new System.Drawing.Size(264, 50);
            this.tbxDiachi.TabIndex = 9;
            // 
            // i
            // 
            this.i.AutoSize = true;
            this.i.Location = new System.Drawing.Point(469, 198);
            this.i.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(51, 17);
            this.i.TabIndex = 8;
            this.i.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // tbxHoTen
            // 
            this.tbxHoTen.Location = new System.Drawing.Point(107, 124);
            this.tbxHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.tbxHoTen.Name = "tbxHoTen";
            this.tbxHoTen.Size = new System.Drawing.Size(292, 22);
            this.tbxHoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên";
            // 
            // gTimKiem
            // 
            this.gTimKiem.Controls.Add(this.btTimkiem);
            this.gTimKiem.Controls.Add(this.tbxTimkiem);
            this.gTimKiem.Location = new System.Drawing.Point(84, 348);
            this.gTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.gTimKiem.Name = "gTimKiem";
            this.gTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.gTimKiem.Size = new System.Drawing.Size(929, 65);
            this.gTimKiem.TabIndex = 9;
            this.gTimKiem.TabStop = false;
            this.gTimKiem.Text = "Tìm kiếm";
            // 
            // btTimkiem
            // 
            this.btTimkiem.Location = new System.Drawing.Point(519, 20);
            this.btTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(100, 28);
            this.btTimkiem.TabIndex = 15;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            this.btTimkiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btTimkiem_KeyPress);
            // 
            // tbxTimkiem
            // 
            this.tbxTimkiem.Location = new System.Drawing.Point(31, 23);
            this.tbxTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTimkiem.Name = "tbxTimkiem";
            this.tbxTimkiem.Size = new System.Drawing.Size(448, 22);
            this.tbxTimkiem.TabIndex = 14;
            this.tbxTimkiem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbxTimkiem_MouseDown);
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Location = new System.Drawing.Point(84, 421);
            this.dgvDSSV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.Size = new System.Drawing.Size(929, 161);
            this.dgvDSSV.TabIndex = 10;
            this.dgvDSSV.SelectionChanged += new System.EventHandler(this.dgvDSSV_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(357, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quản Lý Sinh Viên";
            // 
            // pHinh
            // 
            this.pHinh.BackColor = System.Drawing.Color.White;
            this.pHinh.Location = new System.Drawing.Point(1084, 69);
            this.pHinh.Margin = new System.Windows.Forms.Padding(4);
            this.pHinh.Name = "pHinh";
            this.pHinh.Size = new System.Drawing.Size(247, 256);
            this.pHinh.TabIndex = 12;
            this.pHinh.TabStop = false;
            // 
            // btThem
            // 
            this.btThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btThem.Location = new System.Drawing.Point(1084, 421);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 29);
            this.btThem.TabIndex = 23;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btXoa.Location = new System.Drawing.Point(1084, 485);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 29);
            this.btXoa.TabIndex = 24;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image2")));
            this.btSua.Location = new System.Drawing.Point(1084, 542);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 29);
            this.btSua.TabIndex = 25;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image3")));
            this.btLuu.Location = new System.Drawing.Point(1231, 421);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 29);
            this.btLuu.TabIndex = 26;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btHuy
            // 
            this.btHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image4")));
            this.btHuy.Location = new System.Drawing.Point(1231, 485);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(100, 29);
            this.btHuy.TabIndex = 27;
            this.btHuy.Text = "Hủy";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btThoat
            // 
            this.btThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image5")));
            this.btThoat.Location = new System.Drawing.Point(1231, 545);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 29);
            this.btThoat.TabIndex = 28;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btchonhinh
            // 
            this.btchonhinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btchonhinh.Location = new System.Drawing.Point(1175, 348);
            this.btchonhinh.Name = "btchonhinh";
            this.btchonhinh.Size = new System.Drawing.Size(104, 29);
            this.btchonhinh.TabIndex = 29;
            this.btchonhinh.Text = "chọn hình";
            this.btchonhinh.Click += new System.EventHandler(this.btchonhinh_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1407, 586);
            this.Controls.Add(this.btchonhinh);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.pHinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDSSV);
            this.Controls.Add(this.gTimKiem);
            this.Controls.Add(this.gThongtin);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gThongtin.ResumeLayout(false);
            this.gThongtin.PerformLayout();
            this.gTimKiem.ResumeLayout(false);
            this.gTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMaSV;
        private System.Windows.Forms.GroupBox gThongtin;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDiachi;
        private System.Windows.Forms.Label i;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gTimKiem;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.TextBox tbxTimkiem;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pHinh;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btThoat;
        private DevExpress.XtraEditors.SimpleButton btchonhinh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}

