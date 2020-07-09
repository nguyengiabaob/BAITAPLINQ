namespace BTH2
{
    partial class Nhapthongytinsinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhapthongytinsinhvien));
            this.label5 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.btThoat = new DevExpress.XtraEditors.SimpleButton();
            this.gTimKiem = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.gTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(494, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Danh sách sinh viên";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // btThoat
            // 
            this.btThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.ImageOptions.Image")));
            this.btThoat.Location = new System.Drawing.Point(697, 393);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 64);
            this.btThoat.TabIndex = 28;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // gTimKiem
            // 
            this.gTimKiem.Controls.Add(this.button1);
            this.gTimKiem.Controls.Add(this.textBox5);
            this.gTimKiem.Location = new System.Drawing.Point(258, 56);
            this.gTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.gTimKiem.Name = "gTimKiem";
            this.gTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.gTimKiem.Size = new System.Drawing.Size(732, 57);
            this.gTimKiem.TabIndex = 36;
            this.gTimKiem.TabStop = false;
            this.gTimKiem.Text = "Bộ lọc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(48, 29);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(448, 22);
            this.textBox5.TabIndex = 14;
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Location = new System.Drawing.Point(29, 121);
            this.dgvDSSV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.Size = new System.Drawing.Size(1349, 254);
            this.dgvDSSV.TabIndex = 37;
            // 
            // btLuu
            // 
            this.btLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btLuu.ImageOptions.Image")));
            this.btLuu.Location = new System.Drawing.Point(539, 393);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 64);
            this.btLuu.TabIndex = 26;
            this.btLuu.Text = "In";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // Nhapthongytinsinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1407, 469);
            this.Controls.Add(this.dgvDSSV);
            this.Controls.Add(this.gTimKiem);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.label5);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Nhapthongytinsinhvien";
            this.Text = "Cập nhật thông tin sinh viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Nhapthongytinsinhvien_FormClosed);
            this.Load += new System.EventHandler(this.Nhapthongytinsinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.gTimKiem.ResumeLayout(false);
            this.gTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.SimpleButton btThoat;
        private System.Windows.Forms.GroupBox gTimKiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private DevExpress.XtraEditors.SimpleButton btLuu;
    }
}

