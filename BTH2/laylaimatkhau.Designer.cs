namespace BTH2
{
    partial class laylaimatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(laylaimatkhau));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbdangnhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btdangnhap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbdangnhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(177, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(214, 34);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Lấy Lại mật khẩu";
            // 
            // tbdangnhap
            // 
            this.tbdangnhap.Location = new System.Drawing.Point(258, 126);
            this.tbdangnhap.Name = "tbdangnhap";
            this.tbdangnhap.Size = new System.Drawing.Size(231, 22);
            this.tbdangnhap.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(59, 124);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 23);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Tên đăng nhập:";
            // 
            // btthoat
            // 
            this.btthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btthoat.ImageOptions.Image")));
            this.btthoat.Location = new System.Drawing.Point(288, 219);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(130, 47);
            this.btthoat.TabIndex = 20;
            this.btthoat.Text = "Thoát";
            // 
            // btdangnhap
            // 
            this.btdangnhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btdangnhap.ImageOptions.Image")));
            this.btdangnhap.Location = new System.Drawing.Point(108, 219);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(125, 47);
            this.btdangnhap.TabIndex = 19;
            this.btdangnhap.Text = "Gửi";
            // 
            // laylaimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 325);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btdangnhap);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tbdangnhap);
            this.Controls.Add(this.labelControl1);
            this.Name = "laylaimatkhau";
            this.Text = "doimoimatkhau";
            ((System.ComponentModel.ISupportInitialize)(this.tbdangnhap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btthoat;
        private DevExpress.XtraEditors.SimpleButton btdangnhap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tbdangnhap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}