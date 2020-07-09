namespace BTH2
{
    partial class indanhsachsinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(indanhsachsinhvien));
            this.gTimKiem = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.gTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // gTimKiem
            // 
            this.gTimKiem.Controls.Add(this.button1);
            this.gTimKiem.Controls.Add(this.textBox1);
            this.gTimKiem.Location = new System.Drawing.Point(130, 110);
            this.gTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.gTimKiem.Name = "gTimKiem";
            this.gTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.gTimKiem.Size = new System.Drawing.Size(732, 65);
            this.gTimKiem.TabIndex = 18;
            this.gTimKiem.TabStop = false;
            this.gTimKiem.Text = "Bộ Lọc";
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 22);
            this.textBox1.TabIndex = 14;
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Location = new System.Drawing.Point(13, 197);
            this.dgvDSSV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.Size = new System.Drawing.Size(1349, 281);
            this.dgvDSSV.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(384, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 38);
            this.label5.TabIndex = 32;
            this.label5.Text = "In danh sách sinh viên";
            // 
            // btLuu
            // 
            this.btLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btLuu.ImageOptions.Image")));
            this.btLuu.Location = new System.Drawing.Point(1038, 117);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(139, 50);
            this.btLuu.TabIndex = 35;
            this.btLuu.Text = "In ";
            // 
            // indanhsachsinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 491);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDSSV);
            this.Controls.Add(this.gTimKiem);
            this.Name = "indanhsachsinhvien";
            this.Text = "indanhsachsinhvien";
            this.gTimKiem.ResumeLayout(false);
            this.gTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gTimKiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btLuu;
    }
}