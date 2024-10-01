namespace Buoi06_LinQ
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
            this.dgv_MonHoc = new System.Windows.Forms.DataGridView();
            this.dgv_SinhVien = new System.Windows.Forms.DataGridView();
            this.btn_GetFirst = new System.Windows.Forms.Button();
            this.btn_EndSinhVien = new System.Windows.Forms.Button();
            this.btn_getSinhVien2And3 = new System.Windows.Forms.Button();
            this.btn_SXGiamDanTheoTen = new System.Windows.Forms.Button();
            this.btn_GetSVLop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MonHoc
            // 
            this.dgv_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MonHoc.Location = new System.Drawing.Point(12, 12);
            this.dgv_MonHoc.Name = "dgv_MonHoc";
            this.dgv_MonHoc.Size = new System.Drawing.Size(385, 228);
            this.dgv_MonHoc.TabIndex = 0;
            // 
            // dgv_SinhVien
            // 
            this.dgv_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SinhVien.Location = new System.Drawing.Point(415, 12);
            this.dgv_SinhVien.Name = "dgv_SinhVien";
            this.dgv_SinhVien.Size = new System.Drawing.Size(385, 228);
            this.dgv_SinhVien.TabIndex = 1;
            // 
            // btn_GetFirst
            // 
            this.btn_GetFirst.Location = new System.Drawing.Point(815, 12);
            this.btn_GetFirst.Name = "btn_GetFirst";
            this.btn_GetFirst.Size = new System.Drawing.Size(122, 23);
            this.btn_GetFirst.TabIndex = 2;
            this.btn_GetFirst.Text = "Lay sinh vien dau tien";
            this.btn_GetFirst.UseVisualStyleBackColor = true;
            // 
            // btn_EndSinhVien
            // 
            this.btn_EndSinhVien.Location = new System.Drawing.Point(815, 41);
            this.btn_EndSinhVien.Name = "btn_EndSinhVien";
            this.btn_EndSinhVien.Size = new System.Drawing.Size(129, 23);
            this.btn_EndSinhVien.TabIndex = 3;
            this.btn_EndSinhVien.Text = "Lay sinh vien cuoi cung";
            this.btn_EndSinhVien.UseVisualStyleBackColor = true;
            // 
            // btn_getSinhVien2And3
            // 
            this.btn_getSinhVien2And3.Location = new System.Drawing.Point(815, 70);
            this.btn_getSinhVien2And3.Name = "btn_getSinhVien2And3";
            this.btn_getSinhVien2And3.Size = new System.Drawing.Size(129, 23);
            this.btn_getSinhVien2And3.TabIndex = 4;
            this.btn_getSinhVien2And3.Text = "Lay sinh vien 2 va 3";
            this.btn_getSinhVien2And3.UseVisualStyleBackColor = true;
            // 
            // btn_SXGiamDanTheoTen
            // 
            this.btn_SXGiamDanTheoTen.Location = new System.Drawing.Point(815, 99);
            this.btn_SXGiamDanTheoTen.Name = "btn_SXGiamDanTheoTen";
            this.btn_SXGiamDanTheoTen.Size = new System.Drawing.Size(146, 23);
            this.btn_SXGiamDanTheoTen.TabIndex = 5;
            this.btn_SXGiamDanTheoTen.Text = "Sap xep giam dan theo ten";
            this.btn_SXGiamDanTheoTen.UseVisualStyleBackColor = true;
            // 
            // btn_GetSVLop
            // 
            this.btn_GetSVLop.Location = new System.Drawing.Point(815, 128);
            this.btn_GetSVLop.Name = "btn_GetSVLop";
            this.btn_GetSVLop.Size = new System.Drawing.Size(146, 23);
            this.btn_GetSVLop.TabIndex = 6;
            this.btn_GetSVLop.Text = "Lay sinh vien va lop";
            this.btn_GetSVLop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 637);
            this.Controls.Add(this.btn_GetSVLop);
            this.Controls.Add(this.btn_SXGiamDanTheoTen);
            this.Controls.Add(this.btn_getSinhVien2And3);
            this.Controls.Add(this.btn_EndSinhVien);
            this.Controls.Add(this.btn_GetFirst);
            this.Controls.Add(this.dgv_SinhVien);
            this.Controls.Add(this.dgv_MonHoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MonHoc;
        private System.Windows.Forms.DataGridView dgv_SinhVien;
        private System.Windows.Forms.Button btn_GetFirst;
        private System.Windows.Forms.Button btn_EndSinhVien;
        private System.Windows.Forms.Button btn_getSinhVien2And3;
        private System.Windows.Forms.Button btn_SXGiamDanTheoTen;
        private System.Windows.Forms.Button btn_GetSVLop;
    }
}

